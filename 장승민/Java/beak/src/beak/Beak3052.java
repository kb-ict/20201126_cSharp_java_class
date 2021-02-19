package beak;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.IOException;
import java.io.InputStreamReader;
import java.nio.Buffer;
import java.util.Scanner;

public class Beak3052 {

	public static void main(String[] args) throws IOException {
		
		BufferedReader br =new BufferedReader(new InputStreamReader(System.in));
		int num[]=new int[10];	//10개의 숫자값을 넣을 배열 생성
		int cnt =0;
		int result =0;

		for (int i = 0; i < num.length; i++) {
			num[i]=Integer.parseInt(br.readLine())%42;//num 배열의 각 인덱스에 입력값 삽입
		}
		br.close();

		for (int i = 0; i < 10; i++) {
			cnt =0;
			for (int j = i+1; j < 10; j++) {
				if (num[i]==num[j]) {
					cnt++;
				}
			}
			if (cnt==0) {
				result++;
			}
		}
		System.out.println(result);



	}

}
