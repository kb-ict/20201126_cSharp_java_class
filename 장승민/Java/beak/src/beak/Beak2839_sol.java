package beak;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Scanner;

public class Beak2839_sol {

    public static void main(String args[]) throws NumberFormatException, IOException{
        int input = 0; 
        int count = 0;
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        input = Integer.parseInt(br.readLine());

        
        while(true) {
            if (input % 5 ==0) {
                System.out.println(input/5 + count);
                break;
            }else if(input <= 0) {
                System.out.println(-1);
                break;
            }
            input = input-3;
            count++;
        }
    }


}
