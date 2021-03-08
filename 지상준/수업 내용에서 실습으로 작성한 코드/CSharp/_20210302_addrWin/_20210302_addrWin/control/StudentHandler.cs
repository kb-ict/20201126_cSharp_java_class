using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210302_addrWin
{
    public class StudentHandler
    {
        private List<Student> addrList = new List<Student>();

        public List<Student> AddrList { get => addrList; }

        public void addItem(Student st)
        {
            if (st == null)
            {
                System.Windows.Forms.MessageBox.Show("void addItem(Student st) 매개변수에 null이 들어왔습니다. . .");
                return;
            }
            else
            {
                addrList.Add(
                    new Student(st.Name,
                    st.Tel,
                    st.Address,
                    st.Email)
                    );
            }
        }

        public void delItem(bool isAllClear)
        {
            if (!isAllClear)
                return;
            else
            {
                if (addrList.Count == 0)
                    System.Windows.Forms.MessageBox.Show("삭제할 정보가 없습니다");
                else
                {
                    addrList.Clear();
                    System.Windows.Forms.MessageBox.Show("모든 정보 삭제 완료 !!!!");
                }
            }

        }

        public void updateItemById(string id, string name, string tel, string address, string email)
        {
            if (!hasStAddr())
                return;

            Student stNeedToUpdate = null;
            for (int i = 0; i < addrList.Count; i++)
            {
                if (id.Equals(addrList[i].Id))
                    stNeedToUpdate = addrList[i];
            }
            if (stNeedToUpdate == null)
                return;

            stNeedToUpdate.Name = name;
            stNeedToUpdate.Tel = tel;
            stNeedToUpdate.Address = address;
            stNeedToUpdate.Email = email;
        }

        public static Student getRandStudentAddr()
        {
            return new RandomData().getRandomStudentInfo();
        }

        public bool hasStAddr()
        {
            if (addrList.Count == 0)
                return false;
            return true;
        }

        public void showAddrListByUsingMBox()
        {
            foreach (var item in addrList)
                System.Windows.Forms.MessageBox.Show(item.getStringStudentInfo());
        }

    }
}
