using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KidHealthFuzzyLogic
{
    public partial class FuzzyLogicForm : Form
    {
        public FuzzyLogicForm()
        {
            InitializeComponent();
        }

        #region DrawGraph

        private static void DrawChieuCao(double position)
        {

        }

        #endregion

        #region Mờ hóa
        private static void FuzzificationChieuCao(double position)
        {
            var index = 0;
            var lsPoint = Common.lsChieuCaoPoint;
            // lặp từng tạp mờ để tính toán
            foreach (var key in lsPoint.Keys.ToList())
            {
                if (index == 0)
                {
                // TH tập mờ đầu tiên
                    if (position <= lsPoint[key][1])
                    {
                        Common.lsFuzzificationChieuCao[key] = 1;
                    } else if(lsPoint[key][1] > position && position < lsPoint[key][2])
                    {
                        Common.lsFuzzificationChieuCao[key] = Math.Round( 1.0 * (position - lsPoint[key][1]) / (lsPoint[key][2] - lsPoint[key][1]), 2);
                    } else
                    {
                        Common.lsFuzzificationChieuCao[key] = 0;
                    }

                } else if(index == Common.lsChieuCaoPoint.Count - 1)
                {
                // TH tập mờ cuối cùng
                    if (position <= lsPoint[key][1])
                    {
                        Common.lsFuzzificationChieuCao[key] = 0;
                    }
                    else if (lsPoint[key][1] > position && position < lsPoint[key][2])
                    {
                        Common.lsFuzzificationChieuCao[key] = Math.Round(1.0 * (position - lsPoint[key][1]) / (lsPoint[key][2] - lsPoint[key][1]), 2);
                    }
                    else
                    {
                        Common.lsFuzzificationChieuCao[key] = 1;
                    }
                } else
                {
                    if (position <= lsPoint[key][0] || position >= lsPoint[key][lsPoint[key].Count - 1])
                    {
                        Common.lsFuzzificationChieuCao[key] = 0;
                    }
                    // TH: hình thang
                    if (lsPoint[key][0] > position &&  position < lsPoint[key][1])
                    {
                        Common.lsFuzzificationChieuCao[key] = Math.Round(1.0 * (position - lsPoint[key][0]) / (lsPoint[key][1] - lsPoint[key][0]), 2);
                    }
                    else if (lsPoint[key][2] > position && position < lsPoint[key][3])
                    {
                        Common.lsFuzzificationChieuCao[key] = Math.Round(1.0 * (position - lsPoint[key][2]) / (lsPoint[key][3] - lsPoint[key][2]), 2);
                    }
                    else
                    {
                        Common.lsFuzzificationChieuCao[key] = 1;
                    }
                    // TH: hình tam giác
                    // ...
                }
            }

            // vẽ đồ thị
            DrawChieuCao(position);
        }

        #endregion

    }
}
