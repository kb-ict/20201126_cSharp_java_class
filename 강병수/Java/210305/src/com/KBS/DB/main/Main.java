package com.KBS.DB.main;
import java.util.Scanner;

import com.KBS.DB.control.Control;
import com.KBS.DB.menu.Menu;
import com.KBS.DB.menu.RandData;

public class Main {

	static Scanner sc = new Scanner(System.in);

	public static void main(String[] args) {
		Control ct = new Control();
		Menu me = new Menu();
		
		ct.connectDB();
		while (true) {
			switch (me.mainMenu(sc)) {
			case Menu.TABLE_CREATE:
				ct.createTable();
				break;
			case Menu.TABLE_DELETE:
				ct.deleteTable();
				break;
			case Menu.DATA_CREATE:
				ct.createData(me.addMenu(sc));
				break;
			case Menu.SAMPLE_DATA:
				RandData data = new RandData();
				for(int i = 0; i<100; i++)
				{
				ct.createData(data.getABook());
				}
				break;
			case Menu.DATA_READ:
				ct.readData();
				break;
			case Menu.DATA_MODIFY:
				ct.modifyData();
				break;
			case Menu.DATA_DELETE:
				ct.deleteData();
				break;
			case Menu.PROGRAM_EXIT:
				sc.close();
				ct.closeDB();
				System.exit(0);
				break;
			}
		}
	}
}
