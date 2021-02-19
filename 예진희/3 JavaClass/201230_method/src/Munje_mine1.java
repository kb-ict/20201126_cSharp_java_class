
import java.util.Arrays;
import java.util.Scanner;

//패키지 없다.

public class Munje_mine1 {
	/*
	 * 1. 3개의 숫자를 입력받아서 크기가 큰 순서대로 출력하는 프로그램.
	 * 조건1) 3개의 숫자는 main() 에서 입력 받음.
	 * 조건1) 3개의 입력받은 숫자를 매개변수로 전달하여 크기가 큰 순서대로 출력하는 메쏘드를 작성.
	 * 조건2) 5, 20, 15를 입력받으면, 20-15-5 형식으로 출력하기.
	*/
	public static void bigyo (int arr[]) {
		System.out.println("-----------------------");
		for (int i = (arr.length-1); i >= 0; i--) {
			Arrays.sort(arr);
			System.out.print(arr[i]+"  ");
		}
		
	}
	
	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		int[]arr = new int[3]; //값 입력 받을 1차원 배열 생성
		
		
		System.out.println("문제1번\n-----------------------");
		//배열 길이만큼 값을 입력받음 3이면 > 0, 1, 2
		for (int i = 0; i < arr.length; i++) { 
			System.out.print((i+1)+"번째 수를 입력하세요 => ");
			arr[i] = s.nextInt();
		}
		s.close();
		//다른 메소드를 호출하여 arr값을 던진다.
		bigyo(arr);
	}

}
