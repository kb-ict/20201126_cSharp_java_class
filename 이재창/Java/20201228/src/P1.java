import java.util.Scanner;

public class P1 {

	public static void main(String[] args) {
		int[] arr;
        int min = 0, max = 0, minIdx = 0, maxIdx = 0;
        Scanner s = new Scanner(System.in);
        int n = s.nextInt();
        arr = new int[n];        

        for (int i = 0; i < n; i++)
        {
            arr[i] = s.nextInt();
            if (i == 0)
            {
                min = arr[i];
                max = arr[i];
            }

            if (min > arr[i])
            {
                min = arr[i];
                minIdx = i;
            }
            if (max < arr[i])
            {
                max = arr[i];
                maxIdx = i;
            }
        }
        System.out.printf("ÃÖ´ñ°ª = %d %d¹øÂ°, ÃÖ¼Ú°ª = %d %d¹øÂ°", max, maxIdx, min, minIdx);
        s.close();
	}

}
