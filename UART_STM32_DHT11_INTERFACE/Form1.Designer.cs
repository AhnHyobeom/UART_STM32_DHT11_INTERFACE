
namespace UART_STM32_DHT11_INTERFACE
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tap = new System.Windows.Forms.TabControl();
            this.tp_Setup = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1_Send = new System.Windows.Forms.Button();
            this.textBox1_SendData = new System.Windows.Forms.TextBox();
            this.button1_Clear = new System.Windows.Forms.Button();
            this.groupBox1_ReceiveData = new System.Windows.Forms.GroupBox();
            this.textBox1_ReceiveData = new System.Windows.Forms.TextBox();
            this.label4_DBStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1_Port = new System.Windows.Forms.Label();
            this.gb_Comport = new System.Windows.Forms.GroupBox();
            this.label1_Comport = new System.Windows.Forms.Label();
            this.button2_ClosePort = new System.Windows.Forms.Button();
            this.button1_OpenPort = new System.Windows.Forms.Button();
            this.progressBar1_PortStatus = new System.Windows.Forms.ProgressBar();
            this.comboBox2_Bps = new System.Windows.Forms.ComboBox();
            this.comboBox1_Port = new System.Windows.Forms.ComboBox();
            this.tp_Monitoring = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2_Wet = new System.Windows.Forms.TextBox();
            this.textBox1_Tmp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tp_History = new System.Windows.Forms.TabPage();
            this.tp_Control = new System.Windows.Forms.TabPage();
            this.tp_Exit = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1_warning = new System.Windows.Forms.PictureBox();
            this.textBox1_MAXTMP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2_MINTMP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox3_MINWET = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox4_MAXWET = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.listView1_DB = new System.Windows.Forms.ListView();
            this.label11 = new System.Windows.Forms.Label();
            this.tap.SuspendLayout();
            this.tp_Setup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox1_ReceiveData.SuspendLayout();
            this.gb_Comport.SuspendLayout();
            this.tp_Monitoring.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tp_History.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_warning)).BeginInit();
            this.SuspendLayout();
            // 
            // tap
            // 
            this.tap.Controls.Add(this.tp_Setup);
            this.tap.Controls.Add(this.tp_Monitoring);
            this.tap.Controls.Add(this.tp_History);
            this.tap.Controls.Add(this.tp_Control);
            this.tap.Controls.Add(this.tp_Exit);
            this.tap.Location = new System.Drawing.Point(47, 128);
            this.tap.Name = "tap";
            this.tap.SelectedIndex = 0;
            this.tap.Size = new System.Drawing.Size(987, 653);
            this.tap.TabIndex = 0;
            // 
            // tp_Setup
            // 
            this.tp_Setup.Controls.Add(this.groupBox1);
            this.tp_Setup.Controls.Add(this.button1_Clear);
            this.tp_Setup.Controls.Add(this.groupBox1_ReceiveData);
            this.tp_Setup.Controls.Add(this.label4_DBStatus);
            this.tp_Setup.Controls.Add(this.label3);
            this.tp_Setup.Controls.Add(this.label1);
            this.tp_Setup.Controls.Add(this.label2);
            this.tp_Setup.Controls.Add(this.label1_Port);
            this.tp_Setup.Controls.Add(this.gb_Comport);
            this.tp_Setup.Controls.Add(this.button2_ClosePort);
            this.tp_Setup.Controls.Add(this.button1_OpenPort);
            this.tp_Setup.Controls.Add(this.progressBar1_PortStatus);
            this.tp_Setup.Controls.Add(this.comboBox2_Bps);
            this.tp_Setup.Controls.Add(this.comboBox1_Port);
            this.tp_Setup.Location = new System.Drawing.Point(4, 25);
            this.tp_Setup.Name = "tp_Setup";
            this.tp_Setup.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Setup.Size = new System.Drawing.Size(979, 624);
            this.tp_Setup.TabIndex = 0;
            this.tp_Setup.Text = "Setup";
            this.tp_Setup.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1_Send);
            this.groupBox1.Controls.Add(this.textBox1_SendData);
            this.groupBox1.Location = new System.Drawing.Point(331, 415);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Send Data";
            // 
            // button1_Send
            // 
            this.button1_Send.Location = new System.Drawing.Point(534, 26);
            this.button1_Send.Name = "button1_Send";
            this.button1_Send.Size = new System.Drawing.Size(75, 56);
            this.button1_Send.TabIndex = 13;
            this.button1_Send.Text = "Send";
            this.button1_Send.UseVisualStyleBackColor = true;
            // 
            // textBox1_SendData
            // 
            this.textBox1_SendData.Location = new System.Drawing.Point(6, 44);
            this.textBox1_SendData.Name = "textBox1_SendData";
            this.textBox1_SendData.Size = new System.Drawing.Size(507, 25);
            this.textBox1_SendData.TabIndex = 0;
            // 
            // button1_Clear
            // 
            this.button1_Clear.Location = new System.Drawing.Point(880, 92);
            this.button1_Clear.Name = "button1_Clear";
            this.button1_Clear.Size = new System.Drawing.Size(75, 52);
            this.button1_Clear.TabIndex = 12;
            this.button1_Clear.Text = "Clear";
            this.button1_Clear.UseVisualStyleBackColor = true;
            // 
            // groupBox1_ReceiveData
            // 
            this.groupBox1_ReceiveData.Controls.Add(this.textBox1_ReceiveData);
            this.groupBox1_ReceiveData.Location = new System.Drawing.Point(331, 59);
            this.groupBox1_ReceiveData.Name = "groupBox1_ReceiveData";
            this.groupBox1_ReceiveData.Size = new System.Drawing.Size(528, 327);
            this.groupBox1_ReceiveData.TabIndex = 11;
            this.groupBox1_ReceiveData.TabStop = false;
            this.groupBox1_ReceiveData.Text = "Receive Data";
            // 
            // textBox1_ReceiveData
            // 
            this.textBox1_ReceiveData.Location = new System.Drawing.Point(10, 34);
            this.textBox1_ReceiveData.Multiline = true;
            this.textBox1_ReceiveData.Name = "textBox1_ReceiveData";
            this.textBox1_ReceiveData.Size = new System.Drawing.Size(503, 253);
            this.textBox1_ReceiveData.TabIndex = 0;
            this.textBox1_ReceiveData.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4_DBStatus
            // 
            this.label4_DBStatus.AutoSize = true;
            this.label4_DBStatus.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4_DBStatus.Location = new System.Drawing.Point(157, 448);
            this.label4_DBStatus.Name = "label4_DBStatus";
            this.label4_DBStatus.Size = new System.Drawing.Size(108, 33);
            this.label4_DBStatus.TabIndex = 8;
            this.label4_DBStatus.Text = "Close";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "DB Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Port Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "BPS";
            // 
            // label1_Port
            // 
            this.label1_Port.AutoSize = true;
            this.label1_Port.Location = new System.Drawing.Point(70, 62);
            this.label1_Port.Name = "label1_Port";
            this.label1_Port.Size = new System.Drawing.Size(34, 15);
            this.label1_Port.TabIndex = 7;
            this.label1_Port.Text = "Port";
            // 
            // gb_Comport
            // 
            this.gb_Comport.Controls.Add(this.label1_Comport);
            this.gb_Comport.Location = new System.Drawing.Point(152, 259);
            this.gb_Comport.Name = "gb_Comport";
            this.gb_Comport.Size = new System.Drawing.Size(121, 166);
            this.gb_Comport.TabIndex = 6;
            this.gb_Comport.TabStop = false;
            this.gb_Comport.Text = "Comport";
            // 
            // label1_Comport
            // 
            this.label1_Comport.AutoSize = true;
            this.label1_Comport.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1_Comport.Location = new System.Drawing.Point(20, 70);
            this.label1_Comport.Name = "label1_Comport";
            this.label1_Comport.Size = new System.Drawing.Size(83, 33);
            this.label1_Comport.TabIndex = 7;
            this.label1_Comport.Text = "OFF";
            // 
            // button2_ClosePort
            // 
            this.button2_ClosePort.Location = new System.Drawing.Point(57, 358);
            this.button2_ClosePort.Name = "button2_ClosePort";
            this.button2_ClosePort.Size = new System.Drawing.Size(75, 67);
            this.button2_ClosePort.TabIndex = 5;
            this.button2_ClosePort.Text = "Close Port";
            this.button2_ClosePort.UseVisualStyleBackColor = true;
            this.button2_ClosePort.Click += new System.EventHandler(this.button2_ClosePort_Click);
            // 
            // button1_OpenPort
            // 
            this.button1_OpenPort.Location = new System.Drawing.Point(57, 259);
            this.button1_OpenPort.Name = "button1_OpenPort";
            this.button1_OpenPort.Size = new System.Drawing.Size(75, 67);
            this.button1_OpenPort.TabIndex = 4;
            this.button1_OpenPort.Text = "Open Port";
            this.button1_OpenPort.UseVisualStyleBackColor = true;
            this.button1_OpenPort.Click += new System.EventHandler(this.button1_OpenPort_Click);
            // 
            // progressBar1_PortStatus
            // 
            this.progressBar1_PortStatus.Location = new System.Drawing.Point(152, 183);
            this.progressBar1_PortStatus.Name = "progressBar1_PortStatus";
            this.progressBar1_PortStatus.Size = new System.Drawing.Size(121, 23);
            this.progressBar1_PortStatus.TabIndex = 3;
            // 
            // comboBox2_Bps
            // 
            this.comboBox2_Bps.FormattingEnabled = true;
            this.comboBox2_Bps.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.comboBox2_Bps.Location = new System.Drawing.Point(152, 121);
            this.comboBox2_Bps.Name = "comboBox2_Bps";
            this.comboBox2_Bps.Size = new System.Drawing.Size(121, 23);
            this.comboBox2_Bps.TabIndex = 2;
            // 
            // comboBox1_Port
            // 
            this.comboBox1_Port.FormattingEnabled = true;
            this.comboBox1_Port.Location = new System.Drawing.Point(152, 59);
            this.comboBox1_Port.Name = "comboBox1_Port";
            this.comboBox1_Port.Size = new System.Drawing.Size(121, 23);
            this.comboBox1_Port.TabIndex = 1;
            // 
            // tp_Monitoring
            // 
            this.tp_Monitoring.Controls.Add(this.textBox3_MINWET);
            this.tp_Monitoring.Controls.Add(this.label9);
            this.tp_Monitoring.Controls.Add(this.textBox4_MAXWET);
            this.tp_Monitoring.Controls.Add(this.label10);
            this.tp_Monitoring.Controls.Add(this.textBox2_MINTMP);
            this.tp_Monitoring.Controls.Add(this.label8);
            this.tp_Monitoring.Controls.Add(this.textBox1_MAXTMP);
            this.tp_Monitoring.Controls.Add(this.pictureBox1_warning);
            this.tp_Monitoring.Controls.Add(this.label7);
            this.tp_Monitoring.Controls.Add(this.chart1);
            this.tp_Monitoring.Controls.Add(this.groupBox2);
            this.tp_Monitoring.Location = new System.Drawing.Point(4, 25);
            this.tp_Monitoring.Name = "tp_Monitoring";
            this.tp_Monitoring.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Monitoring.Size = new System.Drawing.Size(979, 624);
            this.tp_Monitoring.TabIndex = 1;
            this.tp_Monitoring.Text = "Monitoring";
            this.tp_Monitoring.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(416, 58);
            this.chart1.Name = "chart1";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Legend = "Legend1";
            series9.Name = "온도";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Legend = "Legend1";
            series10.Name = "습도";
            this.chart1.Series.Add(series9);
            this.chart1.Series.Add(series10);
            this.chart1.Size = new System.Drawing.Size(531, 505);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2_Wet);
            this.groupBox2.Controls.Add(this.textBox1_Tmp);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(42, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 138);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "실시간 온습도";
            // 
            // textBox2_Wet
            // 
            this.textBox2_Wet.Location = new System.Drawing.Point(141, 77);
            this.textBox2_Wet.Name = "textBox2_Wet";
            this.textBox2_Wet.Size = new System.Drawing.Size(78, 25);
            this.textBox2_Wet.TabIndex = 3;
            // 
            // textBox1_Tmp
            // 
            this.textBox1_Tmp.Location = new System.Drawing.Point(36, 77);
            this.textBox1_Tmp.Name = "textBox1_Tmp";
            this.textBox1_Tmp.Size = new System.Drawing.Size(78, 25);
            this.textBox1_Tmp.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(153, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "습도";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(53, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "온도";
            // 
            // tp_History
            // 
            this.tp_History.Controls.Add(this.label11);
            this.tp_History.Controls.Add(this.listView1_DB);
            this.tp_History.Location = new System.Drawing.Point(4, 25);
            this.tp_History.Name = "tp_History";
            this.tp_History.Padding = new System.Windows.Forms.Padding(3);
            this.tp_History.Size = new System.Drawing.Size(979, 624);
            this.tp_History.TabIndex = 2;
            this.tp_History.Text = "History";
            this.tp_History.UseVisualStyleBackColor = true;
            // 
            // tp_Control
            // 
            this.tp_Control.Location = new System.Drawing.Point(4, 25);
            this.tp_Control.Name = "tp_Control";
            this.tp_Control.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Control.Size = new System.Drawing.Size(979, 624);
            this.tp_Control.TabIndex = 3;
            this.tp_Control.Text = "Control";
            this.tp_Control.UseVisualStyleBackColor = true;
            // 
            // tp_Exit
            // 
            this.tp_Exit.Location = new System.Drawing.Point(4, 25);
            this.tp_Exit.Name = "tp_Exit";
            this.tp_Exit.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Exit.Size = new System.Drawing.Size(976, 624);
            this.tp_Exit.TabIndex = 4;
            this.tp_Exit.Text = "Exit";
            this.tp_Exit.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(299, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(487, 60);
            this.label4.TabIndex = 11;
            this.label4.Text = "환경 관리 시스템";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1_warning
            // 
            this.pictureBox1_warning.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1_warning.Image")));
            this.pictureBox1_warning.Location = new System.Drawing.Point(6, 213);
            this.pictureBox1_warning.Name = "pictureBox1_warning";
            this.pictureBox1_warning.Size = new System.Drawing.Size(416, 97);
            this.pictureBox1_warning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1_warning.TabIndex = 3;
            this.pictureBox1_warning.TabStop = false;
            // 
            // textBox1_MAXTMP
            // 
            this.textBox1_MAXTMP.Location = new System.Drawing.Point(87, 392);
            this.textBox1_MAXTMP.Name = "textBox1_MAXTMP";
            this.textBox1_MAXTMP.Size = new System.Drawing.Size(78, 25);
            this.textBox1_MAXTMP.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(74, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "온도 상한치";
            // 
            // textBox2_MINTMP
            // 
            this.textBox2_MINTMP.Location = new System.Drawing.Point(87, 466);
            this.textBox2_MINTMP.Name = "textBox2_MINTMP";
            this.textBox2_MINTMP.Size = new System.Drawing.Size(78, 25);
            this.textBox2_MINTMP.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(74, 436);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "온도 하한치";
            // 
            // textBox3_MINWET
            // 
            this.textBox3_MINWET.Location = new System.Drawing.Point(267, 466);
            this.textBox3_MINWET.Name = "textBox3_MINWET";
            this.textBox3_MINWET.Size = new System.Drawing.Size(78, 25);
            this.textBox3_MINWET.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(254, 436);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 19);
            this.label9.TabIndex = 11;
            this.label9.Text = "습도 하한치";
            // 
            // textBox4_MAXWET
            // 
            this.textBox4_MAXWET.Location = new System.Drawing.Point(267, 392);
            this.textBox4_MAXWET.Name = "textBox4_MAXWET";
            this.textBox4_MAXWET.Size = new System.Drawing.Size(78, 25);
            this.textBox4_MAXWET.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(254, 362);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 19);
            this.label10.TabIndex = 9;
            this.label10.Text = "습도 상한치";
            // 
            // listView1_DB
            // 
            this.listView1_DB.HideSelection = false;
            this.listView1_DB.Location = new System.Drawing.Point(120, 136);
            this.listView1_DB.Name = "listView1_DB";
            this.listView1_DB.Size = new System.Drawing.Size(746, 426);
            this.listView1_DB.TabIndex = 3;
            this.listView1_DB.UseCompatibleStateImageBehavior = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(115, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(753, 40);
            this.label11.TabIndex = 12;
            this.label11.Text = "온습도 DB 기록 (History + Real Time) ";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 850);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tap);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tap.ResumeLayout(false);
            this.tp_Setup.ResumeLayout(false);
            this.tp_Setup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox1_ReceiveData.ResumeLayout(false);
            this.groupBox1_ReceiveData.PerformLayout();
            this.gb_Comport.ResumeLayout(false);
            this.gb_Comport.PerformLayout();
            this.tp_Monitoring.ResumeLayout(false);
            this.tp_Monitoring.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tp_History.ResumeLayout(false);
            this.tp_History.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_warning)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tap;
        private System.Windows.Forms.TabPage tp_Setup;
        private System.Windows.Forms.TabPage tp_Monitoring;
        private System.Windows.Forms.TabPage tp_History;
        private System.Windows.Forms.TabPage tp_Control;
        private System.Windows.Forms.TabPage tp_Exit;
        private System.Windows.Forms.Label label4_DBStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1_Port;
        private System.Windows.Forms.GroupBox gb_Comport;
        private System.Windows.Forms.Label label1_Comport;
        private System.Windows.Forms.Button button2_ClosePort;
        private System.Windows.Forms.Button button1_OpenPort;
        private System.Windows.Forms.ProgressBar progressBar1_PortStatus;
        private System.Windows.Forms.ComboBox comboBox2_Bps;
        private System.Windows.Forms.ComboBox comboBox1_Port;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1_ReceiveData;
        private System.Windows.Forms.TextBox textBox1_ReceiveData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1_Send;
        private System.Windows.Forms.TextBox textBox1_SendData;
        private System.Windows.Forms.Button button1_Clear;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox2_Wet;
        private System.Windows.Forms.TextBox textBox1_Tmp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.PictureBox pictureBox1_warning;
        private System.Windows.Forms.TextBox textBox3_MINWET;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox4_MAXWET;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox2_MINTMP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1_MAXTMP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView listView1_DB;
        private System.Windows.Forms.Label label11;
    }
}

