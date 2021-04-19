using AddressBook.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Control
{


    class StudentControl
    {
        static StudentControl inst;
        List<Student> addressList = new List<Student>();
        RandomData rand;

        public List<Student> getList()
        {
            return addressList;
        }

        public static StudentControl getInst()
        {
            if (inst == null)
            {
                inst = new StudentControl();
            }
            return inst;
        }
        

        public StudentControl()
        {
            //r = new Random();
            rand = new RandomData(new Random()/* r */);
        }

        public void addStudentInfo()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine(" 주소록 정보를 입력");
            Console.WriteLine("--------------------");
            Console.Write("이름: ");
            string name = Console.ReadLine();
            Console.Write("전화번호: ");
            string tel = Console.ReadLine();
            Console.Write("주소: ");
            string address = Console.ReadLine();
            Console.Write("이메일: ");
            string email = Console.ReadLine();
            string id = rand.getRandomID();
            addressList.Add(new Student(id, name, tel, address, email));
            Console.WriteLine("정보가 정상적으로 저장됨");

        }

        public void readStudentInfo()
        {
            for (int i = 0; i < addressList.Count; i++)
            {
                Console.WriteLine("번호: " + (i + 1));
                Console.WriteLine("--------------------------");
                Console.WriteLine("이름: " + addressList[i].Name);
                Console.WriteLine("ID: " + addressList[i].Id);
                Console.WriteLine("전화번호: " + addressList[i].Tel);
                Console.WriteLine("주소: " + addressList[i].Address);
                Console.WriteLine("이메일: " + addressList[i].Email);
                Console.WriteLine("--------------------------");
            }
        }

        public void removeStudentInfo(string removeId)
        {
            for (int i = 0; i < addressList.Count; i++)
            {
                if (removeId.Equals(addressList[i].Id))
                {
                    addressList.RemoveAt(i);
                }
            }
            Console.WriteLine(removeId + " 정보가 삭제되었습니다.");
        }

        public void removeAllInfo()
        {
            addressList.Clear();
            Console.WriteLine("모든 정보가 삭제되었습니다.");
        }

        public void modifyStudentInfo(string modifyId)
        {
            
            for (int i = 0; i < addressList.Count; i++)
            {
                if (modifyId.Equals(addressList[i].Id))
                {
                    Console.WriteLine("--------------------");
                    Console.WriteLine("    주소록 수정 ");
                    Console.WriteLine("--------------------");
                    Console.Write("이름: ");
                    string name = Console.ReadLine();
                    addressList[i].Name = name;
                    Console.Write("전화번호: ");
                    string tel = Console.ReadLine();
                    addressList[i].Tel = tel;
                    Console.Write("주소: ");
                    string address = Console.ReadLine();
                    addressList[i].Address = address;
                    Console.Write("이메일: ");
                    string email = Console.ReadLine();
                    addressList[i].Email = email;
                    Console.WriteLine("--------------------");
                    Console.WriteLine("   주소록 수정 완료 ");
                    Console.WriteLine("--------------------");
                    break;
                }
            }
        }

        public void randData(int count)
        {
            for (int i = 0; i < count; i++)
            {
                addressList.Add(new Student(rand.getRandomID(), rand.getName(), rand.getTel(), rand.getAddress(), rand.getEmail()));
            }
        }

    }
}
