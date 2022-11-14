using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KidHealthFuzzyLogic
{
    public partial class RuleForm : Form
    {
        string[] ruleText;
        public RuleForm()
        {
            InitializeComponent();
            ruleText = File.ReadAllLines("E:\\Code\\Project\\PTIT\\KidHealthFuzzyLogic\\KidHealthFuzzyLogic\\RuleBase.txt");
        }

        private void RuleForm_Load(object sender, EventArgs e)
        {
            CalculatorRuleValue();
        }

        private void ClearOldData()
        {
            foreach (var key in Common.lsPhatTrienRule.Keys.ToList())
            {
                Common.lsPhatTrienRule[key] = new List<double>();
            }
        }

        /// <summary>
        /// Tính toán hiển thị kết quả dựa trên tập luật
        /// </summary>
        public void CalculatorRuleValue()
        {
            ClearOldData();
            tblRules.Rows.Clear();
            foreach (var item in ruleText)
            {
                string[] lsConditionItems = item.Split(';');
                var conditionResult = 1.0;

                var index = tblRules.Rows.Add();
                // hiển thị kết quả luật
                tblRules.Rows[index].Cells["Rule"].Value = Common.lsPhatTrienName[lsConditionItems.Last()];
                // hiển thị giá trị tập mờ
                for (int i = 0; i < lsConditionItems.Count() - 1; i++)
                {
                    if (lsConditionItems[i].Contains("CC_"))
                    {
                        tblRules.Rows[index].Cells[lsConditionItems[i]].Value = Common.lsFuzzificationChieuCao[lsConditionItems[i]];
                        conditionResult = Math.Min(conditionResult, Common.lsFuzzificationChieuCao[lsConditionItems[i]]);
                    } else if (lsConditionItems[i].Contains("CN_"))
                    {
                        tblRules.Rows[index].Cells[lsConditionItems[i]].Value = Common.lsFuzzificationCanNang[lsConditionItems[i]];
                        conditionResult = Math.Min(conditionResult, Common.lsFuzzificationCanNang[lsConditionItems[i]]);
                    } else if (lsConditionItems[i].Contains("VDTH_"))
                    {
                        tblRules.Rows[index].Cells[lsConditionItems[i]].Value = Common.lsFuzzificationVDTH[lsConditionItems[i]];
                        conditionResult = Math.Min(conditionResult, Common.lsFuzzificationVDTH[lsConditionItems[i]]);
                    } else if (lsConditionItems[i].Contains("VDT_"))
                    {
                        tblRules.Rows[index].Cells[lsConditionItems[i]].Value = Common.lsFuzzificationVDT[lsConditionItems[i]];
                        conditionResult = Math.Min(conditionResult, Common.lsFuzzificationVDT[lsConditionItems[i]]);
                    }
                }

                tblRules.Rows[index].Cells["Rule_Value"].Value = conditionResult;
                // bôi đậm dòng
                if (conditionResult != 0)
                {
                    tblRules.Rows[index].DefaultCellStyle.BackColor = Color.LightGreen;
                    // insert giá trị vào tập kết quả phát triển tương ứng
                    Common.lsPhatTrienRule[lsConditionItems.Last()].Add(conditionResult);
                }

            }
        }
    }
}
