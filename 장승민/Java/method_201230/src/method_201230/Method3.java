package method_201230;

public class Method3 {


	static int num = 200;	//전역 변수
	public static void func() {
		int num = 100;		//지역 변수
		System.out.println("num : "+ num);
	}

	public static void main(String[] args) {
		System.out.println("num : "+ num );
		func();

	}

}
