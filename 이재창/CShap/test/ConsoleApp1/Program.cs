using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string db_ip = "localhost";
            string db_name = "abc";
            string db_id = "root";
            string db_pw = "1126";
            string strCon = $"server={db_ip};uid={db_id};pwd={db_pw};database={db_name};charset=utf8;";
            string sql = string.Empty;

            // 데이터 베이스 연결
            MySqlConnection con = new MySqlConnection(strCon);
            con.Open();

            // 미리 선언
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, con);

            // 테이블 생성
#if false
            sql = "create table table1(name varchar(10) primary key, age int)";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            sql = "create table table2(name varchar(10) primary key, address varchar(20))";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery(); 
#endif

            // 레코드 추가
#if false
            sql = "insert into table1(name, age) values('둘리', 100)";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            sql = "insert into table1(name, age) values('도우너', 50)";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            sql = "insert into table1(name, age) values('또치', 20)";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            sql = "insert into table2 value('둘리', '지구')";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            sql = "insert into table2 value('도우너', '깐따삐야')";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            sql = "insert into table2 value('또치', '아프리카')";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery(); 
#endif


            // DataReader 사용 방법
            /*sql = "select * from test_tb";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader table = cmd.ExecuteReader();

            while (table.Read())
            {
                Console.WriteLine($"name : {table["name"]}  age : {table["age"]}");
            }
            table.Close();*/

            // DataAdapter 사용 방법 (이거 추천)
            DataSet ds = new DataSet();
            adapter.SelectCommand.CommandText = "select * from table1";
            adapter.Fill(ds, "t1");
            adapter.SelectCommand.CommandText = "select * from table2";
            adapter.Fill(ds, "t2");

            for (int i = 0; i < 2; i++)
            {
                foreach (DataRow r in ds.Tables[i].Rows)
                {
                    Console.WriteLine($"{ds.Tables[i].Columns[0]} : {r[0]} / {ds.Tables[i].Columns[1]} : {r[1]}");
                }
            }

            con.Close();
        }


        static void Bublesort(int[] ar)
        {
            for (int i = 0; i < ar.Length - 1; i++)
            {
                for (int j = 0; j < ar.Length - 1 - i; j++)
                {
                    if (ar[j] > ar[j + 1])
                    {
                        int temp = ar[j];
                        ar[j] = ar[j + 1];
                        ar[j + 1] = temp;
                    }
                }
            }
        }

        static void Bublesort<T>(T[] ar)
        {
            dynamic d_ar = ar;

            for (int i = 0; i < ar.Length - 1; i++)
            {
                for (int j = 0; j < ar.Length - 1 - i; j++)
                {
                    if (d_ar[j] > d_ar[j + 1])
                    {
                        T temp = d_ar[j];
                        ar[j] = ar[j + 1];
                        ar[j + 1] = temp;
                    }
                }
            }
        }
    }
}
