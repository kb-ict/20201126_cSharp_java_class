namespace Class_practice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[] arr = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            SumAve result = new SumAve(arr);

            SumAve result2 = new SumAve();
            result2.getSumAve(arr);

            SumAve result3 = new SumAve();
            result3.Arr = arr;
            result3.getSumAve();

            new SumAve(arr);*/

            int[,] arr = new int[5, 3]
            {
                {100, 90, 80 },
                {90, 80, 70 },
                {80, 70, 60 },
                {70, 60, 50 },
                {50, 40, 30 }
            };

            // 배열 첫번째 열에 대한 인스턴스 생성
            /*StudentScore st = new StudentScore(arr[0, 0], arr[0, 1], arr[0, 2]);
            st.calculator();*/

            /*// 인스턴스 저장없이 바로 생성후 출력
            for (int i = 0; i < 5; i++)
            {
                new StudentScore(arr[i, 0], arr[i, 1], arr[i, 2]).calculator();
            }*/

            // 인스턴스 5개를 미리 만들어 둔 뒤 출력
            StudentScore[] arrSt = new StudentScore[5];
            for (int i = 0; i < arrSt.Length; i++)
            {
                arrSt[i] = new StudentScore();
                /*for (int j = 0; j < 3; j++)
                {
                    arrSt[i].setAllPorperty(arr[i, 0], arr[i, 1], arr[i, 2]);
                }*/
                arrSt[i].setAllPorperty(arr[i, 0], arr[i, 1], arr[i, 2]);
                arrSt[i].calculator();
            }
        }
    }
}
