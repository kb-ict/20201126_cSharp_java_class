import java.util.Scanner;

class P7 {
     public static void main(String[] args) {
    	 Scanner s = new Scanner(System.in);
    	 int month = s.nextInt();
    	 String season = null;
    	 
    	 switch (month) {
    	 case 12:
    	 case 1:
    	 case 2:
    		 season = "�ܿ�";
    		 break;
    	 case 3:
    	 case 4:
    	 case 5:
    		 season = "��";
    		 break;
    	 case 6:
    	 case 7:
    	 case 8:
    		 season = "����";
    		 break;
    	 case 9:
    	 case 10:
    	 case 11:
    		 season = "����";
    		 break;
    	 default:
			 season = "���� ��... �Դϴ�...";
			 break;
    	 }
    	 System.out.println(season);
     }    
}
