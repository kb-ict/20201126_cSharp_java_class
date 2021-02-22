
public class Ex2 {

	public static void main(String[] args) {
		int [] arr = new int[100];
		for (int i = 0; i < arr.length; i++) {
			arr[i]=i+1;
		}
		for (int i = 0; i < arr.length; i++) {
			if(i==89) {
				break;
			}
			if(arr[i]%5==0) {
				System.out.print(arr[i]+" ");
			}
		}
	}

}
