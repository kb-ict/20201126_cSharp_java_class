package algorithm20201228;

import java.util.Scanner;

public class Five {

	public static void main(String[] args) {

        System.out.println("5번 문제");
        String queResult = "";
        System.out.println("문제 개수는?");
        Scanner s = new Scanner(System.in);
        int countQue = s.nextInt();
        String[] queList = new String[countQue];
        String[] answerList = new String[countQue];
        
        s.nextLine(); //버퍼 청소

        for (int i = 0; i < countQue; i++)
        {
            System.out.printf("%d번째 문제를 적어주세요.\n", i+1);
            queList[i] = s.nextLine();
            System.out.println("객관식 문제입니까?(Y 혹은 Yes로 입력시에만 객관식)");
            String yesOrNo = s.nextLine();
            if(yesOrNo.toUpperCase().contains("Y"))
            {
            	System.out.println("보기도 같이 적어주세요. 보기는 3개입니다.");
                for (int j = 0; j < 3; j++)
                {
                	System.out.printf("%d번\n", j+1);
                    String selector = s.nextLine();
                    queList[i] += "\n" + (j+1) + "번 " + selector;
                }
                System.out.printf("%d번째 문제의 정답을 적어주세요.\n",i + 1);
                answerList[i] = s.nextLine();
                while (Integer.parseInt(answerList[i]) < 1 || Integer.parseInt(answerList[i]) > 3)
                {
                    System.out.println("보기는 1번부터 3번까지입니다. 다시 적어주세요.");
                    answerList[i] = s.nextLine();
                }
            }
            else
            {
                System.out.printf("%d번째 문제의 정답을 적어주세요.\n",i + 1);
                answerList[i] = s.nextLine();
            }
        }

        for (int i = 0; i < 100; i++)
        {
            System.out.println();
        }

        do
        {
        	System.out.println("이제부터 문제 풀겁니다.");
            for (int i = 0; i < countQue; i++)
            {
            	System.out.println(queList[i]);
            	System.out.println("정답은?");
                String ans = s.nextLine();

                if (answerList[i].equals(ans)) //java는 String 비교시 equals만 쓰기
                {
                    queResult += "O";
                }
                else
                {
                    queResult += "X";
                }
            }
            System.out.println(queResult);

            String resultO = "맞은 문제는\n";
            String resultX = "틀린 문제는\n";
            int correctCount = 0;
            for (int i = 0; i < queResult.length(); i++)
            {
                if(queResult.charAt(i) == 'O')
                {
                    resultO += String.format("%d번 문제\n", i+1);
                    correctCount++;
                }
                else
                {
                    resultX += String.format("%d번 문제\n", i+1);
                }

            }
            if (correctCount == 0)
                resultO = "맞은 문제는 없습니다.";
            else if(correctCount == countQue)
                resultX = "틀린 문제는 없습니다.";

            System.out.println("총 " + correctCount + "개 맞췃습니다.");
            System.out.println(resultO);
            System.out.println(resultX);
            queResult = "";
        } while (true);

	}

}
