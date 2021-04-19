import java.util.Scanner;

public class Problem4 {

	public static void main(String[] args) {
		Scanner aa = new Scanner(System.in);
		int [] Q = new int[5];
        int [] Ans = new int[5];
        for (int i = 0; i < Q.length; i++)
        {
            int y = aa.nextInt();
            Q[i] = y;
        }
        Ans[0] = 1;
        Ans[1] = 66;
        Ans[2] = 22;
        Ans[3] = 14;
        Ans[4] = 28;
        int score = 0;
        for (int i = 0; i < 5; i++)
        {
            if (Q[i] == Ans[i])
            {
                System.out.print("O");
                if(Q[i] == Q[0] || Q[i] == Q[4])
                {
                    score = score + 10;
                }
                else
                {
                    score += 20;
                }
            }
            else
            {
            	System.out.print("X");
                continue;
            }
        }
        System.out.println("");
        System.out.print("총점: " + score);

	}

}
