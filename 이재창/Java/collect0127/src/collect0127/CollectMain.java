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
		System.out.println("�迭");
		String strArr[] = new String[3];
		strArr[0] = "ȫ�浿";
		strArr[1] = "��浿";
		strArr[2] = "�ڱ浿";
		
		for (var str : strArr) {
			System.out.println(str);
		}
		
		System.out.println("####### ArrayList #######");
		ArrayList<String> list = new ArrayList<>();
		list.add("ȫ�浿");
		list.add("��浿");
		list.add("�ڱ浿");
		
		System.out.println("####### Stack #######");
		Stack<String> st = new Stack<>();
		st.push("ȫ�浿");
		st.push("��浿");
		st.push("�ڱ浿");
		
		while (!st.isEmpty()) {
			System.out.println(st.pop());
		}
		
		System.out.println("####### Queue #######");
		Queue<String> qu = new LinkedList<>();
//		Queue<Stirng> qu = new Queue<>();
		qu.add("ȫ�浿");
		qu.add("��浿");
		qu.add("�ڱ浿");
		
		while (qu.isEmpty() == false) {
			System.out.println(qu.poll());
		}
		
		System.out.println("####### HashMap #######");
		//Ű�� ������ ���� �Ǵ� �ڷᱸ��
		HashMap<Integer, String> map = new HashMap<>();
		map.put(1, "ȫ�浿");
		map.put(2, "��浿");
		map.put(3, "�ڱ浿");
		
		//�ؽ����̺� ��ġ ����
		Iterator<Integer> keySetIt = map.keySet().iterator();
		while (keySetIt.hasNext()) {
			Integer key = keySetIt.next();
			System.out.printf("key=%d, ��=%s\n", key, map.get(key));
		}
	}

}
