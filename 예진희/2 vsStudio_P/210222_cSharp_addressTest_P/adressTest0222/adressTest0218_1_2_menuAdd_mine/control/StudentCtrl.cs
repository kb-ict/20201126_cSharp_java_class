using adressTest0218.util;
using adressTest0218.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adressTest0218.control
{
    class StudentCtrl
    {
        List<Student> addrList = new List<Student>(); //기본생성자에서 초기화하는거랑 같음
        RandData rand; //Random r ;
        Menu m;
        public StudentCtrl()
        {   //r = new Random();
            rand = new RandData(new Random()); // car class
        }

        public void addItem()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("주소록 정보 입력");
            Console.WriteLine("-----------------");
            Console.Write("이름: ");
            string name = Console.ReadLine();
            Console.Write("전화: ");
            string tel = Console.ReadLine();
            Console.Write("주소: ");
            string address = Console.ReadLine();
            Console.Write("이메일: ");
            string email = Console.ReadLine();

            addrList.Add(
                new Student(rand.getId(), name, tel, address, email));
            Console.WriteLine("정보가 정상적으로 입력되었습니다.");
        }


        public void viewItem()
        {
            for (int i = 0; i < addrList.Count; i++)
            {
                Console.WriteLine("번호: " + (i + 1));
                Console.WriteLine("아이디: " + addrList[i].Id);
                Console.WriteLine("이름: " + addrList[i].Name);
                Console.WriteLine("전화: " + addrList[i].Tel);
                Console.WriteLine("주소: " + addrList[i].Address);
                Console.WriteLine("이메일: " + addrList[i].Email);
                Console.WriteLine("-------------------------");
            }
        }

        public void delItem(string name)
        {
            for (int i = 0; i < addrList.Count; i++)
            {
                if (name.Equals(addrList[i].Name))
                {
                    addrList.RemoveAt(i--);
                }
            }
        }

        public void delItemAll()
        {
            addrList.Clear();
        }

        public void randData(int count)
        {
            for (int i = 0; i < count; i++)
            {
                addrList.Add(new Student(
                    rand.getId(),
                    rand.getName(),
                    rand.getTel(),
                    rand.getAddr(),
                    rand.getEmail()));
            }
        }

        public void updateItem(int menu)
        {
            if (menu == Menu.MENU_UPDATE_EXIT)
            {
                return;
            }
            //Console.Write("ID : ");
            //string id = Console.ReadLine();
            string id = idJohyoi();
            for (int i = 0; i < addrList.Count; i++)
            {
                switch (menu)
                {
                    case Menu.MENU_UPDATE_NAME:
                        if (id.Equals(addrList[i].Id))
                        {
                            Console.Write("이름 : ");
                            string name = Console.ReadLine();
                            addrList[i].Name = name;
                        }
                        break;
                    case Menu.MENU_UPDATE_TEL:
                        if (id.Equals(addrList[i].Id))
                        {
                            Console.Write("전화 : ");
                            string tel = Console.ReadLine();
                            addrList[i].Tel = tel;
                        }
                        break;
                    case Menu.MENU_UPDATE_ADDR:
                        if (id.Equals(addrList[i].Id))
                        {
                            Console.Write("주소 : ");
                            string address = Console.ReadLine();
                            addrList[i].Address = address;
                        }
                        break;
                    case Menu.MENU_UPDATE_EMAIL:
                        if (id.Equals(addrList[i].Id))
                        {
                            Console.Write("메일 : ");
                            string email = Console.ReadLine();
                            addrList[i].Email = email;
                        }
                        break;
                }
            }
        }

        public string idJohyoi()
        {
            Console.Write("ID : ");
            string id = Console.ReadLine();
            return id;
        }
    }
}

/* 1. 후위연산(공학용 계산기)
 * 2. 미로찾기
 * 3. 가중치 적용한 미로찾기(A* 알고리즘)
 */


