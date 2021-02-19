package collect_20210127;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.Iterator;
import java.util.LinkedList;
import java.util.Queue;
import java.util.Stack;

public class CollectMain {
	public static void main(String[] args) {
		System.out.println("##### Array #####");
		String strArr[] = new String[3];
		strArr[0] = "홍길동";
		strArr[1] = "김길동";
		strArr[2] = "박길동";
		
//		for (int i = 0; i < strArr.length; i++) {
//			System.out.println(strArr[i]);
//		}
		for (String str : strArr) {
			System.out.println(str);
		}
		
		System.out.println("##### ArrayList #####");
		ArrayList<String> strList = new ArrayList<>();
		strList.add("홍길동");
		strList.add("김길동");
		strList.add("박길동");
		strList.add(1, "최길동");
		strList.remove(1);
		for (int i = 0; i < strList.size(); i++) {
			System.out.println(strList.get(i));
		}
		
		System.out.println("##### Stack #####");
		// LIFO (Last In First Out) => 바구니 형식
		Stack<String> strStack = new Stack<>();
		// push : 데이터 추가
		// pop : 데이터 가져오기
		strStack.push("홍길동");
		strStack.push("김길동");
		strStack.push("박길동");
		
		// stack이 비어있을때까지
		while(!strStack.isEmpty()) {
			System.out.println(strStack.pop());
		}
		
		System.out.println("##### Queue #####");
		// FIFO (First In First Out)
		Queue<String> strQu = new LinkedList<String>();
		strQu.add("홍길동");
		strQu.add("김길동");
		strQu.add("박길동");
		
		while(!strQu.isEmpty()) {
			System.out.println(strQu.poll());
		}
		
		System.out.println("##### HashMap #####");
		// 키 값으로 관리되는 자료구조
		HashMap<Integer, String> map = new HashMap<>();
		map.put(1, "홍길동");
		map.put(2, "김길동");
		map.put(3, "박길동");
		
		// 해쉬테이블 위치 정보
		Iterator<Integer> keySetIt = map.keySet().iterator();
		while(keySetIt.hasNext()) {
			Integer key = keySetIt.next();
			System.out.printf("key=%d, 값=%s\n", key, map.get(key));
		}
	}
}
