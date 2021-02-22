//상수 변수 선언
const int LED =13;
const int HIGH_VAL =1;
const int LOW_VAL =0;
// 부저
#define BUZZER 10

//장치에 대한 환경 설정
void setup() {
  // 아두이노 핀맵 참조
  // 13번핀 출력 방향 설정
  pinMode(LED, OUTPUT);
  pinMode(BUZZER, OUTPUT);
}

// main() 숨겨져있음.
// 동작하는 루틴 적용.
void loop() {
  // 13번핀 디지털 신호 high
  digitalWrite(LED, HIGH_VAL);
  // 시간 딜레이 2000 => 2초
  buzStart();
  delay(2000);
  // 13번핀 디지털 신호 low
  digitalWrite(LED, LOW_VAL); 
  buzStart();
  delay(2000);
}

void buzStart(){
  digitalWrite(BUZZER, HIGH);
  delay(100);
  digitalWrite(BUZZER, LOW);
}
