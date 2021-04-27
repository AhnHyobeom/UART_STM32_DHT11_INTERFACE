
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tab = new System.Windows.Forms.TabControl();
            this.tp_Setup = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1_Send = new System.Windows.Forms.Button();
            this.textBox1_SendData = new System.Windows.Forms.TextBox();
            this.button1_Clear = new System.Windows.Forms.Button();
            this.groupBox1_ReceiveData = new System.Windows.Forms.GroupBox();
            this.textBox1_ReceiveData = new System.Windows.Forms.TextBox();
            this.label4_DBStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1_PortStatus = new System.Windows.Forms.Label();
            this.label2_BPS = new System.Windows.Forms.Label();
            this.label1_Port = new System.Windows.Forms.Label();
            this.gb_Comport = new System.Windows.Forms.GroupBox();
            this.label1_Comport = new System.Windows.Forms.Label();
            this.button2_ClosePort = new System.Windows.Forms.Button();
            this.button1_OpenPort = new System.Windows.Forms.Button();
            this.progressBar1_PortStatus = new System.Windows.Forms.ProgressBar();
            this.comboBox2_Bps = new System.Windows.Forms.ComboBox();
            this.comboBox1_Port = new System.Windows.Forms.ComboBox();
            this.tp_Monitoring = new System.Windows.Forms.TabPage();
            this.textBox3_MINWET = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox4_MAXWET = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2_MINTMP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1_MAXTMP = new System.Windows.Forms.TextBox();
            this.pictureBox1_warning = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2_Wet = new System.Windows.Forms.TextBox();
            this.textBox1_Tmp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tp_History = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.listView1_DB = new System.Windows.Forms.ListView();
            this.tp_Search = new System.Windows.Forms.TabPage();
            this.button1_WETHIGHSearch = new System.Windows.Forms.Button();
            this.button2_WETLOWSearch = new System.Windows.Forms.Button();
            this.button1_TMPHIGHSearch = new System.Windows.Forms.Button();
            this.button1_TMPLOWSearch = new System.Windows.Forms.Button();
            this.label13_SearchName = new System.Windows.Forms.Label();
            this.button2_WETSearch = new System.Windows.Forms.Button();
            this.textBox3_WET_Search_HIGH = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox4_WET_Search_LOW = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.button1_TMPSearch = new System.Windows.Forms.Button();
            this.textBox2_TMP_Search_HIGH = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox1_TMP_Search_LOW = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.listView1_Search = new System.Windows.Forms.ListView();
            this.label12 = new System.Windows.Forms.Label();
            this.tp_Control = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.progressBar1_fan1 = new System.Windows.Forms.ProgressBar();
            this.checkBox1_swFan1 = new System.Windows.Forms.CheckBox();
            this.progressBar3_led3 = new System.Windows.Forms.ProgressBar();
            this.checkBox3_sw3 = new System.Windows.Forms.CheckBox();
            this.progressBar2_led2 = new System.Windows.Forms.ProgressBar();
            this.checkBox2_sw2 = new System.Windows.Forms.CheckBox();
            this.progressBar1_led1 = new System.Windows.Forms.ProgressBar();
            this.checkBox1_sw1 = new System.Windows.Forms.CheckBox();
            this.tp_Calculator = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tb_bin = new System.Windows.Forms.TextBox();
            this.tb_oct = new System.Windows.Forms.TextBox();
            this.tb_dec = new System.Windows.Forms.TextBox();
            this.tb_hex = new System.Windows.Forms.TextBox();
            this.btn_equals = new System.Windows.Forms.Button();
            this.btn_point = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_plus_subtract = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_subtract = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_mul = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_div = new System.Windows.Forms.Button();
            this.btn_moduler = new System.Windows.Forms.Button();
            this.btn_closeBracket = new System.Windows.Forms.Button();
            this.btn_openBracket = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_CE = new System.Windows.Forms.Button();
            this.btn_rightBitShift = new System.Windows.Forms.Button();
            this.btn_leftBitShift = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_mainDisplay = new System.Windows.Forms.TextBox();
            this.tb_calculTop = new System.Windows.Forms.TextBox();
            this.tp_Exit = new System.Windows.Forms.TabPage();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tab.SuspendLayout();
            this.tp_Setup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox1_ReceiveData.SuspendLayout();
            this.gb_Comport.SuspendLayout();
            this.tp_Monitoring.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_warning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tp_History.SuspendLayout();
            this.tp_Search.SuspendLayout();
            this.tp_Control.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tp_Calculator.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tp_Setup);
            this.tab.Controls.Add(this.tp_Monitoring);
            this.tab.Controls.Add(this.tp_History);
            this.tab.Controls.Add(this.tp_Search);
            this.tab.Controls.Add(this.tp_Control);
            this.tab.Controls.Add(this.tp_Calculator);
            this.tab.Controls.Add(this.tp_Exit);
            this.tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab.Location = new System.Drawing.Point(0, 0);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(1032, 698);
            this.tab.TabIndex = 0;
            this.tab.SelectedIndexChanged += new System.EventHandler(this.tap_SelectedIndexChanged);
            this.tab.Selected += new System.Windows.Forms.TabControlEventHandler(this.tap_Selected);
            // 
            // tp_Setup
            // 
            this.tp_Setup.Controls.Add(this.label4);
            this.tp_Setup.Controls.Add(this.groupBox1);
            this.tp_Setup.Controls.Add(this.button1_Clear);
            this.tp_Setup.Controls.Add(this.groupBox1_ReceiveData);
            this.tp_Setup.Controls.Add(this.label4_DBStatus);
            this.tp_Setup.Controls.Add(this.label3);
            this.tp_Setup.Controls.Add(this.label1_PortStatus);
            this.tp_Setup.Controls.Add(this.label2_BPS);
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
            this.tp_Setup.Size = new System.Drawing.Size(1024, 669);
            this.tp_Setup.TabIndex = 0;
            this.tp_Setup.Text = "Setup";
            this.tp_Setup.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(328, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(357, 43);
            this.label4.TabIndex = 11;
            this.label4.Text = "환경 관리 시스템";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.button1_Send);
            this.groupBox1.Controls.Add(this.textBox1_SendData);
            this.groupBox1.Location = new System.Drawing.Point(336, 476);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Send Data";
            // 
            // button1_Send
            // 
            this.button1_Send.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1_Send.Location = new System.Drawing.Point(534, 26);
            this.button1_Send.Name = "button1_Send";
            this.button1_Send.Size = new System.Drawing.Size(75, 56);
            this.button1_Send.TabIndex = 13;
            this.button1_Send.Text = "Send";
            this.button1_Send.UseVisualStyleBackColor = true;
            // 
            // textBox1_SendData
            // 
            this.textBox1_SendData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1_SendData.Location = new System.Drawing.Point(6, 44);
            this.textBox1_SendData.Name = "textBox1_SendData";
            this.textBox1_SendData.Size = new System.Drawing.Size(507, 25);
            this.textBox1_SendData.TabIndex = 0;
            // 
            // button1_Clear
            // 
            this.button1_Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1_Clear.Location = new System.Drawing.Point(885, 153);
            this.button1_Clear.Name = "button1_Clear";
            this.button1_Clear.Size = new System.Drawing.Size(75, 52);
            this.button1_Clear.TabIndex = 12;
            this.button1_Clear.Text = "Clear";
            this.button1_Clear.UseVisualStyleBackColor = true;
            this.button1_Clear.Click += new System.EventHandler(this.button1_Clear_Click);
            // 
            // groupBox1_ReceiveData
            // 
            this.groupBox1_ReceiveData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1_ReceiveData.Controls.Add(this.textBox1_ReceiveData);
            this.groupBox1_ReceiveData.Location = new System.Drawing.Point(336, 120);
            this.groupBox1_ReceiveData.Name = "groupBox1_ReceiveData";
            this.groupBox1_ReceiveData.Size = new System.Drawing.Size(528, 327);
            this.groupBox1_ReceiveData.TabIndex = 11;
            this.groupBox1_ReceiveData.TabStop = false;
            this.groupBox1_ReceiveData.Text = "Receive Data";
            // 
            // textBox1_ReceiveData
            // 
            this.textBox1_ReceiveData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1_ReceiveData.Location = new System.Drawing.Point(10, 34);
            this.textBox1_ReceiveData.Multiline = true;
            this.textBox1_ReceiveData.Name = "textBox1_ReceiveData";
            this.textBox1_ReceiveData.Size = new System.Drawing.Size(503, 253);
            this.textBox1_ReceiveData.TabIndex = 0;
            this.textBox1_ReceiveData.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4_DBStatus
            // 
            this.label4_DBStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4_DBStatus.AutoSize = true;
            this.label4_DBStatus.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4_DBStatus.ForeColor = System.Drawing.Color.Red;
            this.label4_DBStatus.Location = new System.Drawing.Point(162, 509);
            this.label4_DBStatus.Name = "label4_DBStatus";
            this.label4_DBStatus.Size = new System.Drawing.Size(108, 33);
            this.label4_DBStatus.TabIndex = 8;
            this.label4_DBStatus.Text = "Close";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 518);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "DB Status";
            // 
            // label1_PortStatus
            // 
            this.label1_PortStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1_PortStatus.AutoSize = true;
            this.label1_PortStatus.Location = new System.Drawing.Point(56, 248);
            this.label1_PortStatus.Name = "label1_PortStatus";
            this.label1_PortStatus.Size = new System.Drawing.Size(81, 15);
            this.label1_PortStatus.TabIndex = 9;
            this.label1_PortStatus.Text = "Port Status";
            // 
            // label2_BPS
            // 
            this.label2_BPS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2_BPS.AutoSize = true;
            this.label2_BPS.Location = new System.Drawing.Point(75, 185);
            this.label2_BPS.Name = "label2_BPS";
            this.label2_BPS.Size = new System.Drawing.Size(37, 15);
            this.label2_BPS.TabIndex = 8;
            this.label2_BPS.Text = "BPS";
            // 
            // label1_Port
            // 
            this.label1_Port.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1_Port.AutoSize = true;
            this.label1_Port.Location = new System.Drawing.Point(75, 123);
            this.label1_Port.Name = "label1_Port";
            this.label1_Port.Size = new System.Drawing.Size(34, 15);
            this.label1_Port.TabIndex = 7;
            this.label1_Port.Text = "Port";
            // 
            // gb_Comport
            // 
            this.gb_Comport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gb_Comport.Controls.Add(this.label1_Comport);
            this.gb_Comport.Location = new System.Drawing.Point(157, 320);
            this.gb_Comport.Name = "gb_Comport";
            this.gb_Comport.Size = new System.Drawing.Size(121, 166);
            this.gb_Comport.TabIndex = 6;
            this.gb_Comport.TabStop = false;
            this.gb_Comport.Text = "Comport";
            // 
            // label1_Comport
            // 
            this.label1_Comport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1_Comport.AutoSize = true;
            this.label1_Comport.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1_Comport.ForeColor = System.Drawing.Color.Red;
            this.label1_Comport.Location = new System.Drawing.Point(20, 70);
            this.label1_Comport.Name = "label1_Comport";
            this.label1_Comport.Size = new System.Drawing.Size(83, 33);
            this.label1_Comport.TabIndex = 7;
            this.label1_Comport.Text = "OFF";
            // 
            // button2_ClosePort
            // 
            this.button2_ClosePort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2_ClosePort.Location = new System.Drawing.Point(62, 419);
            this.button2_ClosePort.Name = "button2_ClosePort";
            this.button2_ClosePort.Size = new System.Drawing.Size(75, 67);
            this.button2_ClosePort.TabIndex = 5;
            this.button2_ClosePort.Text = "Close Port";
            this.button2_ClosePort.UseVisualStyleBackColor = true;
            this.button2_ClosePort.Click += new System.EventHandler(this.button2_ClosePort_Click);
            // 
            // button1_OpenPort
            // 
            this.button1_OpenPort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1_OpenPort.Location = new System.Drawing.Point(62, 320);
            this.button1_OpenPort.Name = "button1_OpenPort";
            this.button1_OpenPort.Size = new System.Drawing.Size(75, 67);
            this.button1_OpenPort.TabIndex = 4;
            this.button1_OpenPort.Text = "Open Port";
            this.button1_OpenPort.UseVisualStyleBackColor = true;
            this.button1_OpenPort.Click += new System.EventHandler(this.button1_OpenPort_Click);
            // 
            // progressBar1_PortStatus
            // 
            this.progressBar1_PortStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBar1_PortStatus.Location = new System.Drawing.Point(157, 244);
            this.progressBar1_PortStatus.Name = "progressBar1_PortStatus";
            this.progressBar1_PortStatus.Size = new System.Drawing.Size(121, 23);
            this.progressBar1_PortStatus.TabIndex = 3;
            // 
            // comboBox2_Bps
            // 
            this.comboBox2_Bps.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox2_Bps.FormattingEnabled = true;
            this.comboBox2_Bps.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.comboBox2_Bps.Location = new System.Drawing.Point(157, 182);
            this.comboBox2_Bps.Name = "comboBox2_Bps";
            this.comboBox2_Bps.Size = new System.Drawing.Size(121, 23);
            this.comboBox2_Bps.TabIndex = 2;
            // 
            // comboBox1_Port
            // 
            this.comboBox1_Port.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1_Port.FormattingEnabled = true;
            this.comboBox1_Port.Location = new System.Drawing.Point(157, 120);
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
            this.tp_Monitoring.Size = new System.Drawing.Size(1024, 669);
            this.tp_Monitoring.TabIndex = 1;
            this.tp_Monitoring.Text = "Monitoring";
            this.tp_Monitoring.UseVisualStyleBackColor = true;
            // 
            // textBox3_MINWET
            // 
            this.textBox3_MINWET.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3_MINWET.Location = new System.Drawing.Point(242, 491);
            this.textBox3_MINWET.Name = "textBox3_MINWET";
            this.textBox3_MINWET.Size = new System.Drawing.Size(78, 25);
            this.textBox3_MINWET.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(229, 461);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 19);
            this.label9.TabIndex = 11;
            this.label9.Text = "습도 하한치";
            // 
            // textBox4_MAXWET
            // 
            this.textBox4_MAXWET.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox4_MAXWET.Location = new System.Drawing.Point(242, 417);
            this.textBox4_MAXWET.Name = "textBox4_MAXWET";
            this.textBox4_MAXWET.Size = new System.Drawing.Size(78, 25);
            this.textBox4_MAXWET.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(229, 387);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 19);
            this.label10.TabIndex = 9;
            this.label10.Text = "습도 상한치";
            // 
            // textBox2_MINTMP
            // 
            this.textBox2_MINTMP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2_MINTMP.Location = new System.Drawing.Point(62, 491);
            this.textBox2_MINTMP.Name = "textBox2_MINTMP";
            this.textBox2_MINTMP.Size = new System.Drawing.Size(78, 25);
            this.textBox2_MINTMP.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(49, 461);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "온도 하한치";
            // 
            // textBox1_MAXTMP
            // 
            this.textBox1_MAXTMP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1_MAXTMP.Location = new System.Drawing.Point(62, 417);
            this.textBox1_MAXTMP.Name = "textBox1_MAXTMP";
            this.textBox1_MAXTMP.Size = new System.Drawing.Size(78, 25);
            this.textBox1_MAXTMP.TabIndex = 4;
            // 
            // pictureBox1_warning
            // 
            this.pictureBox1_warning.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1_warning.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1_warning.Image")));
            this.pictureBox1_warning.Location = new System.Drawing.Point(11, 238);
            this.pictureBox1_warning.Name = "pictureBox1_warning";
            this.pictureBox1_warning.Size = new System.Drawing.Size(404, 97);
            this.pictureBox1_warning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1_warning.TabIndex = 3;
            this.pictureBox1_warning.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(49, 387);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "온도 상한치";
            // 
            // chart1
            // 
            this.chart1.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea8.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chart1.Legends.Add(legend8);
            this.chart1.Location = new System.Drawing.Point(421, 83);
            this.chart1.Name = "chart1";
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series15.Legend = "Legend1";
            series15.Name = "온도";
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series16.Legend = "Legend1";
            series16.Name = "습도";
            this.chart1.Series.Add(series15);
            this.chart1.Series.Add(series16);
            this.chart1.Size = new System.Drawing.Size(531, 505);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.textBox2_Wet);
            this.groupBox2.Controls.Add(this.textBox1_Tmp);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(47, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 138);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "실시간 온습도";
            // 
            // textBox2_Wet
            // 
            this.textBox2_Wet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2_Wet.Location = new System.Drawing.Point(141, 77);
            this.textBox2_Wet.Name = "textBox2_Wet";
            this.textBox2_Wet.Size = new System.Drawing.Size(78, 25);
            this.textBox2_Wet.TabIndex = 3;
            // 
            // textBox1_Tmp
            // 
            this.textBox1_Tmp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1_Tmp.Location = new System.Drawing.Point(36, 77);
            this.textBox1_Tmp.Name = "textBox1_Tmp";
            this.textBox1_Tmp.Size = new System.Drawing.Size(78, 25);
            this.textBox1_Tmp.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.tp_History.Size = new System.Drawing.Size(1024, 669);
            this.tp_History.TabIndex = 2;
            this.tp_History.Text = "History";
            this.tp_History.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(120, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(753, 40);
            this.label11.TabIndex = 12;
            this.label11.Text = "온습도 DB 기록 (History + Real Time) ";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // listView1_DB
            // 
            this.listView1_DB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listView1_DB.HideSelection = false;
            this.listView1_DB.Location = new System.Drawing.Point(125, 161);
            this.listView1_DB.Name = "listView1_DB";
            this.listView1_DB.Size = new System.Drawing.Size(746, 426);
            this.listView1_DB.TabIndex = 3;
            this.listView1_DB.UseCompatibleStateImageBehavior = false;
            // 
            // tp_Search
            // 
            this.tp_Search.Controls.Add(this.button1_WETHIGHSearch);
            this.tp_Search.Controls.Add(this.button2_WETLOWSearch);
            this.tp_Search.Controls.Add(this.button1_TMPHIGHSearch);
            this.tp_Search.Controls.Add(this.button1_TMPLOWSearch);
            this.tp_Search.Controls.Add(this.label13_SearchName);
            this.tp_Search.Controls.Add(this.button2_WETSearch);
            this.tp_Search.Controls.Add(this.textBox3_WET_Search_HIGH);
            this.tp_Search.Controls.Add(this.label16);
            this.tp_Search.Controls.Add(this.textBox4_WET_Search_LOW);
            this.tp_Search.Controls.Add(this.label17);
            this.tp_Search.Controls.Add(this.button1_TMPSearch);
            this.tp_Search.Controls.Add(this.textBox2_TMP_Search_HIGH);
            this.tp_Search.Controls.Add(this.label15);
            this.tp_Search.Controls.Add(this.textBox1_TMP_Search_LOW);
            this.tp_Search.Controls.Add(this.label14);
            this.tp_Search.Controls.Add(this.listView1_Search);
            this.tp_Search.Controls.Add(this.label12);
            this.tp_Search.Location = new System.Drawing.Point(4, 25);
            this.tp_Search.Name = "tp_Search";
            this.tp_Search.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Search.Size = new System.Drawing.Size(1024, 669);
            this.tp_Search.TabIndex = 3;
            this.tp_Search.Text = "Search";
            this.tp_Search.UseVisualStyleBackColor = true;
            // 
            // button1_WETHIGHSearch
            // 
            this.button1_WETHIGHSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1_WETHIGHSearch.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1_WETHIGHSearch.Location = new System.Drawing.Point(21, 530);
            this.button1_WETHIGHSearch.Name = "button1_WETHIGHSearch";
            this.button1_WETHIGHSearch.Size = new System.Drawing.Size(275, 35);
            this.button1_WETHIGHSearch.TabIndex = 30;
            this.button1_WETHIGHSearch.Text = "상한치 습도 검색";
            this.button1_WETHIGHSearch.UseVisualStyleBackColor = true;
            this.button1_WETHIGHSearch.Click += new System.EventHandler(this.button1_WETHIGHSearch_Click);
            // 
            // button2_WETLOWSearch
            // 
            this.button2_WETLOWSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2_WETLOWSearch.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2_WETLOWSearch.Location = new System.Drawing.Point(21, 478);
            this.button2_WETLOWSearch.Name = "button2_WETLOWSearch";
            this.button2_WETLOWSearch.Size = new System.Drawing.Size(275, 35);
            this.button2_WETLOWSearch.TabIndex = 29;
            this.button2_WETLOWSearch.Text = "하한치 습도 검색";
            this.button2_WETLOWSearch.UseVisualStyleBackColor = true;
            this.button2_WETLOWSearch.Click += new System.EventHandler(this.button2_WETLOWSearch_Click);
            // 
            // button1_TMPHIGHSearch
            // 
            this.button1_TMPHIGHSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1_TMPHIGHSearch.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1_TMPHIGHSearch.Location = new System.Drawing.Point(21, 425);
            this.button1_TMPHIGHSearch.Name = "button1_TMPHIGHSearch";
            this.button1_TMPHIGHSearch.Size = new System.Drawing.Size(275, 35);
            this.button1_TMPHIGHSearch.TabIndex = 28;
            this.button1_TMPHIGHSearch.Text = "상한치 온도 검색";
            this.button1_TMPHIGHSearch.UseVisualStyleBackColor = true;
            this.button1_TMPHIGHSearch.Click += new System.EventHandler(this.button1_TMPHIGHSearch_Click);
            // 
            // button1_TMPLOWSearch
            // 
            this.button1_TMPLOWSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1_TMPLOWSearch.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1_TMPLOWSearch.Location = new System.Drawing.Point(21, 373);
            this.button1_TMPLOWSearch.Name = "button1_TMPLOWSearch";
            this.button1_TMPLOWSearch.Size = new System.Drawing.Size(275, 35);
            this.button1_TMPLOWSearch.TabIndex = 27;
            this.button1_TMPLOWSearch.Text = "하한치 온도 검색";
            this.button1_TMPLOWSearch.UseVisualStyleBackColor = true;
            this.button1_TMPLOWSearch.Click += new System.EventHandler(this.button1_TMPLOWSearch_Click);
            // 
            // label13_SearchName
            // 
            this.label13_SearchName.AutoSize = true;
            this.label13_SearchName.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13_SearchName.Location = new System.Drawing.Point(343, 104);
            this.label13_SearchName.Name = "label13_SearchName";
            this.label13_SearchName.Size = new System.Drawing.Size(0, 20);
            this.label13_SearchName.TabIndex = 26;
            // 
            // button2_WETSearch
            // 
            this.button2_WETSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2_WETSearch.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2_WETSearch.Location = new System.Drawing.Point(233, 320);
            this.button2_WETSearch.Name = "button2_WETSearch";
            this.button2_WETSearch.Size = new System.Drawing.Size(63, 35);
            this.button2_WETSearch.TabIndex = 25;
            this.button2_WETSearch.Text = "검색";
            this.button2_WETSearch.UseVisualStyleBackColor = true;
            this.button2_WETSearch.Click += new System.EventHandler(this.button2_WETSearch_Click);
            // 
            // textBox3_WET_Search_HIGH
            // 
            this.textBox3_WET_Search_HIGH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3_WET_Search_HIGH.Location = new System.Drawing.Point(138, 324);
            this.textBox3_WET_Search_HIGH.Name = "textBox3_WET_Search_HIGH";
            this.textBox3_WET_Search_HIGH.Size = new System.Drawing.Size(70, 25);
            this.textBox3_WET_Search_HIGH.TabIndex = 24;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.Location = new System.Drawing.Point(102, 328);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 20);
            this.label16.TabIndex = 23;
            this.label16.Text = "~";
            // 
            // textBox4_WET_Search_LOW
            // 
            this.textBox4_WET_Search_LOW.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox4_WET_Search_LOW.Location = new System.Drawing.Point(19, 324);
            this.textBox4_WET_Search_LOW.Name = "textBox4_WET_Search_LOW";
            this.textBox4_WET_Search_LOW.Size = new System.Drawing.Size(70, 25);
            this.textBox4_WET_Search_LOW.TabIndex = 22;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.Location = new System.Drawing.Point(17, 280);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(240, 20);
            this.label17.TabIndex = 21;
            this.label17.Text = "습도 검색 (이상 ~ 이하)";
            // 
            // button1_TMPSearch
            // 
            this.button1_TMPSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1_TMPSearch.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1_TMPSearch.Location = new System.Drawing.Point(233, 211);
            this.button1_TMPSearch.Name = "button1_TMPSearch";
            this.button1_TMPSearch.Size = new System.Drawing.Size(63, 35);
            this.button1_TMPSearch.TabIndex = 20;
            this.button1_TMPSearch.Text = "검색";
            this.button1_TMPSearch.UseVisualStyleBackColor = true;
            this.button1_TMPSearch.Click += new System.EventHandler(this.button1_TMPSearch_Click);
            // 
            // textBox2_TMP_Search_HIGH
            // 
            this.textBox2_TMP_Search_HIGH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2_TMP_Search_HIGH.Location = new System.Drawing.Point(138, 215);
            this.textBox2_TMP_Search_HIGH.Name = "textBox2_TMP_Search_HIGH";
            this.textBox2_TMP_Search_HIGH.Size = new System.Drawing.Size(70, 25);
            this.textBox2_TMP_Search_HIGH.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.Location = new System.Drawing.Point(102, 219);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 20);
            this.label15.TabIndex = 18;
            this.label15.Text = "~";
            // 
            // textBox1_TMP_Search_LOW
            // 
            this.textBox1_TMP_Search_LOW.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1_TMP_Search_LOW.Location = new System.Drawing.Point(19, 215);
            this.textBox1_TMP_Search_LOW.Name = "textBox1_TMP_Search_LOW";
            this.textBox1_TMP_Search_LOW.Size = new System.Drawing.Size(70, 25);
            this.textBox1_TMP_Search_LOW.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(17, 171);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(240, 20);
            this.label14.TabIndex = 16;
            this.label14.Text = "온도 검색 (이상 ~ 이하)";
            // 
            // listView1_Search
            // 
            this.listView1_Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listView1_Search.HideSelection = false;
            this.listView1_Search.Location = new System.Drawing.Point(313, 171);
            this.listView1_Search.Name = "listView1_Search";
            this.listView1_Search.Size = new System.Drawing.Size(635, 432);
            this.listView1_Search.TabIndex = 14;
            this.listView1_Search.UseCompatibleStateImageBehavior = false;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(256, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(458, 40);
            this.label12.TabIndex = 13;
            this.label12.Text = "온습도 DB 기록 Search";
            // 
            // tp_Control
            // 
            this.tp_Control.Controls.Add(this.label1);
            this.tp_Control.Controls.Add(this.groupBox3);
            this.tp_Control.Location = new System.Drawing.Point(4, 25);
            this.tp_Control.Name = "tp_Control";
            this.tp_Control.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Control.Size = new System.Drawing.Size(1024, 669);
            this.tp_Control.TabIndex = 4;
            this.tp_Control.Text = "Control";
            this.tp_Control.UseVisualStyleBackColor = true;
            this.tp_Control.Click += new System.EventHandler(this.tp_Exit_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(306, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 43);
            this.label1.TabIndex = 12;
            this.label1.Text = "환경 관리 시스템";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.progressBar1_fan1);
            this.groupBox3.Controls.Add(this.checkBox1_swFan1);
            this.groupBox3.Controls.Add(this.progressBar3_led3);
            this.groupBox3.Controls.Add(this.checkBox3_sw3);
            this.groupBox3.Controls.Add(this.progressBar2_led2);
            this.groupBox3.Controls.Add(this.checkBox2_sw2);
            this.groupBox3.Controls.Add(this.progressBar1_led1);
            this.groupBox3.Controls.Add(this.checkBox1_sw1);
            this.groupBox3.Location = new System.Drawing.Point(22, 115);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(388, 135);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "조명제어";
            // 
            // progressBar1_fan1
            // 
            this.progressBar1_fan1.Location = new System.Drawing.Point(302, 42);
            this.progressBar1_fan1.Name = "progressBar1_fan1";
            this.progressBar1_fan1.Size = new System.Drawing.Size(35, 23);
            this.progressBar1_fan1.TabIndex = 7;
            // 
            // checkBox1_swFan1
            // 
            this.checkBox1_swFan1.AutoSize = true;
            this.checkBox1_swFan1.Location = new System.Drawing.Point(302, 87);
            this.checkBox1_swFan1.Name = "checkBox1_swFan1";
            this.checkBox1_swFan1.Size = new System.Drawing.Size(63, 19);
            this.checkBox1_swFan1.TabIndex = 6;
            this.checkBox1_swFan1.Text = "FAN1";
            this.checkBox1_swFan1.UseVisualStyleBackColor = true;
            this.checkBox1_swFan1.CheckedChanged += new System.EventHandler(this.checkBox1_swFan1_CheckedChanged);
            // 
            // progressBar3_led3
            // 
            this.progressBar3_led3.Location = new System.Drawing.Point(214, 42);
            this.progressBar3_led3.Name = "progressBar3_led3";
            this.progressBar3_led3.Size = new System.Drawing.Size(35, 23);
            this.progressBar3_led3.TabIndex = 5;
            // 
            // checkBox3_sw3
            // 
            this.checkBox3_sw3.AutoSize = true;
            this.checkBox3_sw3.Location = new System.Drawing.Point(214, 87);
            this.checkBox3_sw3.Name = "checkBox3_sw3";
            this.checkBox3_sw3.Size = new System.Drawing.Size(64, 19);
            this.checkBox3_sw3.TabIndex = 4;
            this.checkBox3_sw3.Text = "LED3";
            this.checkBox3_sw3.UseVisualStyleBackColor = true;
            this.checkBox3_sw3.CheckedChanged += new System.EventHandler(this.checkBox3_sw3_CheckedChanged);
            // 
            // progressBar2_led2
            // 
            this.progressBar2_led2.Location = new System.Drawing.Point(126, 42);
            this.progressBar2_led2.Name = "progressBar2_led2";
            this.progressBar2_led2.Size = new System.Drawing.Size(35, 23);
            this.progressBar2_led2.TabIndex = 3;
            // 
            // checkBox2_sw2
            // 
            this.checkBox2_sw2.AutoSize = true;
            this.checkBox2_sw2.Location = new System.Drawing.Point(126, 87);
            this.checkBox2_sw2.Name = "checkBox2_sw2";
            this.checkBox2_sw2.Size = new System.Drawing.Size(64, 19);
            this.checkBox2_sw2.TabIndex = 2;
            this.checkBox2_sw2.Text = "LED2";
            this.checkBox2_sw2.UseVisualStyleBackColor = true;
            this.checkBox2_sw2.CheckedChanged += new System.EventHandler(this.checkBox2_sw2_CheckedChanged);
            // 
            // progressBar1_led1
            // 
            this.progressBar1_led1.Location = new System.Drawing.Point(41, 42);
            this.progressBar1_led1.Name = "progressBar1_led1";
            this.progressBar1_led1.Size = new System.Drawing.Size(35, 23);
            this.progressBar1_led1.TabIndex = 1;
            // 
            // checkBox1_sw1
            // 
            this.checkBox1_sw1.AutoSize = true;
            this.checkBox1_sw1.Location = new System.Drawing.Point(41, 87);
            this.checkBox1_sw1.Name = "checkBox1_sw1";
            this.checkBox1_sw1.Size = new System.Drawing.Size(64, 19);
            this.checkBox1_sw1.TabIndex = 0;
            this.checkBox1_sw1.Text = "LED1";
            this.checkBox1_sw1.UseVisualStyleBackColor = true;
            this.checkBox1_sw1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tp_Calculator
            // 
            this.tp_Calculator.Controls.Add(this.groupBox4);
            this.tp_Calculator.Location = new System.Drawing.Point(4, 25);
            this.tp_Calculator.Name = "tp_Calculator";
            this.tp_Calculator.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Calculator.Size = new System.Drawing.Size(1024, 669);
            this.tp_Calculator.TabIndex = 5;
            this.tp_Calculator.Text = "Calculator";
            this.tp_Calculator.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.DimGray;
            this.groupBox4.Controls.Add(this.tb_bin);
            this.groupBox4.Controls.Add(this.tb_oct);
            this.groupBox4.Controls.Add(this.tb_dec);
            this.groupBox4.Controls.Add(this.tb_hex);
            this.groupBox4.Controls.Add(this.btn_equals);
            this.groupBox4.Controls.Add(this.btn_point);
            this.groupBox4.Controls.Add(this.btn_0);
            this.groupBox4.Controls.Add(this.btn_plus_subtract);
            this.groupBox4.Controls.Add(this.btn_plus);
            this.groupBox4.Controls.Add(this.btn_3);
            this.groupBox4.Controls.Add(this.btn_2);
            this.groupBox4.Controls.Add(this.btn_1);
            this.groupBox4.Controls.Add(this.btn_subtract);
            this.groupBox4.Controls.Add(this.btn_6);
            this.groupBox4.Controls.Add(this.btn_5);
            this.groupBox4.Controls.Add(this.btn_4);
            this.groupBox4.Controls.Add(this.btn_mul);
            this.groupBox4.Controls.Add(this.btn_9);
            this.groupBox4.Controls.Add(this.btn_8);
            this.groupBox4.Controls.Add(this.btn_7);
            this.groupBox4.Controls.Add(this.btn_div);
            this.groupBox4.Controls.Add(this.btn_moduler);
            this.groupBox4.Controls.Add(this.btn_closeBracket);
            this.groupBox4.Controls.Add(this.btn_openBracket);
            this.groupBox4.Controls.Add(this.btn_del);
            this.groupBox4.Controls.Add(this.btn_CE);
            this.groupBox4.Controls.Add(this.btn_rightBitShift);
            this.groupBox4.Controls.Add(this.btn_leftBitShift);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.tb_mainDisplay);
            this.groupBox4.Controls.Add(this.tb_calculTop);
            this.groupBox4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox4.Location = new System.Drawing.Point(245, 18);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(521, 636);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Calculator";
            // 
            // tb_bin
            // 
            this.tb_bin.BackColor = System.Drawing.Color.DimGray;
            this.tb_bin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_bin.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_bin.ForeColor = System.Drawing.Color.Black;
            this.tb_bin.Location = new System.Drawing.Point(1, 204);
            this.tb_bin.Name = "tb_bin";
            this.tb_bin.Size = new System.Drawing.Size(514, 27);
            this.tb_bin.TabIndex = 40;
            // 
            // tb_oct
            // 
            this.tb_oct.BackColor = System.Drawing.Color.DimGray;
            this.tb_oct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_oct.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_oct.ForeColor = System.Drawing.Color.Black;
            this.tb_oct.Location = new System.Drawing.Point(3, 176);
            this.tb_oct.Name = "tb_oct";
            this.tb_oct.Size = new System.Drawing.Size(514, 27);
            this.tb_oct.TabIndex = 39;
            // 
            // tb_dec
            // 
            this.tb_dec.BackColor = System.Drawing.Color.DimGray;
            this.tb_dec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_dec.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_dec.ForeColor = System.Drawing.Color.Black;
            this.tb_dec.Location = new System.Drawing.Point(3, 148);
            this.tb_dec.Name = "tb_dec";
            this.tb_dec.Size = new System.Drawing.Size(514, 27);
            this.tb_dec.TabIndex = 38;
            // 
            // tb_hex
            // 
            this.tb_hex.BackColor = System.Drawing.Color.DimGray;
            this.tb_hex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_hex.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_hex.ForeColor = System.Drawing.Color.Black;
            this.tb_hex.Location = new System.Drawing.Point(3, 120);
            this.tb_hex.Name = "tb_hex";
            this.tb_hex.Size = new System.Drawing.Size(514, 27);
            this.tb_hex.TabIndex = 37;
            // 
            // btn_equals
            // 
            this.btn_equals.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_equals.ForeColor = System.Drawing.Color.Black;
            this.btn_equals.Location = new System.Drawing.Point(414, 570);
            this.btn_equals.Name = "btn_equals";
            this.btn_equals.Size = new System.Drawing.Size(100, 60);
            this.btn_equals.TabIndex = 36;
            this.btn_equals.Text = "=";
            this.btn_equals.UseVisualStyleBackColor = false;
            this.btn_equals.Click += new System.EventHandler(this.btn_equals_Click);
            // 
            // btn_point
            // 
            this.btn_point.BackColor = System.Drawing.Color.GhostWhite;
            this.btn_point.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_point.Location = new System.Drawing.Point(312, 570);
            this.btn_point.Name = "btn_point";
            this.btn_point.Size = new System.Drawing.Size(100, 60);
            this.btn_point.TabIndex = 35;
            this.btn_point.Text = ".";
            this.btn_point.UseVisualStyleBackColor = false;
            this.btn_point.Click += new System.EventHandler(this.btn_point_Click);
            // 
            // btn_0
            // 
            this.btn_0.BackColor = System.Drawing.Color.GhostWhite;
            this.btn_0.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_0.ForeColor = System.Drawing.Color.Black;
            this.btn_0.Location = new System.Drawing.Point(210, 570);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(100, 60);
            this.btn_0.TabIndex = 34;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = false;
            this.btn_0.Click += new System.EventHandler(this.btn_0_Click);
            // 
            // btn_plus_subtract
            // 
            this.btn_plus_subtract.BackColor = System.Drawing.Color.GhostWhite;
            this.btn_plus_subtract.ForeColor = System.Drawing.Color.Black;
            this.btn_plus_subtract.Location = new System.Drawing.Point(108, 570);
            this.btn_plus_subtract.Name = "btn_plus_subtract";
            this.btn_plus_subtract.Size = new System.Drawing.Size(100, 60);
            this.btn_plus_subtract.TabIndex = 33;
            this.btn_plus_subtract.Text = "+ / -";
            this.btn_plus_subtract.UseVisualStyleBackColor = false;
            this.btn_plus_subtract.Click += new System.EventHandler(this.btn_plus_subtract_Click);
            // 
            // btn_plus
            // 
            this.btn_plus.ForeColor = System.Drawing.Color.Black;
            this.btn_plus.Location = new System.Drawing.Point(414, 504);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(100, 60);
            this.btn_plus.TabIndex = 31;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_3
            // 
            this.btn_3.BackColor = System.Drawing.Color.GhostWhite;
            this.btn_3.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_3.ForeColor = System.Drawing.Color.Black;
            this.btn_3.Location = new System.Drawing.Point(312, 504);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(100, 60);
            this.btn_3.TabIndex = 30;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = false;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.Color.GhostWhite;
            this.btn_2.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_2.ForeColor = System.Drawing.Color.Black;
            this.btn_2.Location = new System.Drawing.Point(210, 504);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(100, 60);
            this.btn_2.TabIndex = 29;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = false;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.Color.GhostWhite;
            this.btn_1.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_1.ForeColor = System.Drawing.Color.Black;
            this.btn_1.Location = new System.Drawing.Point(108, 504);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(100, 60);
            this.btn_1.TabIndex = 28;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_subtract
            // 
            this.btn_subtract.ForeColor = System.Drawing.Color.Black;
            this.btn_subtract.Location = new System.Drawing.Point(414, 438);
            this.btn_subtract.Name = "btn_subtract";
            this.btn_subtract.Size = new System.Drawing.Size(100, 60);
            this.btn_subtract.TabIndex = 26;
            this.btn_subtract.Text = "-";
            this.btn_subtract.UseVisualStyleBackColor = true;
            this.btn_subtract.Click += new System.EventHandler(this.btn_subtract_Click);
            // 
            // btn_6
            // 
            this.btn_6.BackColor = System.Drawing.Color.GhostWhite;
            this.btn_6.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_6.ForeColor = System.Drawing.Color.Black;
            this.btn_6.Location = new System.Drawing.Point(312, 438);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(100, 60);
            this.btn_6.TabIndex = 25;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = false;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_5
            // 
            this.btn_5.BackColor = System.Drawing.Color.GhostWhite;
            this.btn_5.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_5.ForeColor = System.Drawing.Color.Black;
            this.btn_5.Location = new System.Drawing.Point(210, 438);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(100, 60);
            this.btn_5.TabIndex = 24;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = false;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_4
            // 
            this.btn_4.BackColor = System.Drawing.Color.GhostWhite;
            this.btn_4.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_4.ForeColor = System.Drawing.Color.Black;
            this.btn_4.Location = new System.Drawing.Point(108, 438);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(100, 60);
            this.btn_4.TabIndex = 23;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = false;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_mul
            // 
            this.btn_mul.ForeColor = System.Drawing.Color.Black;
            this.btn_mul.Location = new System.Drawing.Point(414, 372);
            this.btn_mul.Name = "btn_mul";
            this.btn_mul.Size = new System.Drawing.Size(100, 60);
            this.btn_mul.TabIndex = 21;
            this.btn_mul.Text = "X";
            this.btn_mul.UseVisualStyleBackColor = true;
            this.btn_mul.Click += new System.EventHandler(this.btn_mul_Click);
            // 
            // btn_9
            // 
            this.btn_9.BackColor = System.Drawing.Color.GhostWhite;
            this.btn_9.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_9.ForeColor = System.Drawing.Color.Black;
            this.btn_9.Location = new System.Drawing.Point(312, 372);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(100, 60);
            this.btn_9.TabIndex = 20;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = false;
            this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
            // 
            // btn_8
            // 
            this.btn_8.BackColor = System.Drawing.Color.GhostWhite;
            this.btn_8.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_8.ForeColor = System.Drawing.Color.Black;
            this.btn_8.Location = new System.Drawing.Point(210, 372);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(100, 60);
            this.btn_8.TabIndex = 19;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = false;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn_7
            // 
            this.btn_7.BackColor = System.Drawing.Color.GhostWhite;
            this.btn_7.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_7.ForeColor = System.Drawing.Color.Black;
            this.btn_7.Location = new System.Drawing.Point(108, 372);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(100, 60);
            this.btn_7.TabIndex = 18;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = false;
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // btn_div
            // 
            this.btn_div.ForeColor = System.Drawing.Color.Black;
            this.btn_div.Location = new System.Drawing.Point(414, 306);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(100, 60);
            this.btn_div.TabIndex = 16;
            this.btn_div.Text = "/";
            this.btn_div.UseVisualStyleBackColor = true;
            this.btn_div.Click += new System.EventHandler(this.btn_div_Click);
            // 
            // btn_moduler
            // 
            this.btn_moduler.ForeColor = System.Drawing.Color.Black;
            this.btn_moduler.Location = new System.Drawing.Point(312, 306);
            this.btn_moduler.Name = "btn_moduler";
            this.btn_moduler.Size = new System.Drawing.Size(100, 60);
            this.btn_moduler.TabIndex = 15;
            this.btn_moduler.Text = "%";
            this.btn_moduler.UseVisualStyleBackColor = true;
            this.btn_moduler.Click += new System.EventHandler(this.btn_moduler_Click);
            // 
            // btn_closeBracket
            // 
            this.btn_closeBracket.ForeColor = System.Drawing.Color.Black;
            this.btn_closeBracket.Location = new System.Drawing.Point(210, 306);
            this.btn_closeBracket.Name = "btn_closeBracket";
            this.btn_closeBracket.Size = new System.Drawing.Size(100, 60);
            this.btn_closeBracket.TabIndex = 14;
            this.btn_closeBracket.Text = ")";
            this.btn_closeBracket.UseVisualStyleBackColor = true;
            this.btn_closeBracket.Click += new System.EventHandler(this.btn_closeBracket_Click);
            // 
            // btn_openBracket
            // 
            this.btn_openBracket.ForeColor = System.Drawing.Color.Black;
            this.btn_openBracket.Location = new System.Drawing.Point(108, 306);
            this.btn_openBracket.Name = "btn_openBracket";
            this.btn_openBracket.Size = new System.Drawing.Size(100, 60);
            this.btn_openBracket.TabIndex = 13;
            this.btn_openBracket.Text = "(";
            this.btn_openBracket.UseVisualStyleBackColor = true;
            this.btn_openBracket.Click += new System.EventHandler(this.btn_openBracket_Click);
            // 
            // btn_del
            // 
            this.btn_del.ForeColor = System.Drawing.Color.Black;
            this.btn_del.Location = new System.Drawing.Point(414, 240);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(100, 60);
            this.btn_del.TabIndex = 11;
            this.btn_del.Text = "<-";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_CE
            // 
            this.btn_CE.ForeColor = System.Drawing.Color.Black;
            this.btn_CE.Location = new System.Drawing.Point(312, 240);
            this.btn_CE.Name = "btn_CE";
            this.btn_CE.Size = new System.Drawing.Size(100, 60);
            this.btn_CE.TabIndex = 10;
            this.btn_CE.Text = "CE";
            this.btn_CE.UseVisualStyleBackColor = true;
            this.btn_CE.Click += new System.EventHandler(this.btn_CE_Click);
            // 
            // btn_rightBitShift
            // 
            this.btn_rightBitShift.ForeColor = System.Drawing.Color.Black;
            this.btn_rightBitShift.Location = new System.Drawing.Point(210, 240);
            this.btn_rightBitShift.Name = "btn_rightBitShift";
            this.btn_rightBitShift.Size = new System.Drawing.Size(100, 60);
            this.btn_rightBitShift.TabIndex = 9;
            this.btn_rightBitShift.Text = ">>";
            this.btn_rightBitShift.UseVisualStyleBackColor = true;
            // 
            // btn_leftBitShift
            // 
            this.btn_leftBitShift.ForeColor = System.Drawing.Color.Black;
            this.btn_leftBitShift.Location = new System.Drawing.Point(108, 240);
            this.btn_leftBitShift.Name = "btn_leftBitShift";
            this.btn_leftBitShift.Size = new System.Drawing.Size(100, 60);
            this.btn_leftBitShift.TabIndex = 8;
            this.btn_leftBitShift.Text = "<<";
            this.btn_leftBitShift.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.GhostWhite;
            this.button5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button5.Location = new System.Drawing.Point(6, 570);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 60);
            this.button5.TabIndex = 7;
            this.button5.Text = "F";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.GhostWhite;
            this.button6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button6.Location = new System.Drawing.Point(6, 504);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 60);
            this.button6.TabIndex = 6;
            this.button6.Text = "E";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.GhostWhite;
            this.button3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button3.Location = new System.Drawing.Point(6, 438);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 60);
            this.button3.TabIndex = 5;
            this.button3.Text = "D";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.GhostWhite;
            this.button4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button4.Location = new System.Drawing.Point(6, 372);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 60);
            this.button4.TabIndex = 4;
            this.button4.Text = "C";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.GhostWhite;
            this.button2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2.Location = new System.Drawing.Point(6, 306);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 60);
            this.button2.TabIndex = 3;
            this.button2.Text = "B";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.GhostWhite;
            this.button1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Location = new System.Drawing.Point(6, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 60);
            this.button1.TabIndex = 2;
            this.button1.Text = "A";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // tb_mainDisplay
            // 
            this.tb_mainDisplay.BackColor = System.Drawing.Color.DimGray;
            this.tb_mainDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_mainDisplay.Font = new System.Drawing.Font("굴림", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_mainDisplay.Location = new System.Drawing.Point(3, 55);
            this.tb_mainDisplay.Name = "tb_mainDisplay";
            this.tb_mainDisplay.Size = new System.Drawing.Size(514, 61);
            this.tb_mainDisplay.TabIndex = 1;
            this.tb_mainDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_calculTop
            // 
            this.tb_calculTop.BackColor = System.Drawing.Color.DimGray;
            this.tb_calculTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_calculTop.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_calculTop.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tb_calculTop.Location = new System.Drawing.Point(3, 20);
            this.tb_calculTop.Name = "tb_calculTop";
            this.tb_calculTop.Size = new System.Drawing.Size(514, 34);
            this.tb_calculTop.TabIndex = 0;
            this.tb_calculTop.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_calculTop.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // tp_Exit
            // 
            this.tp_Exit.Location = new System.Drawing.Point(4, 25);
            this.tp_Exit.Name = "tp_Exit";
            this.tp_Exit.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Exit.Size = new System.Drawing.Size(1024, 669);
            this.tp_Exit.TabIndex = 6;
            this.tp_Exit.Text = "Exit";
            this.tp_Exit.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1032, 698);
            this.Controls.Add(this.tab);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tab.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_warning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tp_History.ResumeLayout(false);
            this.tp_History.PerformLayout();
            this.tp_Search.ResumeLayout(false);
            this.tp_Search.PerformLayout();
            this.tp_Control.ResumeLayout(false);
            this.tp_Control.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tp_Calculator.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tp_Setup;
        private System.Windows.Forms.TabPage tp_Monitoring;
        private System.Windows.Forms.TabPage tp_History;
        private System.Windows.Forms.TabPage tp_Search;
        private System.Windows.Forms.TabPage tp_Control;
        private System.Windows.Forms.Label label4_DBStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1_PortStatus;
        private System.Windows.Forms.Label label2_BPS;
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
        private System.Windows.Forms.Button button2_WETSearch;
        private System.Windows.Forms.TextBox textBox3_WET_Search_HIGH;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox4_WET_Search_LOW;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button1_TMPSearch;
        private System.Windows.Forms.TextBox textBox2_TMP_Search_HIGH;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox1_TMP_Search_LOW;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListView listView1_Search;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13_SearchName;
        private System.Windows.Forms.Button button1_WETHIGHSearch;
        private System.Windows.Forms.Button button2_WETLOWSearch;
        private System.Windows.Forms.Button button1_TMPHIGHSearch;
        private System.Windows.Forms.Button button1_TMPLOWSearch;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox1_sw1;
        private System.Windows.Forms.TabPage tp_Calculator;
        private System.Windows.Forms.ProgressBar progressBar3_led3;
        private System.Windows.Forms.CheckBox checkBox3_sw3;
        private System.Windows.Forms.ProgressBar progressBar2_led2;
        private System.Windows.Forms.CheckBox checkBox2_sw2;
        private System.Windows.Forms.ProgressBar progressBar1_led1;
        private System.Windows.Forms.ProgressBar progressBar1_fan1;
        private System.Windows.Forms.CheckBox checkBox1_swFan1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tp_Exit;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tb_calculTop;
        private System.Windows.Forms.Button btn_equals;
        private System.Windows.Forms.Button btn_point;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_plus_subtract;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_subtract;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_mul;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.Button btn_moduler;
        private System.Windows.Forms.Button btn_closeBracket;
        private System.Windows.Forms.Button btn_openBracket;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_CE;
        private System.Windows.Forms.Button btn_rightBitShift;
        private System.Windows.Forms.Button btn_leftBitShift;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_mainDisplay;
        private System.Windows.Forms.TextBox tb_bin;
        private System.Windows.Forms.TextBox tb_oct;
        private System.Windows.Forms.TextBox tb_dec;
        private System.Windows.Forms.TextBox tb_hex;
    }
}

