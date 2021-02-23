import java.util.Scanner;

public class Problem3 {

	public static void main(String[] args) {
        Scanner cs = new Scanner(System.in);
		int A, B, C;
        int [] k = new int[10];
        A = cs.nextInt();
        B = cs.nextInt();
        C = cs.nextInt();
        int sum = A * B * C;
        while (sum > 0)
        {
            k[sum % 10]++;
            sum = sum / 10;
        }
        for (int i = 0; i < k.length; i++)
        {
        	System.out.println(i + "의 개수: " + k[i]);
        }

	}

}
