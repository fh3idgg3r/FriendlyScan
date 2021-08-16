
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CPU = new System.Diagnostics.PerformanceCounter();
            this.RAM = new System.Diagnostics.PerformanceCounter();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.cmdScan = new MetroFramework.Controls.MetroButton();
            this.metroTextIP = new MetroFramework.Controls.MetroTextBox();
            this.textHosts = new System.Windows.Forms.TextBox();
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
            this.metroCPU.Location = new System.Drawing.Point(24, 91);
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
            chartArea8.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chart1.Legends.Add(legend8);
            this.chart1.Location = new System.Drawing.Point(22, 138);
            this.chart1.Name = "chart1";
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series15.Legend = "Legend1";
            series15.Name = "CPU";
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series16.Legend = "Legend1";
            series16.Name = "RAM";
            this.chart1.Series.Add(series15);
            this.chart1.Series.Add(series16);
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
            this.metroTile2.Controls.Add(this.textHosts);
            this.metroTile2.Controls.Add(this.metroTextIP);
            this.metroTile2.Controls.Add(this.cmdScan);
            this.metroTile2.Location = new System.Drawing.Point(24, 209);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(347, 126);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile2.TabIndex = 3;
            this.metroTile2.Text = "Scan Internet";
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
            this.metroTextBox1.Location = new System.Drawing.Point(293, 302);
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
            this.metroTextBox2.Location = new System.Drawing.Point(293, 121);
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
            // cmdScan
            // 
            this.cmdScan.Location = new System.Drawing.Point(189, 33);
            this.cmdScan.Name = "cmdScan";
            this.cmdScan.Size = new System.Drawing.Size(75, 23);
            this.cmdScan.TabIndex = 0;
            this.cmdScan.Text = "Scan";
            this.cmdScan.UseSelectable = true;
            this.cmdScan.Click += new System.EventHandler(this.cmdScan_Click);
            // 
            // metroTextIP
            // 
            // 
            // 
            // 
            this.metroTextIP.CustomButton.Image = null;
            this.metroTextIP.CustomButton.Location = new System.Drawing.Point(136, 1);
            this.metroTextIP.CustomButton.Name = "";
            this.metroTextIP.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextIP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextIP.CustomButton.TabIndex = 1;
            this.metroTextIP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextIP.CustomButton.UseSelectable = true;
            this.metroTextIP.CustomButton.Visible = false;
            this.metroTextIP.Lines = new string[0];
            this.metroTextIP.Location = new System.Drawing.Point(26, 32);
            this.metroTextIP.MaxLength = 32767;
            this.metroTextIP.Name = "metroTextIP";
            this.metroTextIP.PasswordChar = '\0';
            this.metroTextIP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextIP.SelectedText = "";
            this.metroTextIP.SelectionLength = 0;
            this.metroTextIP.SelectionStart = 0;
            this.metroTextIP.ShortcutsEnabled = true;
            this.metroTextIP.Size = new System.Drawing.Size(158, 23);
            this.metroTextIP.TabIndex = 2;
            this.metroTextIP.UseSelectable = true;
            this.metroTextIP.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextIP.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textHosts
            // 
            this.textHosts.Location = new System.Drawing.Point(26, 64);
            this.textHosts.Multiline = true;
            this.textHosts.Name = "textHosts";
            this.textHosts.Size = new System.Drawing.Size(297, 174);
            this.textHosts.TabIndex = 3;
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
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
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
        private System.Windows.Forms.TextBox textHosts;
        private MetroFramework.Controls.MetroTextBox metroTextIP;
        private MetroFramework.Controls.MetroButton cmdScan;
    }
}