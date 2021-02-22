using System;

namespace Class_practice_20210218.view
{
    class Messages
    {
        public void noInfo()
        {
            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine("주소록 정보가 없습니다.");
        }

        public void wrongInput()
        {
            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine("잘못 입력하였습니다.");
        }

        public static void exitMessage()
        {
            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine("프로그램 종료");
        }
    }
}
