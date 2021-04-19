import java.util.ArrayList;
import java.util.HashMap;
import java.util.Iterator;
import java.util.LinkedList;
import java.util.Queue;
import java.util.Stack;

public class CollectMain {

	public static void main(String[] args) {
		System.out.println("배열");
		String strArr[] = new String[3];
		strArr[0] = "홍길동";
		strArr[1] = "고길동";
		strArr[2] = "박길동";

		// 향상된 for문
		for (String str : strArr) {
			System.out.println(str);
		}

		System.out.println("##### ArrayList #####");
		ArrayList<String> list = new ArrayList<>();
		list.add("홍길동");
		list.add("고길동");
		list.add("박길동");

		for (int i = 0; i < list.size(); i++) {
			System.out.println(list.get(i));
		}

		System.out.println("##### stack #####");
		// LIFO (Last In First Out) 마지막에 들어온 놈이 제일 처음엔 나가는 개념
		// push: 데이터 추가
		// pop: 데이터 가져오기
		Stack<String> st = new Stack<>();
		st.push("홍길동");
		st.push("고길동");
		st.push("박길동");

		// Stack이 빌 때까지 계속 반복함
		while (!st.isEmpty()) {
			System.out.println(st.pop());
		}

		System.out.println("##### Queue #####");
		// FIFO (Fist In First Out) 처음에 들어간 놈이 제일 처음에 나가는 개념
		Queue<String> qu = new LinkedList<>();
		qu.add("홍길동");
		qu.add("고길동");
		qu.add("박길동");

		while (qu.isEmpty() == false) {
			System.out.println(qu.poll());
		}
		
		System.out.println("##### HashMap #####");
		//키-값으로 관리 되는 자료구조
		HashMap<Integer, String> map = new HashMap<Integer, String>(); 
		//new 뒤에는 타입 안넣어주고 <>만 넣어줘도 OK
		
		map.put(1, "홍길동");
		map.put(2, "고길동");
		map.put(3, "박길동");
		
		// 해시테이블 위치 정보
		Iterator<Integer> keySetIt = map.keySet().iterator();
		while (keySetIt.hasNext()) {
			Integer key = keySetIt.next();
			System.out.printf("key=%d, 값=%s\n", key, map.get(key));
		}
	}

}
