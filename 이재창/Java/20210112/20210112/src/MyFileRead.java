import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;
import java.util.StringTokenizer;

public class MyFileRead {
	public void readShow() {
		String path = "name.txt";
		String txt = null;
		ArrayList<String> names = new ArrayList<>();
		
		try {
			BufferedReader br = new BufferedReader(new FileReader(path));
			txt = br.readLine();
			br.close();
		} catch (FileNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();	
		} catch (IOException e) {
			e.printStackTrace();
		}
		
		StringTokenizer st = new StringTokenizer(txt, "/");
		while (st.hasMoreTokens()) {
			names.add(st.nextToken());
		}
		
		for (int i = 0; i < names.size(); i++) {
			System.out.print(names.get(i) + " ");
		}
	}
}
