using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manage_car_Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //DataManager.Load();
            //List<ParkingCar> cars = new List<ParkingCar>();
            //cars.Add(new ParkingCar() { ParkingSpot=1, CarNumber="47차1111", DriverName="강병수", 
            //PhoneNumber="010-1111-1111", ParkingTime=DateTime.Now});
            dataGridView1.DataSource = DataManager.Cars;
            textBox1.Text = DataManager.Cars[0].ParkingSpot.ToString();
            textBox2.Text = DataManager.Cars[0].CarNumber.ToString();
            textBox3.Text = DataManager.Cars[0].DriverName.ToString();
            textBox4.Text = DataManager.Cars[0].PhoneNumber.ToString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           WhatTime.Text = "지금은: " + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "입니다.";
        }

        private void Parking_Click(object sender, EventArgs e)
        {
                // writeLog("주차 버튼 클릭");
                if (textBox1.Text.Trim() == "") //Trim 공백 제거 함수
                {
                    MessageBox.Show("주차공간을 입력하십시오");
                    writeLog("주차공간을 입력하십시오");
                }
                else if (textBox2.Text.Trim() == "") // 차량 번호를 입력하지 않은 경우
                {
                    MessageBox.Show("차량번호를 입력하십시오");
                    writeLog("차량번호를 입력하십시오");
                }
                else
                {
                    try
                    {
                    // 본격적으로 입력하는 작업

                    // 참조변수와 람다개념을 알고 있느 경우
                    ParkingCar car = DataManager.Cars.Single((x) => x.ParkingSpot.ToString() == textBox1.Text);
                    if (car.CarNumber.Trim() != "") // 이미 차 정보가 저장되어있음
                        {
                            MessageBox.Show("해당 공간에는 이미 차가 존재합니다: " + textBox1.Text + "번 공간");
                            writeLog("해당 공간에는 이미 차가 존재합니다" + textBox1.Text);
                        }
                        else //아직 차 정보가 없음
                        {
                            car.ParkingSpot = int.Parse(textBox1.Text);
                            car.CarNumber = textBox2.Text;
                            car.DriverName = textBox3.Text;
                            car.PhoneNumber = textBox4.Text;
                            car.ParkingTime = DateTime.Now;

                            dataGridView1.DataSource = null;
                            dataGridView1.DataSource = DataManager.Cars;
                            DataManager.Save();

                            string contents = $"주차 공간 {textBox1.Text}에 {textBox2.Text}차를 주차하였습니다";
                            writeLog(contents, DateTime.Now.ToString("yyyy_MM_dd"));
                        }
                    }
                    catch (Exception ex)
                    {
                        string contents = "주차할 수 없습니다" + textBox1.Text;
                        MessageBox.Show(contents);
                        writeLog(contents);
                        writeLog(ex.Message);
                        writeLog(ex.StackTrace);
                    }
                }

        }
        private void Exit_Click(object sender, EventArgs e)
        {
            // writeLog("출차 버튼 클릭");

            if(textBox1.Text.Trim() == "")
            {
                MessageBox.Show("주차 공간 번호를 입력하십시오");
                return;
            }
            // Single 업싱 조회하고 해당하는 데이터 변경
            try
            {
                for (int i = 0; i< DataManager.Cars.Count; i++)
                {
                    if(DataManager.Cars[i].ParkingSpot.ToString() == textBox1.Text)
                    {
                        if(DataManager.Cars[i].CarNumber.Trim() == "")
                        {
                            MessageBox.Show("해당 공간에 차가 존재하지 않습니다");
                            writeLog("해당 공간에 차가 존재하지 않습니다");
                            break;
                        }
                        else
                        {
                            DataManager.Cars[i].CarNumber = "";
                            DataManager.Cars[i].DriverName = "";
                            DataManager.Cars[i].PhoneNumber = "";
                            DataManager.Cars[i].ParkingTime = DateTime.Now;
                            string contents = $"주차공간 {textBox1.Text}에 {textBox2.Text}차량 출차";
                            MessageBox.Show(contents);
                            writeLog(contents);
                            dataGridView1.DataSource = null; // dataGridView1의 데이터 한 번 지워줌 
                            dataGridView1.DataSource = DataManager.Cars; //다시 리셋
                            DataManager.Save();
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("출차가 되지 않았습니다");
                writeLog("출차가 되지 않았습니다");
                writeLog(ex.Message);
                writeLog(ex.StackTrace);
            }
            
        }

        private void ViewPark_Click(object sender, EventArgs e)
        {
            // writeLog("3번 버튼 클릭");
            // writeLog("3번 버튼 클릭", DateTime.Now.ToString("yyyy_MM_dd"));
            if(textBox5.Text.Trim() == "")
            {
                MessageBox.Show("공간번호를 입력하십시오");
                writeLog("공간번호를 입력하십시오");
                return;
            }
            else
            {
                try
                {
                    for (int i = 0; i < DataManager.Cars.Count; i++)
                    {
                        if (textBox5.Text == DataManager.Cars[i].ParkingSpot.ToString())
                        {
                            MessageBox.Show("현재 공간에 저장되어있는 차량번호는 " + DataManager.Cars[i].CarNumber + "입니다");
                            writeLog("현재 공간에 저장되어있는 차량번호는 " + DataManager.Cars[i].CarNumber + "입니다");
                            break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("주차공간 번호를 잘못 입력하였습니다");
                    writeLog("주차공간 번호를 잘못 입력하였습니다");
                    writeLog(ex.Message);
                    writeLog(ex.StackTrace);
                }
            }
        }

        private void writeLog(string contents)
        {
            // int a = 1;
            // MessageBox.Show(a.ToString("00")); //01이라고 출력됨. 3자리 이상 입력하면 그대로 출력됨
            string logContents = $"[{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}]" +
                $"{contents}";

            // 옛날 것이 가장 위에 올라가는 방식
            // 새로운 내용이 뒤에 추가가 되어서, 새로운 내용을 보려면
            // 밑으로 내려야 함 
            // listBox1.Items.Add(logContents);

            // 새로운 것이 가장 위에 올라가는 방식
            // 새로운 내용이 가장 앞에 잇게 되는 것
            listBox1.Items.Insert(0, logContents);
            DataManager.printLog(logContents);
        }
        //writeLog 함수 오버로딩
        private void writeLog(string contents, string date)
        {
            // int a = 1;
            // MessageBox.Show(a.ToString("00")); //01이라고 출력됨. 3자리 이상 입력하면 그대로 출력됨
            string logContents = $"[{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}]" +
                $"{contents}";

            listBox1.Items.Insert(0, logContents);
            DataManager.printLog(logContents, date);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ParkingCar temp = dataGridView1.CurrentRow.DataBoundItem as ParkingCar;
                textBox1.Text = temp.ParkingSpot.ToString();
                textBox2.Text = temp.CarNumber;
                textBox3.Text = temp.DriverName;
                textBox4.Text = temp.PhoneNumber;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
                writeLog(ex.Message);
                writeLog(ex.StackTrace);
            }
        }
    }
}
