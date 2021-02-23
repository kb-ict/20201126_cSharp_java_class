import java.util.Scanner;
import java.util.Arrays;
public class Problem1_2 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		System.out.println("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
		System.out.println("1번 문제");
		System.out.print("숫자 입력: ");
		int N = sc.nextInt();
		int[] ab = new int[N];
		for (int i = 0; i < ab.length; i++)
        {
            int x = sc.nextInt();
            ab[i] = x;
        }
        int[] xy = new int[N];
        for (int i = 0; i < xy.length; i++)
        {
            xy[i] = ab[i];
        }
        Arrays.sort(ab);
        System.out.println("최소값" + ab[0]);
        System.out.println("최대값" + ab[N-1]);
		System.out.println("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
		System.out.println("2번 문제");
		for (int i = 0; i < xy.length; i++)
        {
            if (ab[0] == xy[i]) {
            	System.out.println("최소값의 위치: " + (i+1) + "번째");
            }
            if (ab[N-1] == xy[i]) {
            	System.out.println("최대값의 위치: " + (i+1) + "번째");
            }
        }
	}

}
