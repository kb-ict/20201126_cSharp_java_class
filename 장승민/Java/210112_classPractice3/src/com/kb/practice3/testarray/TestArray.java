package com.kb.practice3.testarray;

public class TestArray {

	private int sum;
	private double avg;

	public int sum(int[] arr) {

		for (int i = 0; i < arr.length; i++) {
			sum += arr[i];
		}
		return sum;
	}

	public double avg(int[] arr) {

		avg = (double)sum/arr.length;
		return avg;
	}

	public TestArray(int[]arr) {
		System.out.println(sum(arr));
		System.out.println(avg(arr));
	}

}
