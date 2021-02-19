package beak;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;
import java.util.Arrays;

public class Beak11728 {

	public static void main(String[] args) throws NumberFormatException, IOException {
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		BufferedWriter bw = new BufferedWriter(new OutputStreamWriter(System.out));
		// 배열의 사이즈 N X M
		String[] strs = br.readLine().split(" ");
        long N = Integer.parseInt(strs[0]);
        long M = Integer.parseInt(strs[1]);
		
		// 사이즈가 N인 배열의 값 입력하기
        long [] arr1 = new long[(int) N];
		for (int i = 0; i < arr1.length; i++) {
			arr1[i]=Integer.parseInt(br.readLine());
		}
		// 사이즈가 M인 배열의 값 입력하기
		long [] arr2 = new long[(int) M];
		for (int i = 0; i < arr2.length; i++) {
			arr2[i]=Integer.parseInt(br.readLine());
		}
		br.close();
		
		long [] total = new long[(int) (N+M)];
		
		for (int i = 0; i < total.length-M; i++) {
			total[i]=arr1[i];
			for (int j = (int) N; j < total.length; j++) {
				total[j]=arr2[(int) (j-N)];
			}
		}
		Arrays.sort(total);
		
		for (int i = 0; i < total.length; i++) {
			bw.write(String.valueOf(total[i])+" ");
		}
		bw.close();
	}

	

}
