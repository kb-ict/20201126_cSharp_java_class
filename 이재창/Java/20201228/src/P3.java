import java.util.Scanner;

public class P3 {

	public static void main(String[] args) {
		int[] arr = new int[10];
		Scanner s = new Scanner(System.in);
        int a = s.nextInt();
        int b = s.nextInt();
        int c = s.nextInt();

        int d = a * b * c;
        int result = d;

        while (d > 0)
        {
            arr[d % 10]++;
            d /= 10;
        }

        System.out.println("계산결과" + result + " 에는 ");
        for (int i = 0; i < 10; i++)
        {
            if (arr[i] > 0)
            	System.out.printf("%d이 %d번 ", i, arr[i]);
        } 

	}

}
