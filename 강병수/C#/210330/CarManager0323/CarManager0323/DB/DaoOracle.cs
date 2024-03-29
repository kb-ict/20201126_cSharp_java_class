﻿using CarManager0323.Model;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager0323.DB
{
    class DaoOracle
    {
        const string CONNECT_ERR = "DB 접속";
        const string DISCONNECT_ERR = "DB 접속 해제";
        const string CREATE_TB_ERR = "테이블+시퀀스 생성";
        const string DROP_TB_ERR = "테이블+시퀀스 삭제";
        const string ORADB =
            "Data Source=(DESCRIPTION=(ADDRESS_LIST=" + "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)" +
            "(PORT=1521)))" +
            "(CONNECT_DATA=(SERVER=DEDICATED)" +
            "(SERVICE_NAME=XE)));" +
            "User ID=C##scott;Password=1126;";
        OracleConnection conn;
        OracleCommand cmd;

        public DaoOracle()
        {
            conn = new OracleConnection(ORADB);
            cmd = new OracleCommand();
            dbConnect();
        }

        ~DaoOracle()
        {
            dbClose();
        }

        public void dbConnect()
        {
            try
            {
                conn.Open();
                Console.WriteLine("오라클 접속 성공");
            }
            catch (OracleException e)
            {
                errorMsg(CONNECT_ERR, e);
            }
        }

        public void dbClose()
        {
            try
            {
                conn.Close();
                Console.WriteLine("오라클 접속 해제");
            }
            catch (OracleException e)
            {
                errorMsg(DISCONNECT_ERR, e);
            }
        }

        public void errorMsg(string msg, OracleException e)
        {
            Console.WriteLine(msg + ":에러 번호" + e.Number);
            Console.WriteLine(msg + ":에러 코드" + e.ErrorCode.ToString());
            Console.WriteLine(msg + ":에러 내용" + e.Message);

        }

        public void makeTbCar()
        {
            try
            {
                string query = "CREATE TABLE Car (" +
                "Model VARCHAR2(20) NOT NULL, " +
                "Year VARCHAR2(20) NOT NULL, " +
                "Price VARCHAR2(20) NOT NULL, " +
                "Color VARCHAR2(20) NOT NULL, " +
                "car_ID VARCHAR2(20) NOT NULL, " +
                "CONSTRAINT CAR_PK PRIMARY KEY(car_ID))";

                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string querySeq = "CREATE SEQUENCE Car_SEQ " +
                        "START WITH 1 INCREMENT BY 1 ";
                cmd.CommandText = querySeq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블, 시퀀스 생성 성공");
            }
            catch (OracleException e)
            {
                errorMsg(CREATE_TB_ERR, e);
            }
        }

        public void makeTbCustomer()
        {
            try
            {
                string query = "CREATE TABLE Customer(" +
                "cus_ID VARCHAR2(20) NOT NULL, " +
                "cus_Name VARCHAR2(20) NOT NULL, " +
                "cus_Address VARCHAR2(50) NOT NULL, " +
                "cus_Email VARCHAR2(40) NULL, " +
                "cus_Tel VARCHAR2(20) NOT NULL, " +
                "CONSTRAINT CUSTOMER_PK PRIMARY KEY(cus_ID))";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string querySeq = "CREATE SEQUENCE Customer_SEQ " +
                        "START WITH 1 INCREMENT BY 1 ";
                cmd.CommandText = querySeq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블, 시퀀스 생성 성공");

            }
            catch (OracleException e)
            {
                errorMsg(CREATE_TB_ERR, e);
            }
        }

        public void makeTbSeller()
        {
            try
            {
                string query = "CREATE TABLE Seller(" +
                "cr_ID VARCHAR2(20) NOT NULL, " +
                "cr_Name VARCHAR2(20) NOT NULL, " +
                "cr_Tel VARCHAR2(20) NOT NULL, " +
                "cr_Email VARCHAR2(24) NULL, " +
                "cr_Address VARCHAR2(50) NOT NULL, " +
                "CONSTRAINT SELLER_PK PRIMARY KEY(cr_ID))";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string querySeq = "CREATE SEQUENCE Seller_SEQ " +
                    "START WITH 1 INCREMENT BY 1";
                cmd.CommandText = querySeq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블, 시퀀스 생성 성공");
            }
            catch (OracleException e)
            {
                errorMsg(CREATE_TB_ERR, e);
            }
        }

        public void makeTbTrade()
        {
            try
            {
                string query = "CREATE TABLE Trade(" +
                "tr_ID VARCHAR2(20) NOT NULL," +
                "tr_Date DATE NOT NULL," +
                "cus_ID VARCHAR2(20)    NOT NULL," +
                "car_ID     VARCHAR2(20)    NOT NULL," +
                "cr_ID      VARCHAR2(20)    NOT NULL," +
                "CONSTRAINT FK_Trade_car_ID_Car_car_ID FOREIGN KEY (car_ID) " +
                "REFERENCES Car(car_ID)," +
                "CONSTRAINT FK_Trade_cus_ID_Customer_cus_ID FOREIGN KEY (cus_ID) " +
                "REFERENCES Customer(cus_ID)," +
                "CONSTRAINT FK_Trade_cr_ID_Seller_cr_ID FOREIGN KEY (cr_ID) " +
                "REFERENCES Seller(cr_ID)," +
                "CONSTRAINT TRADE_PK PRIMARY KEY(tr_ID, cus_ID, car_ID, cr_ID))";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string querySeq = "CREATE SEQUENCE Trade_SEQ " +
                    "START WITH 1 INCREMENT BY 1";
                cmd.CommandText = querySeq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블, 시퀀스 생성 성공");
            }
            catch (OracleException e)
            {
                errorMsg(CREATE_TB_ERR, e);
            }
        }



        public void createTable()
        {
            try
            {
                string query = "create table testTB (" +
                    "id number not null," +
                    "name varchar2(20) not null," +
                    "age number not null," +
                    "constraint pk_testTB_id primary key(id))";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string querySeq = "create sequence seq_testTB_id " +
                    "increment by 1 start with 1";
                cmd.CommandText = querySeq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블, 시퀀스 생성 성공");
            }
            catch (OracleException e)
            {
                errorMsg(CREATE_TB_ERR, e);
            }
        }

        public void dropTable()
        {
            try
            {
                string query = "drop table testTB";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string querySeq = "drop sequence seq_testTB_id";
                cmd.CommandText = querySeq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블, 시퀀스 삭제 성공");
            }
            catch (OracleException e)
            {
                errorMsg(DROP_TB_ERR, e);
            }
        }

        public void dropTable(string TB, string seq)
        {
            try
            {
                string query = "drop table " + TB;
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string querySeq = "drop sequence " + seq;
                cmd.CommandText = querySeq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블, 시퀀스 삭제 성공");
            }
            catch (OracleException e)
            {
                errorMsg(DROP_TB_ERR, e);
            }
        }

        public void makeAllTB()
        {
            makeTbCar();
            makeTbCustomer();
            makeTbSeller();
            makeTbTrade();
        }

        public void dropAllTB()
        {
            dropTable("Trade", "Trade_seq");
            dropTable("Customer", "customer_seq");
            dropTable("Car", "Car_seq");
            dropTable("Seller", "Seller_seq");
        }

        public void insertCar()
        {
            try
            {
                string sql = "insert into Car values (" +
                    "'그랜저', '2021년형', '3000만원', '회색', Car_SEQ.nextval)";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                errorMsg("insertCar()", e);
            }
        }

        public void insertSeller()
        {
            try
            {
                string sql = "insert into Seller values (" +
                    "Seller_SEQ.nextval, '둘리', '0105-657-1232', 'dol@gmail.com', '서울특별시 쌍문동')";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                errorMsg("insertSeller()", e);
            }
        }

        public void insertCustomer()
        {
            try
            {
                string sql = "insert into Customer values (" +
                    "Customer_SEQ.nextval, '마이콜', '서울특별시', 'mai@gmail.com', '011-578-3197')";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                errorMsg("insertCustomer()", e);
            }
        }

        public void insertTrade()
        {
            try
            {
                string sql = "insert into Trade (tr_id, tr_date, " +
                    "cr_id, cus_id, car_id ) " +
                    "(select trade_SEQ.nextval, sysdate, " +
                    "s.cr_id, cus_id, ca.car_id " +
                    "from seller s natural join customer cu " +
                    "natural join car ca " +
                    "where cu.cus_name='마이콜' and ca.Model='그랜저' " +
                    "and s.cr_name='둘리')";
                    /*" (select s.cr_id from seller s, customer cu where cu.cus_id = s.cr_id), " +
                    " (select cu.cus_id from customer cu, car ca where ca.car_id = cu.cus_ID)," +
                    " (select ca.car_id from car ca, customer cu where cu.cus_id = ca.car_id))";*/
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                errorMsg("insertTrade()", e);
            }
        }

        public void insertCar(Car car)
        {
            try
            {
                string sql1 = string.Format("insert into Car values (" +
                    "'{0}', '{1}', '{2}', '{3}', car_SEQ.nextval)", car.Model, car.Year, car.Price, car.Color); 
                cmd.Connection = conn;
                cmd.CommandText = sql1;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                errorMsg("insertCar()", e);
            }
        }

        public void insertCustomer(Customer customer)
        {
            try
            {
                string sql1 = string.Format("insert into Customer values (" +
                    "Customer_SEQ.nextval, '{0}', '{1}', '{2}', '{3}')", customer.Name, customer.Address, customer.Email, customer.Tel);
                cmd.Connection = conn;
                cmd.CommandText = sql1;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                errorMsg("insertCustomer()", e);
            }
        }

        public void insertSeller(Seller seller)
        {
            try
            {
                string sql1 = string.Format("insert into Seller values (" +
                    "Seller_SEQ.nextval, '{0}', '{1}', '{2}', '{3}')", seller.Name, seller.Tel, seller.Email, seller.Address);
                cmd.Connection = conn;
                cmd.CommandText = sql1;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                errorMsg("insertCustomer()", e);
            }
        }

        public void insertTrade(Trade deal)
        {
            try
            {
                string sql = string.Format( "insert into Trade (tr_id, tr_date, " +
                    "cr_id, cus_id, car_id ) " +
                    "(select trade_SEQ.nextval, sysdate, " +
                    "s.cr_id, cus_id, ca.car_id " +
                    "from seller s natural join customer cu " +
                    "natural join car ca " +
                    "where cu.cus_name='{0}' and ca.Model='{1}' " +
                    "and s.cr_name='{2}')", deal.Customer.Name, deal.Car.Model, deal.Seller.Name);
                /*" (select s.cr_id from seller s, customer cu where cu.cus_id = s.cr_id), " +
                " (select cu.cus_id from customer cu, car ca where ca.car_id = cu.cus_ID)," +
                " (select ca.car_id from car ca, customer cu where cu.cus_id = ca.car_id))";*/
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                errorMsg("insertTrade()", e);
            }
        }
    }
}
