package beak;


import java.util.Scanner;

public class Beak1546_2 {

	public static void main(String[] args)  {
		Scanner sc = new Scanner(System.in);

		int num = sc.nextInt();
		double[] sub = new double[num];
		double max =0;
		double sum=0.0;
		double avg=0.0;

		for (int i = 0; i < num; i++) {
			sub[i]=sc.nextDouble();
			if (max<sub[i]) {
				max=sub[i];
			}
			sum+=sub[i];
		}
		avg = sum/max*100/num;
		System.out.println(String.format("%.2f",avg));
	}

}
