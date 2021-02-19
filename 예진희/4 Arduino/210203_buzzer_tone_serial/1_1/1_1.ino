//상수변수 선언 자바의 final
const int LED = 13; //전역변수
const int HIGH_VAL = 1;
const int LOW_VAL = 0;

// 부저, 상수변수 선언 2번째 방법 (-)#ㅇ= java, c, c++
// (-) 필요할 때마다 핀 할당, 여러개 : 회로라고 함
#define BUZZER 10
// 장치에 대한 환경 설정
void setup() {
  // 아두이노 핀맵 참조
  // 13번핀 출력방향 설정
  pinMode(LED, OUTPUT);
  pinMode(BUZZER, OUTPUT);
}

// main() 숨겨져 있음
// 동작하는 루틴 적용.
void loop() {
  //13번핀 디지털 신호 high
  digitalWrite(13, HIGH_VAL);
  buzStart();
  delay(2000);

  //13번핀 디지털 신호 low
  digitalWrite(13, LOW_VAL);
  buzStart();
  delay(2000);
}

void buzStart(){
  digitalWrite(BUZZER, HIGH);
  delay(100);
  digitalWrite(BUZZER, LOW);
}
// (-) 오류시 붉은 불
