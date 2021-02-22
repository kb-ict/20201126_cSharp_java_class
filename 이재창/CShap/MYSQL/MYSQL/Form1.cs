using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MYSQL
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string strConn = "Server=localhost;Database=study;Uid=root;Pwd=1126;charset=utf8;";
            conn = new MySqlConnection(strConn);
            SelectDB();
        }

        // 데이터 추가 버튼
        private void btn_dataAdd_Click(object sender, EventArgs e)
        {
            conn.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;

            string sql = $"INSERT INTO student (name, age, department, address) VALUES (" +
                $"'{tb_name.Text}', {tb_age.Text}, '{tb_department.Text}', '{tb_address.Text}')";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();

            conn.Close();
            SelectDB();
        }

        // 조회 버튼
        private void btn_select_Click(object sender, EventArgs e)
        {
            SelectDB();
        }

        private void SelectDB()
        {
            conn.Open();

            string sql = "SELECT * FROM student";
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            adapter.Fill(dt);

            // 중복 조회 방지
            lv_student.Items.Clear();

            // 리스트뷰로 조회
            foreach (DataRow row in dt.Rows)
            {
                DataRow dr = row;
                ListViewItem lvItem = new ListViewItem();
                lvItem.SubItems.Add(dr["number"].ToString());
                lvItem.SubItems.Add(dr["name"].ToString());
                lvItem.SubItems.Add(dr["age"].ToString());
                lvItem.SubItems.Add(dr["department"].ToString());
                lvItem.SubItems.Add(dr["address"].ToString());
                lv_student.Items.Add(lvItem);
            }

            conn.Close();
        }

        // 수정 버튼
        private void btn_modify_Click(object sender, EventArgs e)
        {
            // 선택한 데이터가 있을 경우
            if (lv_student.SelectedItems.Count > 0)
            {
                conn.Open();

                string number = lv_student.SelectedItems[0].SubItems[1].Text;
                string sql = $"UPDATE student SET name = '{tb_name.Text}'," +
                    $" age = {tb_age.Text}, department = '{tb_department.Text}'," +
                    $"address = '{tb_address.Text}' WHERE number = {number}";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                conn.Close();

                SelectDB();
            }
        }

        // 리스트뷰의 선택된 항목이 바뀔경우
        private void lv_student_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                tb_name.Text = lv_student.SelectedItems[0].SubItems[2].Text;
                tb_age.Text = lv_student.SelectedItems[0].SubItems[3].Text;
                tb_department.Text = lv_student.SelectedItems[0].SubItems[4].Text;
                tb_address.Text = lv_student.SelectedItems[0].SubItems[5].Text;
            }
            catch (ArgumentOutOfRangeException)
            {

            }
        }

        // 삭제 버튼
        private void btn_remove_Click(object sender, EventArgs e)
        {
            conn.Open();

            foreach (ListViewItem item in lv_student.SelectedItems)
            {
                string number = item.SubItems[1].Text;
                string sql = $"DELETE FROM student WHERE number = {number}";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery(); 
            }

            conn.Close();

            SelectDB();
        }

        // 리스트뷰의 컬럼이 눌렸을 때
        private void lv_student_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (lv_student.Sorting == SortOrder.Ascending)
                lv_student.Sorting = SortOrder.Descending;
            else
                lv_student.Sorting = SortOrder.Ascending;

            ListViewItemComparer lvicpr = new ListViewItemComparer(
                lv_student.Sorting, e.Column, lv_student.Columns[e.Column].Tag);
            lv_student.ListViewItemSorter = lvicpr;
            lv_student.Sort();
        }
    }

    class ListViewItemComparer : IComparer
    {
        public int ColIndex { get; set; }
        public SortOrder Order { get; set; }
        public object Tag { get; set; }

        public ListViewItemComparer(SortOrder order, int colIndex, object tag)
        {
            ColIndex = colIndex;
            Order = order;
            Tag = tag;
        }
        public int Compare(object x, object y)
        {
            ListViewItem lx = x as ListViewItem;
            ListViewItem ly = y as ListViewItem;
            int compareValue = 0;

            if (Tag != null)
            {
                compareValue = double.Parse(lx.SubItems[ColIndex].Text).CompareTo(
                   double.Parse(ly.SubItems[ColIndex].Text));
            }
            else
            {
                compareValue = lx.SubItems[ColIndex].Text.CompareTo(
                    ly.SubItems[ColIndex].Text);
            }

            if (Order == SortOrder.Descending)
                compareValue *= -1;

            return compareValue; 
        }
    }
}
