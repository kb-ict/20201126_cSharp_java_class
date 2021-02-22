package collect0127;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.Iterator;
import java.util.LinkedList;
import java.util.Queue;
import java.util.Stack;

public class CollectMain {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		System.out.println("배열");
		String strArr[] = new String[3];
		strArr[0] = "홍길동";
		strArr[1] = "김길동";
		strArr[2] = "박길동";
		
		for (var str : strArr) {
			System.out.println(str);
		}
		
		System.out.println("####### ArrayList #######");
		ArrayList<String> list = new ArrayList<>();
		list.add("홍길동");
		list.add("김길동");
		list.add("박길동");
		
		System.out.println("####### Stack #######");
		Stack<String> st = new Stack<>();
		st.push("홍길동");
		st.push("김길동");
		st.push("박길동");
		
		while (!st.isEmpty()) {
			System.out.println(st.pop());
		}
		
		System.out.println("####### Queue #######");
		Queue<String> qu = new LinkedList<>();
//		Queue<Stirng> qu = new Queue<>();
		qu.add("홍길동");
		qu.add("김길동");
		qu.add("박길동");
		
		while (qu.isEmpty() == false) {
			System.out.println(qu.poll());
		}
		
		System.out.println("####### HashMap #######");
		//키와 값으로 관리 되는 자료구조
		HashMap<Integer, String> map = new HashMap<>();
		map.put(1, "홍길동");
		map.put(2, "김길동");
		map.put(3, "박길동");
		
		//해쉬테이블 위치 정보
		Iterator<Integer> keySetIt = map.keySet().iterator();
		while (keySetIt.hasNext()) {
			Integer key = keySetIt.next();
			System.out.printf("key=%d, 값=%s\n", key, map.get(key));
		}
	}

}
