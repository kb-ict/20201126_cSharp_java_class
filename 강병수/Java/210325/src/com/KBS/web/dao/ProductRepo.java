package com.KBS.web.dao;

import java.util.ArrayList;

import com.KBS.web.dto.Product;

public class ProductRepo {
	private ArrayList<Product> listofProducts =
			new ArrayList<Product>();
	
	public ProductRepo() {
		Product iphone = 
				new Product("P1111", "iPhone12", 1000000);
		iphone.setDescription("6인치, 1334x750 Retina HD Display, " + "8-megapixel Camera");
		iphone.setCategory("스마트폰");
		iphone.setManufacturer("Apple");
		iphone.setUnitInStock(1000);
		iphone.setCondition("2020 신상품");
		listofProducts.add(iphone);
		
		Product notebook = 
				new Product("P1112", "LG 그램2021", 2500000);
		notebook.setDescription("15인치, 1920x1080 OLED HD Display, " + "인텔 i7 11세대, 메모리 DDR4");
		notebook.setCategory("노트북");
		notebook.setManufacturer("LG");
		notebook.setUnitInStock(500);
		notebook.setCondition("2021 신상품");
		listofProducts.add(notebook);
		
		Product tablet = 
				new Product("P3111", "삼성 갤럭시탭 S7", 400000);
		tablet.setDescription("10인치, 2000x1550 OLED HD Display, " + "메모리 128GB");
		tablet.setCategory("태블릿 PC");
		tablet.setManufacturer("삼성");
		tablet.setUnitInStock(1500);
		tablet.setCondition("2020 신상품");
		listofProducts.add(tablet);
	}
	
	public ArrayList<Product> getAllProduct() {
		return listofProducts;
	}
	
	public Product getProductById(String productId) {
		Product productById = null;
		for(int i=0; i<listofProducts.size(); i++) {
			Product product = listofProducts.get(i);
			if (product != null && product.getProductId() != null
					&& product.getProductId().equals(productId)) {
				productById = product;
				break;
			}
		}
		return productById;
	}
}