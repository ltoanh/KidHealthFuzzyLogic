
namespace KidHealthFuzzyLogic
{
    partial class RuleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tblRules = new System.Windows.Forms.DataGridView();
            this.Rule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rule_Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CC_RT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CC_T = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CC_BT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CC_CH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CN_RG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CN_G = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CN_BT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CN_TC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VDTH_RK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VDTH_K = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VDTH_BT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VDT_RK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VDT_K = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VDT_BT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblRules)).BeginInit();
            this.SuspendLayout();
            // 
            // tblRules
            // 
            this.tblRules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblRules.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rule,
            this.Rule_Value,
            this.CC_RT,
            this.CC_T,
            this.CC_BT,
            this.CC_CH,
            this.CN_RG,
            this.CN_G,
            this.CN_BT,
            this.CN_TC,
            this.VDTH_RK,
            this.VDTH_K,
            this.VDTH_BT,
            this.VDT_RK,
            this.VDT_K,
            this.VDT_BT});
            this.tblRules.Location = new System.Drawing.Point(11, 12);
            this.tblRules.Name = "tblRules";
            this.tblRules.Size = new System.Drawing.Size(1238, 775);
            this.tblRules.TabIndex = 0;
            // 
            // Rule
            // 
            this.Rule.HeaderText = "Luật";
            this.Rule.Name = "Rule";
            this.Rule.ReadOnly = true;
            // 
            // Rule_Value
            // 
            this.Rule_Value.HeaderText = "Giá trị";
            this.Rule_Value.Name = "Rule_Value";
            this.Rule_Value.ReadOnly = true;
            // 
            // CC_RT
            // 
            this.CC_RT.HeaderText = "CC Rất thấp";
            this.CC_RT.Name = "CC_RT";
            this.CC_RT.ReadOnly = true;
            // 
            // CC_T
            // 
            this.CC_T.HeaderText = "CC Thấp";
            this.CC_T.Name = "CC_T";
            this.CC_T.ReadOnly = true;
            // 
            // CC_BT
            // 
            this.CC_BT.HeaderText = "CC Bình thường";
            this.CC_BT.Name = "CC_BT";
            this.CC_BT.ReadOnly = true;
            // 
            // CC_CH
            // 
            this.CC_CH.HeaderText = "CC Cao hơn tuổi";
            this.CC_CH.Name = "CC_CH";
            this.CC_CH.ReadOnly = true;
            // 
            // CN_RG
            // 
            this.CN_RG.HeaderText = "CN Rất gầy";
            this.CN_RG.Name = "CN_RG";
            this.CN_RG.ReadOnly = true;
            // 
            // CN_G
            // 
            this.CN_G.HeaderText = "CN Gầy";
            this.CN_G.Name = "CN_G";
            this.CN_G.ReadOnly = true;
            // 
            // CN_BT
            // 
            this.CN_BT.HeaderText = "CN Bình thường";
            this.CN_BT.Name = "CN_BT";
            this.CN_BT.ReadOnly = true;
            // 
            // CN_TC
            // 
            this.CN_TC.HeaderText = "CN Thừa cân";
            this.CN_TC.Name = "CN_TC";
            this.CN_TC.ReadOnly = true;
            // 
            // VDTH_RK
            // 
            this.VDTH_RK.HeaderText = "VDThô Rất kém";
            this.VDTH_RK.Name = "VDTH_RK";
            this.VDTH_RK.ReadOnly = true;
            // 
            // VDTH_K
            // 
            this.VDTH_K.HeaderText = "VDThô Kém";
            this.VDTH_K.Name = "VDTH_K";
            this.VDTH_K.ReadOnly = true;
            // 
            // VDTH_BT
            // 
            this.VDTH_BT.HeaderText = "VDThô Bình thường";
            this.VDTH_BT.Name = "VDTH_BT";
            this.VDTH_BT.ReadOnly = true;
            // 
            // VDT_RK
            // 
            this.VDT_RK.HeaderText = "VDT Rất kém";
            this.VDT_RK.Name = "VDT_RK";
            this.VDT_RK.ReadOnly = true;
            // 
            // VDT_K
            // 
            this.VDT_K.HeaderText = "VDT Kém";
            this.VDT_K.Name = "VDT_K";
            this.VDT_K.ReadOnly = true;
            // 
            // VDT_BT
            // 
            this.VDT_BT.HeaderText = "VDT Bình thường";
            this.VDT_BT.Name = "VDT_BT";
            this.VDT_BT.ReadOnly = true;
            // 
            // RuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 799);
            this.Controls.Add(this.tblRules);
            this.Name = "RuleForm";
            this.Text = "RuleForm";
            this.Load += new System.EventHandler(this.RuleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblRules)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tblRules;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rule;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rule_Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn CC_RT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CC_T;
        private System.Windows.Forms.DataGridViewTextBoxColumn CC_BT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CC_CH;
        private System.Windows.Forms.DataGridViewTextBoxColumn CN_RG;
        private System.Windows.Forms.DataGridViewTextBoxColumn CN_G;
        private System.Windows.Forms.DataGridViewTextBoxColumn CN_BT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CN_TC;
        private System.Windows.Forms.DataGridViewTextBoxColumn VDTH_RK;
        private System.Windows.Forms.DataGridViewTextBoxColumn VDTH_K;
        private System.Windows.Forms.DataGridViewTextBoxColumn VDTH_BT;
        private System.Windows.Forms.DataGridViewTextBoxColumn VDT_RK;
        private System.Windows.Forms.DataGridViewTextBoxColumn VDT_K;
        private System.Windows.Forms.DataGridViewTextBoxColumn VDT_BT;
    }
}