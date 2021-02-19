import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;
public class Main {
	public static void main(String[] args) throws NumberFormatException, IOException {
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		BufferedWriter bw = new BufferedWriter(new OutputStreamWriter(System.out));
		int arr[] = new int[Integer.parseInt(br.readLine())];
		for (int i = 0; i < arr.length; i++) {
			arr[i] = Integer.parseInt(br.readLine());
		}
		br.close();
		for (int i = 0; i < arr.length; i++) {
			for (int j = i; j < arr.length; j++) {
				int copy = arr[i];
				if(arr[i] > arr[j]) {
					arr[i] = arr[j];
					arr[j] = copy;
				}
			}
		}
		for (int i = 0; i < arr.length; i++) {
			bw.write(Integer.toString(arr[i]));
			bw.newLine();
		}
		bw.flush();
		bw.close();
	}
}
