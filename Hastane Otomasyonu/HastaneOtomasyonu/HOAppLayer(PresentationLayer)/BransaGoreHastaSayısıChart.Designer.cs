namespace HOAppLayer_PresentationLayer_
{
    partial class BransaGoreHastaSayısıChart
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgv_randevu = new System.Windows.Forms.DataGridView();
            this.dgv_doktor = new System.Windows.Forms.DataGridView();
            this.chrt_randevudoktor = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.zedgraphdeneme = new ZedGraph.ZedGraphControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_kapat = new System.Windows.Forms.Button();
            this.btn_geri = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_randevu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doktor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_randevudoktor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_randevu
            // 
            this.dgv_randevu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_randevu.Location = new System.Drawing.Point(781, 19);
            this.dgv_randevu.Name = "dgv_randevu";
            this.dgv_randevu.RowHeadersWidth = 51;
            this.dgv_randevu.RowTemplate.Height = 24;
            this.dgv_randevu.Size = new System.Drawing.Size(353, 290);
            this.dgv_randevu.TabIndex = 1;
            this.dgv_randevu.Visible = false;
            // 
            // dgv_doktor
            // 
            this.dgv_doktor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_doktor.Location = new System.Drawing.Point(3, 19);
            this.dgv_doktor.Name = "dgv_doktor";
            this.dgv_doktor.RowHeadersWidth = 51;
            this.dgv_doktor.RowTemplate.Height = 24;
            this.dgv_doktor.Size = new System.Drawing.Size(372, 290);
            this.dgv_doktor.TabIndex = 2;
            this.dgv_doktor.Visible = false;
            // 
            // chrt_randevudoktor
            // 
            chartArea1.Name = "ChartArea1";
            this.chrt_randevudoktor.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrt_randevudoktor.Legends.Add(legend1);
            this.chrt_randevudoktor.Location = new System.Drawing.Point(64, 422);
            this.chrt_randevudoktor.Name = "chrt_randevudoktor";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chrt_randevudoktor.Series.Add(series1);
            this.chrt_randevudoktor.Size = new System.Drawing.Size(902, 254);
            this.chrt_randevudoktor.TabIndex = 3;
            this.chrt_randevudoktor.Text = "chart2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(411, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(364, 290);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.Visible = false;
            // 
            // zedgraphdeneme
            // 
            this.zedgraphdeneme.Location = new System.Drawing.Point(64, 91);
            this.zedgraphdeneme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedgraphdeneme.Name = "zedgraphdeneme";
            this.zedgraphdeneme.ScrollGrace = 0D;
            this.zedgraphdeneme.ScrollMaxX = 0D;
            this.zedgraphdeneme.ScrollMaxY = 0D;
            this.zedgraphdeneme.ScrollMaxY2 = 0D;
            this.zedgraphdeneme.ScrollMinX = 0D;
            this.zedgraphdeneme.ScrollMinY = 0D;
            this.zedgraphdeneme.ScrollMinY2 = 0D;
            this.zedgraphdeneme.Size = new System.Drawing.Size(894, 279);
            this.zedgraphdeneme.TabIndex = 5;
            this.zedgraphdeneme.UseExtendedPrintDialog = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_doktor);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.dgv_randevu);
            this.panel1.Location = new System.Drawing.Point(10, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(47, 64);
            this.panel1.TabIndex = 6;
            this.panel1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.btn_kapat);
            this.panel2.Controls.Add(this.btn_geri);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1017, 57);
            this.panel2.TabIndex = 7;
            // 
            // btn_kapat
            // 
            this.btn_kapat.FlatAppearance.BorderSize = 0;
            this.btn_kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kapat.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kapat.Location = new System.Drawing.Point(964, 3);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(50, 30);
            this.btn_kapat.TabIndex = 33;
            this.btn_kapat.Text = "x";
            this.btn_kapat.UseVisualStyleBackColor = true;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // btn_geri
            // 
            this.btn_geri.FlatAppearance.BorderSize = 0;
            this.btn_geri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_geri.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geri.Location = new System.Drawing.Point(923, 3);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(35, 30);
            this.btn_geri.TabIndex = 32;
            this.btn_geri.Text = "<";
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 694);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1017, 57);
            this.panel3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(64, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Bölümlerdeki Randevu Sayısı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(64, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Randevulardaki Hasta Sayısı";
            // 
            // BransaGoreHastaSayısıChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 751);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.zedgraphdeneme);
            this.Controls.Add(this.chrt_randevudoktor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BransaGoreHastaSayısıChart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BransaGoreHastaSayısıChart";
            this.Load += new System.EventHandler(this.BransaGoreHastaSayısıChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_randevu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doktor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_randevudoktor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_randevu;
        private System.Windows.Forms.DataGridView dgv_doktor;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrt_randevudoktor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ZedGraph.ZedGraphControl zedgraphdeneme;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}