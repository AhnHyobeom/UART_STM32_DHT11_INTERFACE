﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports; // Add for UART communication
using System.Data.SqlClient; // Add for MySQL
using MySql.Data.MySqlClient;

namespace UART_STM32_DHT11_INTERFACE
{
    public partial class Form1 : Form
    {
        String connStr = "Server=127.0.0.1;Uid=root;Pwd=1234;Database=sensor_db;Charset=UTF8";
        MySqlConnection conn; // 교량
        MySqlCommand cmd; // 트럭
        String sql = "";  // 물건박스
        MySqlDataReader reader; // 트럭이 가져올 끈
        string datain = ""; // UART로 부터 들어온 data를 읽어 들이는 변수
        string[] inputSensorData; // UART로 부터 들어온 data Parsing Array
        const int MAX_TMP = 30;
        const int MIN_TMP = 15;
        const int MAX_WET = 40;
        const int MIN_WET = 15;
        int[] temperAry = new int[30]; // for TMP draw chart
        int[] humiAry = new int[30]; // for WET draw chart
        string s_temper = ""; // DB INSERT 변수
        string s_humi = ""; // DB INSERT 변수
        public Form1()
        {
            InitializeComponent();
            getAvailalbePorts();
            pictureBox1_warning.Visible = false;
            conn = new MySqlConnection(connStr);
            conn.Open();
            cmd = new MySqlCommand("", conn);
            // ListView 상단 설정
            listView1_DB.View = View.Details;
            listView1_DB.Columns.Add("시간");
            listView1_DB.Columns.Add("온도");
            listView1_DB.Columns.Add("습도");
            initMonitoringListView();
            // 상한치 하한치 띄우기
            textBox1_MAXTMP.Text = MAX_TMP.ToString();
            textBox2_MINTMP.Text = MIN_TMP.ToString();
            textBox4_MAXWET.Text = MAX_WET.ToString();
            textBox3_MINWET.Text = MIN_WET.ToString();
        }
        private void label4_Click(object sender, EventArgs e)
        {
            
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        // Add Start ---------------------------------
        void getAvailalbePorts()
        {
            string[] ports = SerialPort.GetPortNames();
            comboBox1_Port.Items.AddRange(ports);
        }
        private void button1_OpenPort_Click(object sender, EventArgs e)
        {
            try
            {
                if(comboBox1_Port.Text == "" || comboBox2_Bps.Text == "")
                {
                    textBox1_ReceiveData.Text = "UART COM Port Select !!! " + Environment.NewLine;
                } else
                {
                    serialPort1.PortName = comboBox1_Port.Text;
                    serialPort1.BaudRate = Convert.ToInt32(comboBox2_Bps.Text);
                    serialPort1.Open(); // 예외 처리 집어 넣을것
                    progressBar1_PortStatus.Value = 100;
                    label1_Comport.Text = "ON";
                    label1_Comport.ForeColor = Color.Green;

                    button1_Send.Enabled = true;
                    button1_Clear.Enabled = true;
                    textBox1_SendData.Enabled = true;
                    button1_OpenPort.Enabled = false;
                    button2_ClosePort.Enabled = true;
                }
            } 
            catch(UnauthorizedAccessException)
            {
                textBox1_ReceiveData.Text = "UART Open Execption Error" + Environment.NewLine;
            }
        }
        // UART로부터 DATA가 들어오면 자동으로 수행되는 interrupt call back function
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //datain = serialPort1.ReadExisting(); // STM32로부터 들어온 data를 전부 reading
            // 주의할 점은 현재 115200bps로 설정 1char당 약 0.1ms 소요 시간 over에 유의
            datain = serialPort1.ReadLine(); // newLine을 만날때까지 읽어 들인다. ReadExisting보다 안정적
            this.Invoke(new EventHandler(showData));
        }
        private void showData(object sender, EventArgs e)
        {
            textBox1_ReceiveData.Text += datain;
            // [Tmp]22 ->   [Tmp]    28 
            // [Wet]28
            string s_date = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
            sql = "INSERT INTO sensor(s_date, s_temper, s_humi) VALUES ('";
            if (datain.Contains("[Tmp]") == true)
            {
                inputSensorData = datain.Split(new char[] { ']' });
                textBox1_Tmp.Text = inputSensorData[1];
                s_temper = inputSensorData[1];
            }
            if (datain.Contains("[Wet]") == true)
            {
                inputSensorData = datain.Split(new char[] { ']' });
                textBox2_Wet.Text = inputSensorData[1];
                s_humi = inputSensorData[1];
            }
            if (s_temper != "" && s_humi != "") 
            {
                sql += s_date + "', " + s_temper + ", " + s_humi + ")";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                addMonitoringListView(); // History에 추가
                warningCheck(); // 경고 확인
                s_temper = "";
                s_humi = "";
            }
        }
        private void button2_ClosePort_Click(object sender, EventArgs e)
        {
            serialPort1.Close(); // 예외 처리 집어 넣을것
            progressBar1_PortStatus.Value = 0;
            label1_Comport.Text = "OFF";
            label1_Comport.ForeColor = Color.Red;

            pictureBox1_warning.Visible = false;

            button1_Send.Enabled = false;
            button1_Clear.Enabled = false;
            textBox1_SendData.Enabled = false;
            button1_OpenPort.Enabled = true;
            button2_ClosePort.Enabled = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (datain == "")
            {
                return;
            }
            drawChart();
        }
        // 차트 그리기
        private void drawChart()
        {
            sql = "SELECT s_temper, s_humi FROM sensor ORDER BY s_date DESC LIMIT 1";
            cmd.CommandText = sql;
            reader = cmd.ExecuteReader();
            reader.Read();
            int temper = (int)reader["s_temper"];
            int humi = (int)reader["s_humi"];
            reader.Close();
            //한칸씩 당기기
            for (int i = 0; i < temperAry.Length - 1; i++)
            {
                temperAry[i] = temperAry[i + 1];
                humiAry[i] = humiAry[i + 1];
            }
            //최신 데이터를 마지막에 넣기
            temperAry[temperAry.Length - 1] = temper;
            humiAry[humiAry.Length - 1] = humi;
            //차트 그리기
            //온도 그래프
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            //습도 그래프
            chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();

            for (int i = 0; i < temperAry.Length; i++)
            {
                chart1.Series[0].Points.AddXY(i, temperAry[i]);
                chart1.Series[1].Points.AddXY(i, humiAry[i]);
            }
        }
        // 초기화 ListView
        private void initMonitoringListView()
        {
            sql = "SELECT s_date, s_temper, s_humi FROM sensor ORDER BY s_date";
            cmd.CommandText = sql;
            reader = cmd.ExecuteReader();
            reader.Read();
            ListViewItem item;
            int temper = 0;
            int humi = 0;
            DateTime date = new DateTime();
            while (reader.Read())
            {
                date = (DateTime)reader["s_date"];
                temper = (int)reader["s_temper"];
                humi = (int)reader["s_humi"];
                item = new ListViewItem(date.ToString());
                item.SubItems.Add(temper.ToString());
                item.SubItems.Add(humi.ToString());
                listView1_DB.Items.Add(item);
            }
            // 폭 조절하기 (열 사이즈에 맞춤)
            for (int i = 0; i < listView1_DB.Columns.Count; i++)
            {
                listView1_DB.Columns[i].TextAlign = HorizontalAlignment.Center;
                listView1_DB.Columns[i].Width = -2;
            }
            reader.Close();
        }
        // 추가 ListView
        private void addMonitoringListView()
        {
            sql = "SELECT s_date, s_temper, s_humi FROM sensor ORDER BY s_date DESC LIMIT 1";
            cmd.CommandText = sql;
            reader = cmd.ExecuteReader();
            reader.Read();
            ListViewItem item;

            DateTime date = new DateTime();
            date = (DateTime)reader["s_date"];
            int temper = (int)reader["s_temper"];
            int humi = (int)reader["s_humi"];
            item = new ListViewItem(date.ToString());
            item.SubItems.Add(temper.ToString());
            item.SubItems.Add(humi.ToString());
            listView1_DB.Items.Add(item);

            for (int i = listView1_DB.Columns.Count - 1; i < listView1_DB.Columns.Count; i++)
            {
                listView1_DB.Columns[i].TextAlign = HorizontalAlignment.Center;
                listView1_DB.Columns[i].Width = -2;
            }
            reader.Close();
        }
        // 경고창 확인 및 표시
        private void warningCheck()
        {
            if(int.Parse(s_humi) >= MAX_WET || int.Parse(s_temper) >= MAX_TMP ||
                int.Parse(s_humi) <= MIN_WET || int.Parse(s_temper) <= MIN_TMP)
            {
                pictureBox1_warning.Visible = true;
            } else
            {
                pictureBox1_warning.Visible = false;
            }
        }
        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Clear_Click(object sender, EventArgs e)
        {
            textBox1_ReceiveData.Text = "";
        }
    }
}