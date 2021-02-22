package com.j.carApp;

import java.util.Random;
import com.j.carApp.customer.Customer;

public class CarAppMain {

	public static void main(String[] args) {
		String name[] = {"ȫ�浿", "��浿", "�ڱ浿", "�̱浿", "�ֱ浿"};
		String tel[] = {"010-1234-5678", "010-4321-5678", "010-3478-1278",
				"010-4523-1978", "010-7890-2134"};
		String address[] = {"�뱸�� ���� �ž�4��", "����� ���� �ž�4��",
				"�λ�� ���� �ž�4��", "��õ�� ���� �ž�4��", "���ֽ� ���� �ž�4��"};
		String model[] = {"SM6", "�Ÿ", "��Ÿ��", "K7", "�׷���"};
		String color[] = {"��", "����", "���", "ȸ��", "����"};
		int year[] = {2016, 2017, 2016, 2017, 2016};
		String company[] = {"�Ｚ����", "����", "����", "���", "����"};
		
		Customer customer[] = new Customer[10];
		Random rand = new Random();
		
		for (int i = 0; i < customer.length; i++) {
			String _name = name[rand.nextInt(5)];
			String _tel = tel[rand.nextInt(5)];
			String _address = address[rand.nextInt(5)];
			String _model = model[rand.nextInt(5)];
			String _color = color[rand.nextInt(5)];
			int _year = year[rand.nextInt(5)];
			String _company = company[rand.nextInt(5)];
			customer[i] = new Customer(_name, _tel, _address,
					_model, _color, _year, _company);
		}
		
		for (var c : customer) {
			c.printCustomerInfo();
		}
		
		System.out.println("---------------------------");
		
		
	}
	
}
