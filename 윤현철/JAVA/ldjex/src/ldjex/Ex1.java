package ldjex;

public class Ex1 {

	public static void main(String[] args) {
		 int sum = 0;
         for (int i = 0; i < 100; i++)
         {
             if ((i + 1) % 3 == 0)
             {
                 sum = sum + (i + 1);
             }
         }
         System.out.println(sum);

	}

}
