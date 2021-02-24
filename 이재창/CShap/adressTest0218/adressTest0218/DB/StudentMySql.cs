using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace adressTest0218
{
    /// <summary>
    /// 주소록과 MySql 연동 클래스
    /// </summary>
    public class StudentMySql
    {
        MySqlConnection connection;
        public string Table { get; set; }

        /// <summary>
        /// MySql 서버에 연결합니다.
        /// </summary>
        public StudentMySql(string server, string dataBase, string uid, string pwd, string table)
        {
            connection = new MySqlConnection(
                $"Server={server};Database={dataBase};Uid={uid};Pwd={pwd};");
            Table = table;
        }

        /// <summary>
        /// 레코드를 조회합니다.
        /// </summary>
        /// <param name="manager"></param>
        public void Select(StudentManager manager)
        {
            connection.Open();
            string sql = $"select * from {Table}";
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection);
            adapter.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                Student student = new Student(
                    row["id"].ToString(),
                    row["name"].ToString(),
                    row["tel"].ToString(),
                    row["address"].ToString(),
                    row["email"].ToString());
                manager.Students.Add(student);
            }
            connection.Close();
        }

        /// <summary>
        /// 레코드를 삽입합니다.
        /// </summary>
        /// <param name="student"></param>
        public void Insert(Student student)
        {
            connection.Open();
            string sql = $"insert into {Table} values (" +
                $"@id, @name, @tel, @address, @email)";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.Add(new MySqlParameter("@id", student.Id));
            cmd.Parameters.Add(new MySqlParameter("@name", student.Name));
            cmd.Parameters.Add(new MySqlParameter("@tel", student.Tel));
            cmd.Parameters.Add(new MySqlParameter("@address", student.Address));
            cmd.Parameters.Add(new MySqlParameter("@email", student.Email));
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        /// <summary>
        /// 해당 ID의 레코드를 삭제합니다.
        /// </summary>
        /// <param name="id"></param>
        public void Delete(string id)
        {
            connection.Open();
            string sql = $"delete from {Table} where id=@id";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.Add(new MySqlParameter("@id", id));
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        /// <summary>
        /// 레코드를 수정합니다.
        /// </summary>
        /// <param name="student"></param>
        public void Update(Student student)
        {
            connection.Open();
            string sql = $"update {Table} set name=@name, tel=@tel," +
                $"address=@address, email=@email where id=@id";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.Add(new MySqlParameter("@id", student.Id));
            cmd.Parameters.Add(new MySqlParameter("@name", student.Name));
            cmd.Parameters.Add(new MySqlParameter("@tel", student.Tel));
            cmd.Parameters.Add(new MySqlParameter("@address", student.Address));
            cmd.Parameters.Add(new MySqlParameter("@email", student.Email));
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        /// <summary>
        /// 모든 레코드를 삭제합니다.
        /// </summary>
        public void Clear()
        {
            connection.Open();
            string sql = $"delete from {Table}";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
