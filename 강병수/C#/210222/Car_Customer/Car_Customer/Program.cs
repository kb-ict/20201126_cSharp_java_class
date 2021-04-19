using Car_Customer.Control;
using Car_Customer.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Customer
{
    class Program
    {
        const int MAIN_CAR_ADD = 1;
        const int MAIN_CAR_READ = 2;
        const int MAIN_CAR_MODIFY = 3;
        const int MAIN_CAR_DELETE = 4;
        const int MAIN_CAR_CLEAR = 5;
        const int MAIN_CAR_EXIT = 6;
        
        static void Main(string[] args)
        {
            CarHandler con = new CarHandler();
            Present pre = new Present();
            
            while (true)
            {
                switch (pre.mainMenu())
                {
                    case MAIN_CAR_ADD:
                        con.addCarInfo();
                        break;
                    case MAIN_CAR_READ:
                        con.viewCarInfo();
                        break;
                    case MAIN_CAR_MODIFY:
                        con.modifyCarInfo(pre.modifyMenu());
                        break;
                    case MAIN_CAR_DELETE:
                        con.deleteCarInfo(pre.deleteMenu());
                        break;
                    case MAIN_CAR_CLEAR:
                        con.clearCarInfo();
                        break;
                    case MAIN_CAR_EXIT:
                        Console.WriteLine("프로그램 종료");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("잘못된 입력");
                        break;
                }
            }
        }
    }
}
