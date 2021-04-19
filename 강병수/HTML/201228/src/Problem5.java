import java.util.Scanner;

public class Problem5 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
        System.out.print("문제의 개수 입력: ");
        int M = sc.nextInt();
        int score2 = 0;
        int[] K = new int[M]; //문제 입력
        int[] D = new int[M]; //정답 입력
        int[] E = new int[M]; //풀이 입력
        for (int i = 0; i < K.length; i++)
        {
            int z = sc.nextInt();
            K[i] = z;
        }
        for (int i = 0; i < D.length; i++)
        {
            int j = sc.nextInt();
            D[i] = j;
        }
System.out.println("");
System.out.println("");
System.out.println("");
System.out.println("");
System.out.println("");
System.out.println("");
System.out.println("");
System.out.println("");
System.out.println("");
System.out.println("");
System.out.println("");
System.out.println("");
System.out.println("");
System.out.println("");
System.out.println("");
System.out.println("");
System.out.println("");
System.out.println("");
System.out.println("");
System.out.println("");
System.out.println("");
System.out.println("");
System.out.println("");
System.out.println("");
System.out.println("");
System.out.println("");
System.out.println("");
System.out.println("");
System.out.println("");
System.out.println("");
System.out.println("");
System.out.println("");
System.out.println("");
System.out.println("");
System.out.println("");
System.out.println("");
System.out.println("");
System.out.println("");
System.out.println("");
System.out.println("");
System.out.println("");
System.out.println("");
        for (int i = 0; i < K.length; i++)
        {
            int F = sc.nextInt();
            E[i] = F;
        }
        for (int i = 0; i < K.length; i++)
            {
                if (E[i] == D[i])
                {
                    System.out.print("O");
                        score2 += 1;
                }
                else
                {
                	System.out.print("X");
                    continue;
                }
            }

        System.out.println("총점: " + score2);

	}

}
