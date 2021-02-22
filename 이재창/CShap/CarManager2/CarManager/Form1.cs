using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CarManager
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();
            string sql = "";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "table1");

        }

        private void btn_parkingAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //ParkingCar car = DataManager.Cars.Single((x) => x.ParkingSpot.ToString() == tb_parkingSpot.Text);
                //Func<ParkingCar, bool> func = (x) => x.ParkingSpot.ToString() == tb_parkingSpot.Text; 
                
                int spot = Convert.ToInt32(tb_parkingSpot.Text);
                DataManager.Cars[spot - 1].CarNumber = tb_carNum.Text;
                DataManager.Cars[spot - 1].DriverName = tb_driverName.Text;
                DataManager.Cars[spot - 1].PhoneNumber = tb_callNum.Text;
                DataManager.Cars[spot - 1].ParkingTime = DateTime.Now;

                // 데이터소스에 null을 넣어서 한번 비워주고 다시 넣어야함
                dgv_parkingState.DataSource = null;
                dgv_parkingState.DataSource = DataManager.Cars;                
            }
            catch (Exception)
            {
                MessageBox.Show("모든 정보를 입력해주세요.");
            }                      
        }

        private void btn_parkingClear_Click(object sender, EventArgs e)
        {
            int parkingSpot = Convert.ToInt32(tb_parkingSpot.Text);

            DataManager.Cars[parkingSpot - 1].CarNumber = string.Empty;
            DataManager.Cars[parkingSpot - 1].DriverName = string.Empty;
            DataManager.Cars[parkingSpot - 1].PhoneNumber = string.Empty;
            DataManager.Cars[parkingSpot - 1].ParkingTime = DateTime.Now;

            // 데이터소스에 null을 넣어서 한번 비워주고 다시 넣어야함
            dgv_parkingState.DataSource = null;
            dgv_parkingState.DataSource = DataManager.Cars;
        }

        private void dgv_parkingState_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                ParkingCar car = dgv_parkingState.CurrentRow.DataBoundItem as ParkingCar;

                tb_parkingSpot.Text = car.ParkingSpot.ToString();
                tb_carNum.Text = car.CarNumber;
                tb_driverName.Text = car.DriverName;
                tb_callNum.Text = car.PhoneNumber;
            }
            catch (Exception)
            {
                
            }            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString("G");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DataManager.SaveXml();
        }
    }
}
