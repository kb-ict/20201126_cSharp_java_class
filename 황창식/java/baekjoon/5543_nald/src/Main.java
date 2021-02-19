import java.util.Scanner;
public class Main {
	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		int burger[] = new int[3];
		int drink[] = new int[2];
		for (int i = 0; i < burger.length; i++) {
			burger[i] = s.nextInt();
		}
		for (int i = 0; i < drink.length; i++) {
			drink[i] = s.nextInt();
		}
		int result = burger[0] + drink[0] - 50;
		for (int i = 0; i < burger.length; i++) {
			for (int j = 0; j < drink.length; j++) {
				int price = burger[i] + drink[j] - 50;
				if(price < result) {
					result = price;
				}
			}
		}
		System.out.println(result);
	}

}
