import java.util.Random;
import java.util.Scanner;

public class Problem1 {

	public static void main(String[] args) {
		//숫자 N개 입력받아서
		//그 중에서 가장 큰 수랑 작은 수 출력
		System.out.println("1번 문제");
		Scanner sc = new Scanner(System.in);
		
		System.out.println("총 몇 개의 숫자를 받을래?");
		int cntNum=sc.nextInt();
		
		System.out.println("이제 숫자를 입력하시오.");
		int []numList=new int[cntNum];
		
		for (int i = 0; i < cntNum; i++) {
			numList[i]=sc.nextInt();
		}
		//최대 최소 비교
		//첫번째 방법
		int max = numList[0];
		int min = numList[0];

		for (int i = 0; i < numList.length; i++) {
			if (numList[i]>max) {
				max=numList[i];}
			if (numList[i]<min) {
				min=numList[i];
			}		
		}
		System.out.println("최솟값 : "+min);
		System.out.println("최댓값 : "+max);
	}

}
