package collect0127;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.Iterator;
import java.util.LinkedList;
import java.util.Queue;
import java.util.Stack;
//import java.util.*; = 다 땡기는거, 리소스.. 낭비..

public class CollectMain {

	public static void main(String[] args) {
		// 제네릭 클래스 : 모든 타입을 사용 가능
		// 컬렉션 클래스 : 자료구조 (db의 엔진 쪽)

		// (+) 사이즈 지정 후 사용해서 빠름
		// (-) 인덱스 조정 시 불편,
		System.out.println("0. 배열\n------------------");

		// 스트링 클래스 빈배열
		String strArr[] = new String[3];
		strArr[0] = "홍길동";
		strArr[1] = "김길동";
		strArr[2] = "박길동";

		System.out.println("향상된 for문\n------------------");
		for (String str : strArr) {
			System.out.println(str);
		}
		System.out.println();
		for (int i = 0; i < strArr.length; i++) {
			System.out.println(strArr[i]);
		}

		System.out.println("\n1. ArrayList (많이 씀)\n------------------");
		ArrayList<String> list = new ArrayList<>();
		// < > = 제네릭 클래스(모든타입 다 사용가능), int, String, char...
		// String넣어도 되고 생략가능

		list.add("홍길동");
		list.add("김길동");
		list.add("박길동");
		// ㅇ- data1 - data2-2...
		// \ ↑ /
		// data2-1

		for (int i = 0; i < list.size(); i++) {
			System.out.println(list.get(i));
		}

		// 자료구조 , > 편하게 > Collection
		System.out.println("\n2. stack \n------------------");
		// LIFO (Last In First Out) 마지막이 먼저 나간다.
		// push: 데이터 추가
		// pop : 데이터 가져오기
		Stack<String> st = new Stack<>();
		st.push("홍길동");
		st.push("김길동");
		st.push("박길동");
		// stack : 배열을 세로로 쌓는 거 (위쪽에서 한통로로만 넣고 뺌, 바구니)
		// 후위 연산자, 공학용 계산기 (개인적으로 해볼 것. 로직연습)
		// | 200 | 두번째 데이터 -> 나중 데이터가 먼저 출력된다
		// |-----|
		// | 100 | 첫번째

		// stack이 비어 있을 때까지
		while (!st.isEmpty()) {
			System.out.println(st.pop());
		}

		System.out.println("\n3. Queue \n------------------");
		// ArrayList와 거의 같음,
		// FIFO (First In First Out)
		// ㅁ-ㅁ-ㅁ-ㅁ 신호 들어오는 순서대로 프로그램 실행(마우스 포인터)
		Queue<String> qu = new LinkedList<>();
		qu.add("홍길동");
		qu.add("김길동");
		qu.add("박길동");

		// ==0
		while (qu.isEmpty() == false) {
			System.out.println(qu.poll());
		}

		// key 값, 전자정보... 공공데이터..?
		// 네트워크에 던지는 정보값 : csv, xml, json(key, value ㅇ)
		System.out.println("\n4. HashMap (많이 씀)\n------------------");
		// 키 - 값으로 관리되는 자료구조

		// 숫자,
		HashMap<Integer, String> map = new HashMap<>();
		map.put(1, "홍길동");
		map.put(2, "김길동");
		map.put(3, "박길동");
		// key / value
		// 01 ---- ㅁ 홍길동
		// 02 ---- ㅁ 김길동

		// 해쉬 테이블 위치정보
		Iterator<Integer> keySetIt = map.keySet().iterator();
		// 다음 데이터가 있냐
		while (keySetIt.hasNext()) {
			Integer key = keySetIt.next();
			System.out.printf("key=%d, 값: %s\n", key, map.get(key));
		}
		 
		/* thread
		 * process	: 현재 실행중인 프로그램  
		 * 메인 쓰레드	: 하나의 프로세스는 메인쓰레드 가지고 동작, 프로그램 내부동작
		 * 
		 * --------------------------------
		 * | __________   ______________  |
		 * | |메인 쓰레드 |  |작업(워크) 쓰레드*| | *n개 : multi thread
		 * | ----------   --------------  |
		 * --------------------------------
		 * 
		 * 메인만 있으면 끝난 뒤 작업 : 작업중 다른거 실행 시 파란화면
		 * 
		 * 메인에서 다운 
		 * 작업에서 재생
		 * 
		 * thread 사용 : 고급
		 */
	}

}
