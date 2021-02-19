package kb511;

import java.util.Scanner;

public class sample5 {
	  public static void main(String[] args) {
		    // TODO Auto-generated method stub
		    Scanner sInput = new Scanner(System.in);
		    String input = sInput.nextLine();
		    int[] alphabet = new int[26];
		    for(int i = 0; i<input.length(); i++)
		    {
		      int index = input.charAt(i) - (int)'a';
		      alphabet[index]++;
		    }
		    for(int i=0;i<26;i++)
		    {
		      if(alphabet[i]!=0)
		      {
		        String sentense = "'"+(char)(i+97)+"'"+"는 "+alphabet[i]+"글자입니다.";
		        System.out.println(sentense);
		      }
		    }
		  }

}
