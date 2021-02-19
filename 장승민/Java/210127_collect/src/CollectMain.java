import java.util.ArrayList;
import java.util.HashMap;
import java.util.Iterator;
import java.util.LinkedList;
import java.util.Queue;
import java.util.Stack;

public class CollectMain {

	public static void main(String[] args) {
//		System.out.println("배열");
//		String strArr[] = new String[3];
//		strArr[0] = "홍길동";
//		strArr[1] = "김길동";
//		strArr[2] = "박길동";
//
////		향상된 for 문
//		for (String abc : strArr) {
//			System.out.println(abc);
//		}
//		for (int i = 0; i < strArr.length; i++) {
//			System.out.println(strArr[i]);
//		}
//		System.out.println("배열");
//		int intArr[] = new int[3];
//		intArr[0] = 1;
//		intArr[1] = 2;
//		intArr[2] = 3;
//
////		향상된 for 문
//		for (int arr : intArr) {
//			System.out.println(arr);
//		}
////		일반 for 문
//		for (int i = 0; i < intArr.length; i++) {
//			System.out.println(intArr[i]);
//		}

//		System.out.println("##### ArrayList #####");
////		< >나오면 제네릭 클래스
//		ArrayList<String> list = new ArrayList<>();
//		list.add("홍길동");
//		list.add("김길동");	
//		list.add("박길동");
//
//		for (String string : list) {
//			System.out.println(string);
//		}	
//		
//		for (int i = 0; i < list.size(); i++) {
//			System.out.println(list.get(i));
//		}	

//		System.out.println("##### stack #####");
////		LIFO(Last In First Out)
////		push : 데이터 추가
////		pop : 데이터 가져오기
//		Stack<String> st = new Stack<>();
//		st.push("홍길동");
//		st.push("김길동");
//		st.push("박길동");
//
//		while (!st.isEmpty()) {
//			System.out.println(st.pop());
//		}

//		System.out.println("##### Queue #####");
//		Queue<String> qu = new LinkedList<>();
//		qu.add("홍길동");
//		qu.add("김길동");
//		qu.add("박길동");
//
//		while (qu.isEmpty() == false) {
//			System.out.println(qu.poll());
//		}

		System.out.println("##### HashMap #####");
//		키-값(key-value)으로 관리되는 자료구조
		HashMap<Integer, String> map = new HashMap<>();
		map.put(1, "홍길동");
		map.put(2, "김길동");
		map.put(3, "박길동");
		
		Iterator<Integer> keySetIt = map.keySet().iterator();
		
		while(keySetIt.hasNext()) {
			Integer key = keySetIt.next();
			System.out.printf("key = %d, 값 = %s\n",key, map.get(key));
		}
		
		HashMap<String, String> map2 = new HashMap<>();
		map2.put("hi", "홍길동");
		map2.put("sex", "이윤구");
		map2.put("bye", "박길동");
		
		Iterator<String> keySetIt2 = map2.keySet().iterator();
		
		while(keySetIt2.hasNext()) {
			String key = keySetIt2.next();
			System.out.printf("key = %s, 값 = %s\n",key, map2.get(key));
		}
		
	}

}
