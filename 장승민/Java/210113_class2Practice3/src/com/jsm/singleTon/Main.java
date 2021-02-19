package com.jsm.singleTon;

public class Main {

	public static void main(String[] args) {
		SingleTest st1 = new SingleTest();
		SingleTest st2 = new SingleTest();
		System.out.println(st1.getData());
		System.out.println(st2.getData());
		System.out.println(SingleTest.getInstance().getData());
		System.out.println(SingleTest.getInstance().getData());
		System.out.println(SingleTest.getInstance().getData());
		System.out.println(SingleTest.getInstance().getData());
		System.out.println(SingleTest.getInstance().getData());
	}

}
 class SingleTest{
	 private static SingleTest inst;
	 private int data;
	 
	 SingleTest(){
		 data = (int)(Math.random()*100);
	 }
	 public static SingleTest getInstance() {
		 if(inst == null) {
			 inst = new SingleTest();
		 }
		 return inst;
	 }
	 public int getData() {
		 return data;
	 }
 }