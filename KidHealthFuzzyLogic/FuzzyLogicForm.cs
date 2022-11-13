using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace KidHealthFuzzyLogic
{
    public partial class FuzzyLogicForm : Form
    {
        #region Decalre
        static Dictionary<string, List<double>> lsPointCC;
        static Dictionary<string, List<double>> lsPointCN;
        static Dictionary<string, List<double>> lsPointVDTH;
        static Dictionary<string, List<double>> lsPointVDT;
        #endregion

        #region Constructor
        public FuzzyLogicForm()
        {
            InitializeComponent();
            InitListPoint();

            FuzzificationChieuCao(Common.ChieuCao);
            FuzzificationCanNang(Common.CanNang);
            FuzzificationVDTH(Common.VDTH);
            FuzzificationVDT(Common.VDT);
        }
        #endregion

        #region Method
        /// <summary>
        /// Khởi tạo các tọa độ điểm liên quan
        /// </summary>
        private void InitListPoint()
        {
            // lấy tiêu chí đánh giá theo độ tuổi và giới tính
            switch (Common.Age)
            {
                case 2:
                    if (Common.Gender == 0)
                    {
                        lsPointCC = Common.lsChieuCaoPointNam2;
                        lsPointCN = Common.lsCanNangPointNam2;
                    }
                    else
                    {
                        lsPointCC = Common.lsChieuCaoPointNu2;
                        lsPointCN = Common.lsCanNangPointNu2;
                    }
                    lsPointVDTH = Common.lsVDTHPoint2;
                    lsPointVDT = Common.lsVDTPoint2;
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region DrawGraph


        /// <summary>
        /// Vẽ đồ thị mờ hóa chiều cao
        /// </summary>
        /// <param name="position"></param>
        private void DrawChieuCao(double position)
        {
            // Vẽ đồ thị
            chartChieuCao.Titles.Add("Mờ hóa chiều cao");
            chartChieuCao.ChartAreas[0].AxisX.IsMarginVisible = false;
            chartChieuCao.ChartAreas[0].AxisY.IsMarginVisible = false;

            var index = 0;
            var lsPointName = Common.lsChieuCaoName;
            // lặp từng tập mờ để tính toán
            foreach (var key in lsPointName.Keys.ToList())
            {
                var lineName = lsPointName[key];
                chartChieuCao.Series.Add(lineName);
                chartChieuCao.Series[lineName].ChartType = SeriesChartType.Line;
                chartChieuCao.Series[lineName].BorderWidth = 3;
                if(index == 0)
                {
                    chartChieuCao.Series[lineName].Points.AddXY(0, 1);
                    chartChieuCao.Series[lineName].Points.AddXY(lsPointCC[key][1], 1);
                    chartChieuCao.Series[lineName].Points.AddXY(lsPointCC[key][2], 0);
                } else if(index == lsPointName.Count - 1)
                {
                    chartChieuCao.Series[lineName].Points.AddXY(lsPointCC[key][0], 0);
                    chartChieuCao.Series[lineName].Points.AddXY(lsPointCC[key][1], 1);
                    chartChieuCao.Series[lineName].Points.AddXY(lsPointCC[key][2], 1);
                } else
                {
                    // TH: hình thang
                    if(lsPointCC[key].Count == 4)
                    {
                        chartChieuCao.Series[lineName].Points.AddXY(lsPointCC[key][0], 0);
                        chartChieuCao.Series[lineName].Points.AddXY(lsPointCC[key][1], 1);
                        chartChieuCao.Series[lineName].Points.AddXY(lsPointCC[key][2], 1);
                        chartChieuCao.Series[lineName].Points.AddXY(lsPointCC[key][3], 0);
                    }
                    // TH: hình tam giác
                    
                }

                index++;
            }

            // Vẽ các điểm mờ hóa
            chartChieuCao.Series.Add("mapping");
            chartChieuCao.Series["mapping"].ChartType = SeriesChartType.Line;
            chartChieuCao.Series["mapping"].BorderWidth = 3;
            chartChieuCao.Series["mapping"].BorderDashStyle = ChartDashStyle.Dash;
            chartChieuCao.Series["mapping"].Color = Color.Red;
            chartChieuCao.Series["mapping"].IsVisibleInLegend = false;
            chartChieuCao.Series["mapping"].Points.AddXY(position, 0);
            int i = 1;
            foreach (var point in Common.lsFuzzificationChieuCao)
            {
                // kiểm tra trùng điểm
                var isExistsPoint = chartChieuCao.Series["mapping"].Points.Any(f => f.YValues[0] == point.Value);

                if (point.Value != 0 && !isExistsPoint)
                {
                    chartChieuCao.Series["mapping"].Points.AddXY(position, point.Value);
                    chartChieuCao.Series["mapping"].Points[i].MarkerStyle = MarkerStyle.Circle;
                    chartChieuCao.Series["mapping"].Points[i].MarkerSize = 10;
                    RectangleAnnotation tx1 = new RectangleAnnotation();

                    tx1.Text = point.Value.ToString("n2");
                    tx1.BackColor = Color.Black;
                    tx1.ForeColor = Color.White;
                    tx1.AnchorOffsetY = 5;
                    tx1.SetAnchor(chartChieuCao.Series["mapping"].Points[i]);
                    chartChieuCao.Annotations.Add(tx1);
                    i++;

                }
            }
            chartChieuCao.Series["mapping"].Points.AddXY(position, 1);

        }

        /// <summary>
        /// Vẽ đồ thị mờ hóa chiều cao
        /// </summary>
        /// <param name="position"></param>
        private void DrawCanNang(double position)
        {
            // Vẽ đồ thị
            chartCanNang.Titles.Add("Mờ hóa cân nặng");
            chartCanNang.ChartAreas[0].AxisX.IsMarginVisible = false;
            chartCanNang.ChartAreas[0].AxisY.IsMarginVisible = false;

            var index = 0;
            var lsPointName = Common.lsCanNangName;
            // lặp từng tập mờ để tính toán
            foreach (var key in lsPointName.Keys.ToList())
            {
                var lineName = lsPointName[key];
                chartCanNang.Series.Add(lineName);
                chartCanNang.Series[lineName].ChartType = SeriesChartType.Line;
                chartCanNang.Series[lineName].BorderWidth = 3;
                if (index == 0)
                {
                    chartCanNang.Series[lineName].Points.AddXY(0, 1);
                    chartCanNang.Series[lineName].Points.AddXY(lsPointCN[key][1], 1);
                    chartCanNang.Series[lineName].Points.AddXY(lsPointCN[key][2], 0);
                }
                else if (index == lsPointName.Count - 1)
                {
                    chartCanNang.Series[lineName].Points.AddXY(lsPointCN[key][0], 0);
                    chartCanNang.Series[lineName].Points.AddXY(lsPointCN[key][1], 1);
                    chartCanNang.Series[lineName].Points.AddXY(lsPointCN[key][2], 1);
                }
                else
                {
                    // TH: hình thang
                    if (lsPointCN[key].Count == 4)
                    {
                        chartCanNang.Series[lineName].Points.AddXY(lsPointCN[key][0], 0);
                        chartCanNang.Series[lineName].Points.AddXY(lsPointCN[key][1], 1);
                        chartCanNang.Series[lineName].Points.AddXY(lsPointCN[key][2], 1);
                        chartCanNang.Series[lineName].Points.AddXY(lsPointCN[key][3], 0);
                    }
                    // TH: hình tam giác
                }

                index++;
            }

            // Vẽ các điểm mờ hóa
            chartCanNang.Series.Add("mapping");
            chartCanNang.Series["mapping"].ChartType = SeriesChartType.Line;
            chartCanNang.Series["mapping"].BorderWidth = 3;
            chartCanNang.Series["mapping"].BorderDashStyle = ChartDashStyle.Dash;
            chartCanNang.Series["mapping"].Color = Color.Red;
            chartCanNang.Series["mapping"].IsVisibleInLegend = false;
            chartCanNang.Series["mapping"].Points.AddXY(position, 0);
            int i = 1;
            foreach (var point in Common.lsFuzzificationCanNang)
            {
                // kiểm tra trùng điểm
                var isExistsPoint = chartCanNang.Series["mapping"].Points.Any(f => f.YValues[0] == point.Value);

                if (point.Value != 0 && !isExistsPoint)
                {
                    chartCanNang.Series["mapping"].Points.AddXY(position, point.Value);
                    chartCanNang.Series["mapping"].Points[i].MarkerStyle = MarkerStyle.Circle;
                    chartCanNang.Series["mapping"].Points[i].MarkerSize = 10;
                    RectangleAnnotation tx1 = new RectangleAnnotation();

                    tx1.Text = point.Value.ToString("n2");
                    tx1.BackColor = Color.Black;
                    tx1.ForeColor = Color.White;
                    tx1.AnchorOffsetY = 5;
                    tx1.SetAnchor(chartCanNang.Series["mapping"].Points[i]);
                    chartCanNang.Annotations.Add(tx1);
                    i++;

                }
            }
            chartCanNang.Series["mapping"].Points.AddXY(position, 1);

        }

        /// <summary>
        /// Vẽ đồ thị mờ hóa vận động thô
        /// </summary>
        /// <param name="position"></param>
        private void DrawVDTH(int position)
        {
            // Vẽ đồ thị
            chartVDTH.Titles.Add("Mờ hóa vận động thô");
            chartVDTH.ChartAreas[0].AxisX.IsMarginVisible = false;
            chartVDTH.ChartAreas[0].AxisY.IsMarginVisible = false;

            var index = 0;
            var lsPointName = Common.lsVDTHName;
            // lặp từng tập mờ để tính toán
            foreach (var key in lsPointName.Keys.ToList())
            {
                var lineName = lsPointName[key];
                chartVDTH.Series.Add(lineName);
                chartVDTH.Series[lineName].ChartType = SeriesChartType.Line;
                chartVDTH.Series[lineName].BorderWidth = 3;
                if (index == 0)
                {
                    chartVDTH.Series[lineName].Points.AddXY(0, 1);
                    chartVDTH.Series[lineName].Points.AddXY(lsPointVDTH[key][1], 1);
                    chartVDTH.Series[lineName].Points.AddXY(lsPointVDTH[key][2], 0);
                }
                else if (index == lsPointName.Count - 1)
                {
                    chartVDTH.Series[lineName].Points.AddXY(lsPointVDTH[key][0], 0);
                    chartVDTH.Series[lineName].Points.AddXY(lsPointVDTH[key][1], 1);
                    chartVDTH.Series[lineName].Points.AddXY(lsPointVDTH[key][2], 1);
                }
                else
                {
                    // TH: hình thang
                    if (lsPointVDTH[key].Count == 4)
                    {
                        chartVDTH.Series[lineName].Points.AddXY(lsPointVDTH[key][0], 0);
                        chartVDTH.Series[lineName].Points.AddXY(lsPointVDTH[key][1], 1);
                        chartVDTH.Series[lineName].Points.AddXY(lsPointVDTH[key][2], 1);
                        chartVDTH.Series[lineName].Points.AddXY(lsPointVDTH[key][3], 0);
                    }
                    // TH: hình tam giác
                }

                index++;
            }

            // Vẽ các điểm mờ hóa
            chartVDTH.Series.Add("mapping");
            chartVDTH.Series["mapping"].ChartType = SeriesChartType.Line;
            chartVDTH.Series["mapping"].BorderWidth = 3;
            chartVDTH.Series["mapping"].BorderDashStyle = ChartDashStyle.Dash;
            chartVDTH.Series["mapping"].Color = Color.Red;
            chartVDTH.Series["mapping"].IsVisibleInLegend = false;
            chartVDTH.Series["mapping"].Points.AddXY(position, 0);
            int i = 1;
            foreach (var point in Common.lsFuzzificationVDTH)
            {
                // kiểm tra trùng điểm
                var isExistsPoint = chartVDTH.Series["mapping"].Points.Any(f => f.YValues[0] == point.Value);

                if (point.Value != 0 && !isExistsPoint)
                {
                    chartVDTH.Series["mapping"].Points.AddXY(position, point.Value);
                    chartVDTH.Series["mapping"].Points[i].MarkerStyle = MarkerStyle.Circle;
                    chartVDTH.Series["mapping"].Points[i].MarkerSize = 10;
                    RectangleAnnotation tx1 = new RectangleAnnotation();

                    tx1.Text = point.Value.ToString("n2");
                    tx1.BackColor = Color.Black;
                    tx1.ForeColor = Color.White;
                    tx1.AnchorOffsetY = 5;
                    tx1.SetAnchor(chartVDTH.Series["mapping"].Points[i]);
                    chartVDTH.Annotations.Add(tx1);
                    i++;

                }
            }
            chartVDTH.Series["mapping"].Points.AddXY(position, 1);

        }

        /// <summary>
        /// Vẽ đồ thị mờ hóa vận động tinh
        /// </summary>
        /// <param name="position"></param>
        private void DrawVDT(int position)
        {
            // Vẽ đồ thị
            chartVDT.Titles.Add("Mờ hóa vận động tinh");
            chartVDT.ChartAreas[0].AxisX.IsMarginVisible = false;
            chartVDT.ChartAreas[0].AxisY.IsMarginVisible = false;

            var index = 0;
            var lsPointName = Common.lsVDTName;
            // lặp từng tập mờ để tính toán
            foreach (var key in lsPointName.Keys.ToList())
            {
                var lineName = lsPointName[key];
                chartVDT.Series.Add(lineName);
                chartVDT.Series[lineName].ChartType = SeriesChartType.Line;
                chartVDT.Series[lineName].BorderWidth = 3;
                if (index == 0)
                {
                    chartVDT.Series[lineName].Points.AddXY(0, 1);
                    chartVDT.Series[lineName].Points.AddXY(lsPointVDT[key][1], 1);
                    chartVDT.Series[lineName].Points.AddXY(lsPointVDT[key][2], 0);
                }
                else if (index == lsPointName.Count - 1)
                {
                    chartVDT.Series[lineName].Points.AddXY(lsPointVDT[key][0], 0);
                    chartVDT.Series[lineName].Points.AddXY(lsPointVDT[key][1], 1);
                    chartVDT.Series[lineName].Points.AddXY(lsPointVDT[key][2], 1);
                }
                else
                {
                    // TH: hình thang
                    if (lsPointVDT[key].Count == 4)
                    {
                        chartVDT.Series[lineName].Points.AddXY(lsPointVDT[key][0], 0);
                        chartVDT.Series[lineName].Points.AddXY(lsPointVDT[key][1], 1);
                        chartVDT.Series[lineName].Points.AddXY(lsPointVDT[key][2], 1);
                        chartVDT.Series[lineName].Points.AddXY(lsPointVDT[key][3], 0);
                    }
                    // TH: hình tam giác
                }

                index++;
            }

            // Vẽ các điểm mờ hóa
            chartVDT.Series.Add("mapping");
            chartVDT.Series["mapping"].ChartType = SeriesChartType.Line;
            chartVDT.Series["mapping"].BorderWidth = 3;
            chartVDT.Series["mapping"].BorderDashStyle = ChartDashStyle.Dash;
            chartVDT.Series["mapping"].Color = Color.Red;
            chartVDT.Series["mapping"].IsVisibleInLegend = false;
            chartVDT.Series["mapping"].Points.AddXY(position, 0);
            int i = 1;
            foreach (var point in Common.lsFuzzificationVDT)
            {
                // kiểm tra trùng điểm
                var isExistsPoint = chartVDT.Series["mapping"].Points.Any(f => f.YValues[0] == point.Value);

                if (point.Value != 0 && !isExistsPoint)
                {
                    chartVDT.Series["mapping"].Points.AddXY(position, point.Value);
                    chartVDT.Series["mapping"].Points[i].MarkerStyle = MarkerStyle.Circle;
                    chartVDT.Series["mapping"].Points[i].MarkerSize = 10;
                    RectangleAnnotation tx1 = new RectangleAnnotation();

                    tx1.Text = point.Value.ToString("n2");
                    tx1.BackColor = Color.Black;
                    tx1.ForeColor = Color.White;
                    tx1.AnchorOffsetY = 5;
                    tx1.SetAnchor(chartVDT.Series["mapping"].Points[i]);
                    chartVDT.Annotations.Add(tx1);
                    i++;

                }
            }
            chartVDT.Series["mapping"].Points.AddXY(position, 1);

        }

        #endregion

        #region Mờ hóa
        /// <summary>
        /// Thực hiện mờ hóa chiều cao
        /// </summary>
        /// <param name="position">tọa độ điểm xét</param>
        private void FuzzificationChieuCao(double position)
        {
            var index = 0;
            // lặp từng tạp mờ để tính toán
            foreach (var key in lsPointCC.Keys.ToList())
            {
                if (index == 0)
                {
                // TH tập mờ đầu tiên
                    if (position <= lsPointCC[key][1])
                    {
                        Common.lsFuzzificationChieuCao[key] = 1;
                    } else if(lsPointCC[key][1] < position && position < lsPointCC[key][2])
                    {
                        Common.lsFuzzificationChieuCao[key] = Math.Round( 1.0 * (lsPointCC[key][2] - position) / (lsPointCC[key][2] - lsPointCC[key][1]), 2);
                    } else
                    {
                        Common.lsFuzzificationChieuCao[key] = 0;
                    }

                } else if(index == Common.lsChieuCaoPointNu2.Count - 1)
                {
                // TH tập mờ cuối cùng
                    if (position <= lsPointCC[key][0])
                    {
                        Common.lsFuzzificationChieuCao[key] = 0;
                    }
                    else if (lsPointCC[key][0] < position && position < lsPointCC[key][1])
                    {
                        Common.lsFuzzificationChieuCao[key] = Math.Round(1.0 * (position - lsPointCC[key][0]) / (lsPointCC[key][1] - lsPointCC[key][0]), 2);
                    }
                    else
                    {
                        Common.lsFuzzificationChieuCao[key] = 1;
                    }
                } else
                {
                    if (position <= lsPointCC[key][0] || position >= lsPointCC[key][lsPointCC[key].Count - 1])
                    {
                        Common.lsFuzzificationChieuCao[key] = 0;
                    } else
                    {
                        // TH: hình thang
                        if(lsPointCC[key].Count == 4)
                        {
                            if (lsPointCC[key][0] < position && position < lsPointCC[key][1])
                            {
                                Common.lsFuzzificationChieuCao[key] = Math.Round(1.0 * (position - lsPointCC[key][0]) / (lsPointCC[key][1] - lsPointCC[key][0]), 2);
                            }
                            else if (lsPointCC[key][2] < position && position < lsPointCC[key][3])
                            {
                                Common.lsFuzzificationChieuCao[key] = Math.Round(1.0 * (lsPointCC[key][3]- position) / (lsPointCC[key][3] - lsPointCC[key][2]), 2);
                            }
                            else
                            {
                                Common.lsFuzzificationChieuCao[key] = 1;
                            }
                        }
                        // TH: hình tam giác
                        // ...

                    }
                }
                index++;
            }

            // vẽ đồ thị
            DrawChieuCao(position);
        }

        /// <summary>
        /// Thực hiện mờ hóa cân nặng
        /// </summary>
        /// <param name="position">tọa độ điểm xét</param>
        private void FuzzificationCanNang(double position)
        {
            var index = 0;
            // lặp từng tạp mờ để tính toán
            foreach (var key in lsPointCN.Keys.ToList())
            {
                if (index == 0)
                {
                    // TH tập mờ đầu tiên
                    if (position <= lsPointCN[key][1])
                    {
                        Common.lsFuzzificationCanNang[key] = 1;
                    }
                    else if (lsPointCN[key][1] < position && position < lsPointCN[key][2])
                    {
                        Common.lsFuzzificationCanNang[key] = Math.Round(1.0 * (lsPointCN[key][2] - position) / (lsPointCN[key][2] - lsPointCN[key][1]), 2);
                    }
                    else
                    {
                        Common.lsFuzzificationCanNang[key] = 0;
                    }

                }
                else if (index == lsPointCN.Count - 1)
                {
                    // TH tập mờ cuối cùng
                    if (position <= lsPointCN[key][0])
                    {
                        Common.lsFuzzificationCanNang[key] = 0;
                    }
                    else if (lsPointCN[key][0] < position && position < lsPointCN[key][1])
                    {
                        Common.lsFuzzificationCanNang[key] = Math.Round(1.0 * (position - lsPointCN[key][0]) / (lsPointCN[key][1] - lsPointCN[key][0]), 2);
                    }
                    else
                    {
                        Common.lsFuzzificationCanNang[key] = 1;
                    }
                }
                else
                {
                    if (position <= lsPointCN[key][0] || position >= lsPointCN[key][lsPointCN[key].Count - 1])
                    {
                        Common.lsFuzzificationCanNang[key] = 0;
                    }
                    else
                    {
                        // TH: hình thang
                        if (lsPointCN[key].Count == 4)
                        {
                            if (lsPointCN[key][0] < position && position < lsPointCN[key][1])
                            {
                                Common.lsFuzzificationCanNang[key] = Math.Round(1.0 * (position - lsPointCN[key][0]) / (lsPointCN[key][1] - lsPointCN[key][0]), 2);
                            }
                            else if (lsPointCN[key][2] < position && position < lsPointCN[key][3])
                            {
                                Common.lsFuzzificationCanNang[key] = Math.Round(1.0 * (lsPointCN[key][3] - position) / (lsPointCN[key][3] - lsPointCN[key][2]), 2);
                            }
                            else
                            {
                                Common.lsFuzzificationCanNang[key] = 1;
                            }
                        }
                        // TH: hình tam giác
                        // ...

                    }
                }
                index++;
            }

            // vẽ đồ thị
            DrawCanNang(position);
        }

        /// <summary>
        /// Thực hiện mờ hóa vận động thô
        /// </summary>
        /// <param name="position"></param>
        private void FuzzificationVDTH(int position)
        {
            var index = 0;
            // lặp từng tạp mờ để tính toán
            foreach (var key in lsPointVDTH.Keys.ToList())
            {
                if (index == 0)
                {
                    // TH tập mờ đầu tiên
                    if (position <= lsPointVDTH[key][1])
                    {
                        Common.lsFuzzificationVDTH[key] = 1;
                    }
                    else if (lsPointVDTH[key][1] < position && position < lsPointVDTH[key][2])
                    {
                        Common.lsFuzzificationVDTH[key] = Math.Round(1.0 * (lsPointVDTH[key][2] - position) / (lsPointVDTH[key][2] - lsPointVDTH[key][1]), 2);
                    }
                    else
                    {
                        Common.lsFuzzificationVDTH[key] = 0;
                    }

                }
                else if (index == lsPointVDTH.Count - 1)
                {
                    // TH tập mờ cuối cùng
                    if (position <= lsPointVDTH[key][0])
                    {
                        Common.lsFuzzificationVDTH[key] = 0;
                    }
                    else if (lsPointVDTH[key][0] < position && position < lsPointVDTH[key][1])
                    {
                        Common.lsFuzzificationVDTH[key] = Math.Round(1.0 * (position - lsPointVDTH[key][0]) / (lsPointVDTH[key][1] - lsPointVDTH[key][0]), 2);
                    }
                    else
                    {
                        Common.lsFuzzificationVDTH[key] = 1;
                    }
                }
                else
                {
                    if (position <= lsPointVDTH[key][0] || position >= lsPointVDTH[key][lsPointVDTH[key].Count - 1])
                    {
                        Common.lsFuzzificationVDTH[key] = 0;
                    }
                    else
                    {
                        // TH: hình thang
                        if (lsPointVDTH[key].Count == 4)
                        {
                            if (lsPointVDTH[key][0] < position && position < lsPointVDTH[key][1])
                            {
                                Common.lsFuzzificationVDTH[key] = Math.Round(1.0 * (position - lsPointVDTH[key][0]) / (lsPointVDTH[key][1] - lsPointVDTH[key][0]), 2);
                            }
                            else if (lsPointVDTH[key][2] < position && position < lsPointVDTH[key][3])
                            {
                                Common.lsFuzzificationVDTH[key] = Math.Round(1.0 * (lsPointVDTH[key][3] - position) / (lsPointVDTH[key][3] - lsPointVDTH[key][2]), 2);
                            }
                            else
                            {
                                Common.lsFuzzificationVDTH[key] = 1;
                            }
                        }
                        // TH: hình tam giác
                        // ...

                    }
                }
                index++;
            }

            // vẽ đồ thị
            DrawVDTH(position);
        }

        /// <summary>
        /// Thực hiện mờ hóa vận động tinh
        /// </summary>
        /// <param name="position"></param>
        private void FuzzificationVDT(int position)
        {
            var index = 0;
            // lặp từng tạp mờ để tính toán
            foreach (var key in lsPointVDT.Keys.ToList())
            {
                if (index == 0)
                {
                    // TH tập mờ đầu tiên
                    if (position <= lsPointVDT[key][1])
                    {
                        Common.lsFuzzificationVDT[key] = 1;
                    }
                    else if (lsPointVDT[key][1] < position && position < lsPointVDT[key][2])
                    {
                        Common.lsFuzzificationVDT[key] = Math.Round(1.0 * (lsPointVDT[key][2] - position) / (lsPointVDT[key][2] - lsPointVDT[key][1]), 2);
                    }
                    else
                    {
                        Common.lsFuzzificationVDT[key] = 0;
                    }

                }
                else if (index == lsPointVDT.Count - 1)
                {
                    // TH tập mờ cuối cùng
                    if (position <= lsPointVDT[key][0])
                    {
                        Common.lsFuzzificationVDT[key] = 0;
                    }
                    else if (lsPointVDT[key][0] < position && position < lsPointVDT[key][1])
                    {
                        Common.lsFuzzificationVDT[key] = Math.Round(1.0 * (position - lsPointVDT[key][0]) / (lsPointVDT[key][1] - lsPointVDT[key][0]), 2);
                    }
                    else
                    {
                        Common.lsFuzzificationVDT[key] = 1;
                    }
                }
                else
                {
                    if (position <= lsPointVDT[key][0] || position >= lsPointVDT[key][lsPointVDT[key].Count - 1])
                    {
                        Common.lsFuzzificationVDT[key] = 0;
                    }
                    else
                    {
                        // TH: hình thang
                        if (lsPointVDT[key].Count == 4)
                        {
                            if (lsPointVDT[key][0] < position && position < lsPointVDT[key][1])
                            {
                                Common.lsFuzzificationVDT[key] = Math.Round(1.0 * (position - lsPointVDT[key][0]) / (lsPointVDT[key][1] - lsPointVDT[key][0]), 2);
                            }
                            else if (lsPointVDT[key][2] < position && position < lsPointVDT[key][3])
                            {
                                Common.lsFuzzificationVDT[key] = Math.Round(1.0 * (lsPointVDT[key][3] - position) / (lsPointVDT[key][3] - lsPointVDT[key][2]), 2);
                            }
                            else
                            {
                                Common.lsFuzzificationVDT[key] = 1;
                            }
                        }
                        // TH: hình tam giác
                        // ...

                    }
                }
                index++;
            }

            // vẽ đồ thị
            DrawVDT(position);
        }

        #endregion

    }
}
