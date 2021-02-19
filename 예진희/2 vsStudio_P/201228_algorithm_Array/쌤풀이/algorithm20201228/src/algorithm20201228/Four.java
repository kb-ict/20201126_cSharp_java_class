package algorithm20201228;

import java.util.Scanner;

public class Four {

	public static void main(String[] args) {

        int[] answer = new int[] { 5, 4, 1, 2, 3 };
        String[] que = new String[] { "다음 중 사람인 것은?", "1+1은?", "2+2는?", "3+3은?", "4+4는?" };
        
        String[] bogi = new String[] { "1. 강아지 2.원숭이 3. 고양이 4. 햄스터 5. 이동준",
                                        "1. [4] 2. [6] 3.[8] 4. [2] 5. [100]",
                                        "1. [4] 2. [6] 3.[8] 4. [2] 5. [100]",
                                        "1. [4] 2. [6] 3.[8] 4. [2] 5. [100]",
                                        "1. [4] 2. [6] 3.[8] 4. [2] 5. [100]"};
        String queResult = "";
        int totalPoint = 0;
        Scanner s = new Scanner(System.in);
        for (int i = 0; i < 5; i++)
        {
            System.out.println(que[i]);
            System.out.println(bogi[i]);
            System.out.println("정답은?");
            int ans = s.nextInt();

            if (answer[i] == ans)
            {
                queResult += "O";
                if (i == 0 || i == 4)
                    totalPoint += 10;
                else if (i == 1)
                    totalPoint += 20;
                else
                    totalPoint += 30;
            }
            else
            {
                queResult += "X";
            }
        }

        System.out.println("결과는 " + queResult + "이고, " + "총 점은 " + totalPoint + "입니다.");
	}

}
