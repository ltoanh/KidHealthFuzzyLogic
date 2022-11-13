
namespace KidHealthFuzzyLogic
{
    partial class FuzzyLogicForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chartChieuCao = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCanNang = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartVDTH = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartVDT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartChieuCao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCanNang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVDTH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVDT)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chartVDT);
            this.groupBox1.Controls.Add(this.chartVDTH);
            this.groupBox1.Controls.Add(this.chartCanNang);
            this.groupBox1.Controls.Add(this.chartChieuCao);
            this.groupBox1.Location = new System.Drawing.Point(12, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1081, 693);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mờ hóa";
            // 
            // chartChieuCao
            // 
            chartArea4.Name = "ChartArea1";
            this.chartChieuCao.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartChieuCao.Legends.Add(legend4);
            this.chartChieuCao.Location = new System.Drawing.Point(18, 19);
            this.chartChieuCao.Name = "chartChieuCao";
            this.chartChieuCao.Size = new System.Drawing.Size(512, 202);
            this.chartChieuCao.TabIndex = 0;
            // 
            // chartCanNang
            // 
            chartArea3.Name = "ChartArea1";
            this.chartCanNang.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartCanNang.Legends.Add(legend3);
            this.chartCanNang.Location = new System.Drawing.Point(548, 19);
            this.chartCanNang.Name = "chartCanNang";
            this.chartCanNang.Size = new System.Drawing.Size(512, 202);
            this.chartCanNang.TabIndex = 1;
            // 
            // chartVDTH
            // 
            chartArea2.Name = "ChartArea1";
            this.chartVDTH.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartVDTH.Legends.Add(legend2);
            this.chartVDTH.Location = new System.Drawing.Point(18, 238);
            this.chartVDTH.Name = "chartVDTH";
            this.chartVDTH.Size = new System.Drawing.Size(512, 202);
            this.chartVDTH.TabIndex = 2;
            // 
            // chartVDT
            // 
            chartArea1.Name = "ChartArea1";
            this.chartVDT.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartVDT.Legends.Add(legend1);
            this.chartVDT.Location = new System.Drawing.Point(548, 238);
            this.chartVDT.Name = "chartVDT";
            this.chartVDT.Size = new System.Drawing.Size(512, 202);
            this.chartVDT.TabIndex = 3;
            // 
            // FuzzyLogicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 794);
            this.Controls.Add(this.groupBox1);
            this.Name = "FuzzyLogicForm";
            this.Text = "FuzzyLogic";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartChieuCao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCanNang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVDTH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVDT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVDT;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVDTH;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCanNang;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartChieuCao;
    }
}