
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea16 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend16 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series31 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series32 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.metroCPU = new MetroFramework.Controls.MetroTile();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.metroProgressBarRAM = new MetroFramework.Controls.MetroProgressBar();
            this.metroLabelRAM = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabelCPU = new MetroFramework.Controls.MetroLabel();
            this.metroProgressBarCPU = new MetroFramework.Controls.MetroProgressBar();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroSpeed = new MetroFramework.Controls.MetroLabel();
            this.metroConexao = new MetroFramework.Controls.MetroLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CPU = new System.Diagnostics.PerformanceCounter();
            this.RAM = new System.Diagnostics.PerformanceCounter();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new CircularProgressBar.CircularProgressBar();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.LabelPowerShell = new System.Windows.Forms.TextBox();
            this.metroCPU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.metroTile2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAM)).BeginInit();
            this.SuspendLayout();
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
            chartArea16.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea16);
            legend16.Name = "Legend1";
            this.chart1.Legends.Add(legend16);
            this.chart1.Location = new System.Drawing.Point(22, 138);
            this.chart1.Name = "chart1";
            series31.ChartArea = "ChartArea1";
            series31.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series31.Legend = "Legend1";
            series31.Name = "CPU";
            series32.ChartArea = "ChartArea1";
            series32.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series32.Legend = "Legend1";
            series32.Name = "RAM";
            this.chart1.Series.Add(series31);
            this.chart1.Series.Add(series32);
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
            // metroSpeed
            // 
            this.metroSpeed.AutoSize = true;
            this.metroSpeed.BackColor = System.Drawing.Color.White;
            this.metroSpeed.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroSpeed.Location = new System.Drawing.Point(44, 169);
            this.metroSpeed.Name = "metroSpeed";
            this.metroSpeed.Size = new System.Drawing.Size(94, 19);
            this.metroSpeed.Style = MetroFramework.MetroColorStyle.Brown;
            this.metroSpeed.TabIndex = 1;
            this.metroSpeed.Text = "Speed Internet";
            // 
            // metroConexao
            // 
            this.metroConexao.AutoSize = true;
            this.metroConexao.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroConexao.ForeColor = System.Drawing.Color.Transparent;
            this.metroConexao.Location = new System.Drawing.Point(85, 94);
            this.metroConexao.Name = "metroConexao";
            this.metroConexao.Size = new System.Drawing.Size(62, 19);
            this.metroConexao.Style = MetroFramework.MetroColorStyle.Brown;
            this.metroConexao.TabIndex = 0;
            this.metroConexao.Text = "Conexão";
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
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("progressBar1.AnimationFunction")));
            this.progressBar1.AnimationSpeed = 500;
            this.progressBar1.BackColor = System.Drawing.Color.White;
            this.progressBar1.Font = new System.Drawing.Font("Myanmar Text", 14.28F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.progressBar1.InnerColor = System.Drawing.Color.White;
            this.progressBar1.InnerMargin = 2;
            this.progressBar1.InnerWidth = -1;
            this.progressBar1.Location = new System.Drawing.Point(534, 262);
            this.progressBar1.MarqueeAnimationSpeed = 2000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.OuterColor = System.Drawing.Color.Black;
            this.progressBar1.OuterMargin = -25;
            this.progressBar1.OuterWidth = 26;
            this.progressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.progressBar1.ProgressWidth = 10;
            this.progressBar1.SecondaryFont = new System.Drawing.Font("Myanmar Text", 28.28F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBar1.Size = new System.Drawing.Size(71, 67);
            this.progressBar1.StartAngle = 270;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.progressBar1.SubscriptText = "";
            this.progressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.progressBar1.SuperscriptText = "";
            this.progressBar1.TabIndex = 7;
            this.progressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.progressBar1.Value = 68;
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // metroTextBox3
            // 
            this.metroTextBox3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            this.metroTextBox3.CustomButton.Image = null;
            this.metroTextBox3.CustomButton.Location = new System.Drawing.Point(88, 1);
            this.metroTextBox3.CustomButton.Name = "";
            this.metroTextBox3.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox3.CustomButton.TabIndex = 1;
            this.metroTextBox3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox3.CustomButton.UseSelectable = true;
            this.metroTextBox3.CustomButton.Visible = false;
            this.metroTextBox3.Lines = new string[] {
        "Visualizar Relatório"};
            this.metroTextBox3.Location = new System.Drawing.Point(521, 335);
            this.metroTextBox3.MaxLength = 32767;
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.PasswordChar = '\0';
            this.metroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox3.SelectedText = "";
            this.metroTextBox3.SelectionLength = 0;
            this.metroTextBox3.SelectionStart = 0;
            this.metroTextBox3.ShortcutsEnabled = true;
            this.metroTextBox3.Size = new System.Drawing.Size(110, 23);
            this.metroTextBox3.TabIndex = 8;
            this.metroTextBox3.Text = "Visualizar Relatório";
            this.metroTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTextBox3.UseSelectable = true;
            this.metroTextBox3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox3.Click += new System.EventHandler(this.metroTextBox3_Click);
            // 
            // LabelPowerShell
            // 
            this.LabelPowerShell.BackColor = System.Drawing.SystemColors.MenuText;
            this.LabelPowerShell.ForeColor = System.Drawing.SystemColors.Window;
            this.LabelPowerShell.Location = new System.Drawing.Point(389, 56);
            this.LabelPowerShell.Multiline = true;
            this.LabelPowerShell.Name = "LabelPowerShell";
            this.LabelPowerShell.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.LabelPowerShell.Size = new System.Drawing.Size(365, 200);
            this.LabelPowerShell.TabIndex = 9;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 361);
            this.Controls.Add(this.LabelPowerShell);
            this.Controls.Add(this.metroTextBox2);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroTextBox3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.metroCPU);
            this.Controls.Add(this.metroTile2);
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
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MetroFramework.Controls.MetroTile metroCPU;
        private MetroFramework.Controls.MetroTile metroTile2;
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
        private CircularProgressBar.CircularProgressBar progressBar1;
        private System.Windows.Forms.Timer timer3;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private System.Windows.Forms.TextBox LabelPowerShell;
    }
}