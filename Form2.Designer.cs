
namespace FriendlyScan
{
    partial class Form2
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            this.metroCPU = new MetroFramework.Controls.MetroTile();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.metroProgressBarRAM = new MetroFramework.Controls.MetroProgressBar();
            this.metroLabelRAM = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabelCPU = new MetroFramework.Controls.MetroLabel();
            this.metroProgressBarCPU = new MetroFramework.Controls.MetroProgressBar();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroProgressSpinner2 = new MetroFramework.Controls.MetroProgressSpinner();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CPU = new System.Diagnostics.PerformanceCounter();
            this.RAM = new System.Diagnostics.PerformanceCounter();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroConexao = new MetroFramework.Controls.MetroLabel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.metroSpeed = new MetroFramework.Controls.MetroLabel();
            this.metroCPU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.metroTile2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAM)).BeginInit();
            this.SuspendLayout();
            // 
            // metroProgressSpinner1
            // 
            this.metroProgressSpinner1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroProgressSpinner1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroProgressSpinner1.Location = new System.Drawing.Point(468, 91);
            this.metroProgressSpinner1.Maximum = 100;
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.Size = new System.Drawing.Size(106, 96);
            this.metroProgressSpinner1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroProgressSpinner1.TabIndex = 1;
            this.metroProgressSpinner1.UseSelectable = true;
            this.metroProgressSpinner1.UseStyleColors = true;
            this.metroProgressSpinner1.Value = 100;
            // 
            // metroCPU
            // 
            this.metroCPU.ActiveControl = null;
            this.metroCPU.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroCPU.Controls.Add(this.chart1);
            this.metroCPU.Controls.Add(this.metroProgressBarRAM);
            this.metroCPU.Controls.Add(this.metroLabelRAM);
            this.metroCPU.Controls.Add(this.metroLabel2);
            this.metroCPU.Controls.Add(this.metroLabelCPU);
            this.metroCPU.Controls.Add(this.metroProgressBarCPU);
            this.metroCPU.Controls.Add(this.metroLabel1);
            this.metroCPU.Location = new System.Drawing.Point(25, 91);
            this.metroCPU.Name = "metroCPU";
            this.metroCPU.Size = new System.Drawing.Size(347, 247);
            this.metroCPU.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroCPU.TabIndex = 2;
            this.metroCPU.Text = "CPU e RAM";
            this.metroCPU.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.metroCPU.UseSelectable = true;
            this.metroCPU.UseStyleColors = true;
            this.metroCPU.Click += new System.EventHandler(this.metroCPU_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(22, 138);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "CPU";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "RAM";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(243, 96);
            this.chart1.TabIndex = 6;
            // 
            // metroProgressBarRAM
            // 
            this.metroProgressBarRAM.Location = new System.Drawing.Point(80, 108);
            this.metroProgressBarRAM.Name = "metroProgressBarRAM";
            this.metroProgressBarRAM.Size = new System.Drawing.Size(200, 23);
            this.metroProgressBarRAM.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroProgressBarRAM.TabIndex = 5;
            // 
            // metroLabelRAM
            // 
            this.metroLabelRAM.AutoSize = true;
            this.metroLabelRAM.Location = new System.Drawing.Point(302, 110);
            this.metroLabelRAM.Name = "metroLabelRAM";
            this.metroLabelRAM.Size = new System.Drawing.Size(27, 19);
            this.metroLabelRAM.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabelRAM.TabIndex = 4;
            this.metroLabelRAM.Text = "0%";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 110);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(41, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "RAM:";
            // 
            // metroLabelCPU
            // 
            this.metroLabelCPU.AutoSize = true;
            this.metroLabelCPU.BackColor = System.Drawing.Color.Black;
            this.metroLabelCPU.Location = new System.Drawing.Point(302, 64);
            this.metroLabelCPU.Name = "metroLabelCPU";
            this.metroLabelCPU.Size = new System.Drawing.Size(27, 19);
            this.metroLabelCPU.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabelCPU.TabIndex = 2;
            this.metroLabelCPU.Text = "0%";
            // 
            // metroProgressBarCPU
            // 
            this.metroProgressBarCPU.Location = new System.Drawing.Point(80, 59);
            this.metroProgressBarCPU.Name = "metroProgressBarCPU";
            this.metroProgressBarCPU.Size = new System.Drawing.Size(200, 24);
            this.metroProgressBarCPU.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroProgressBarCPU.TabIndex = 1;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Black;
            this.metroLabel1.ForeColor = System.Drawing.Color.Black;
            this.metroLabel1.Location = new System.Drawing.Point(23, 64);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(38, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "CPU:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroTile2.Controls.Add(this.metroSpeed);
            this.metroTile2.Controls.Add(this.metroConexao);
            this.metroTile2.Location = new System.Drawing.Point(25, 229);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(347, 109);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile2.TabIndex = 3;
            this.metroTile2.Text = "Banda Larga Internet";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroProgressSpinner2
            // 
            this.metroProgressSpinner2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroProgressSpinner2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroProgressSpinner2.Backwards = true;
            this.metroProgressSpinner2.Location = new System.Drawing.Point(589, 91);
            this.metroProgressSpinner2.Maximum = 100;
            this.metroProgressSpinner2.Name = "metroProgressSpinner2";
            this.metroProgressSpinner2.Size = new System.Drawing.Size(106, 96);
            this.metroProgressSpinner2.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroProgressSpinner2.TabIndex = 4;
            this.metroProgressSpinner2.UseSelectable = true;
            this.metroProgressSpinner2.UseStyleColors = true;
            this.metroProgressSpinner2.Value = 100;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // CPU
            // 
            this.CPU.CategoryName = global::FriendlyScan.Properties.Settings.Default.Processor;
            this.CPU.CounterName = "% Processor Time";
            this.CPU.InstanceName = "_Total";
            // 
            // RAM
            // 
            this.RAM.CategoryName = global::FriendlyScan.Properties.Settings.Default.Memory;
            this.RAM.CounterName = "% Committed Bytes in Use";
            // 
            // metroTextBox2
            // 
            this.metroTextBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.Lines = new string[] {
        "Voltar"};
            this.metroTextBox2.Location = new System.Drawing.Point(273, 268);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.Size = new System.Drawing.Size(75, 23);
            this.metroTextBox2.TabIndex = 6;
            this.metroTextBox2.Text = "Voltar";
            this.metroTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox2.Click += new System.EventHandler(this.metroTextBox2_Click);
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[] {
        "Voltar"};
            this.metroTextBox1.Location = new System.Drawing.Point(273, 302);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(75, 23);
            this.metroTextBox1.TabIndex = 5;
            this.metroTextBox1.Text = "Voltar";
            this.metroTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox1.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // metroConexao
            // 
            this.metroConexao.AutoSize = true;
            this.metroConexao.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroConexao.Location = new System.Drawing.Point(53, 92);
            this.metroConexao.Name = "metroConexao";
            this.metroConexao.Size = new System.Drawing.Size(62, 19);
            this.metroConexao.Style = MetroFramework.MetroColorStyle.Black;
            this.metroConexao.TabIndex = 0;
            this.metroConexao.Text = "Conexão";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // metroSpeed
            // 
            this.metroSpeed.AutoSize = true;
            this.metroSpeed.Location = new System.Drawing.Point(53, 171);
            this.metroSpeed.Name = "metroSpeed";
            this.metroSpeed.Size = new System.Drawing.Size(94, 19);
            this.metroSpeed.Style = MetroFramework.MetroColorStyle.Black;
            this.metroSpeed.TabIndex = 1;
            this.metroSpeed.Text = "Speed Internet";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 361);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroTextBox2);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroCPU);
            this.Controls.Add(this.metroProgressSpinner1);
            this.Controls.Add(this.metroProgressSpinner2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "FriendlyScan";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.metroCPU.ResumeLayout(false);
            this.metroCPU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.metroTile2.ResumeLayout(false);
            this.metroTile2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
        private MetroFramework.Controls.MetroTile metroCPU;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner2;
        private MetroFramework.Controls.MetroLabel metroLabelCPU;
        private MetroFramework.Controls.MetroProgressBar metroProgressBarCPU;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Diagnostics.PerformanceCounter RAM;
        private System.Diagnostics.PerformanceCounter CPU;
        private MetroFramework.Controls.MetroLabel metroLabelRAM;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroProgressBar metroProgressBarRAM;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroConexao;
        private System.Windows.Forms.Timer timer2;
        private MetroFramework.Controls.MetroLabel metroSpeed;
    }
}