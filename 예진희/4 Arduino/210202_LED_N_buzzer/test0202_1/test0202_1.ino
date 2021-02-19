//상수변수 선언 자바의 final
const int LED = 13; //전역변수
const int HIGH_VAL = 1;
const int LOW_VAL = 0;

// 장치에 대한 환경 설정
void setup() {
  // 아두이노 핀맵 참조
  // 보드 자체적으로 연결 돼 있음, 13번 연결정보 센서나 장치를 제어하겠다. pinMode(13, OUTPUT); 
  // 13번 핀 출력 방향 설정 LED_BUILTIN: 상수 == 13, 연결된 것 출력-제어하겠다. 입력제어가능
pinMode(LED, OUTPUT);
}

// main() 숨겨져 있음
// 동작하는 루틴 적용.
void loop() {// 무한루프 계속 돈다. while(true)같은, 개발프로그램을 올리는거
  //13번핀 디지털 신호 high      (1 true 켜짐) 5V, LED_BUILTIN = 상수변수 13
  digitalWrite(13, HIGH_VAL); //HIGH = 1, 상수
  // 시간 딜레이 2000ms -> 2초
  delay(300);      
  //13번핀 디지털 신호 low       (0 false값 꺼짐) Ground
  digitalWrite(LED_BUILTIN, LOW_VAL); 
  delay(300);                 // etc_ 1sec , 1ms (10-3), 1us (10-6) // 100 = 0.1초
}
// 실행파일 다른경로에 만들어지고 장치안으로 들어감, 만든 뒤 제어함
// L이 LED(주황색 불..)
// etc_ 전자 3.3, 5V, 산업: 24V, 집: 220V, //전원 들어옴: 전기, 접지(ground)
// 1 = 5V, 0 = ground
