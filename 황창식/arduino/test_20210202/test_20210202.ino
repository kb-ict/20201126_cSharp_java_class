// 상주 변수 선언
const int LED = 13;
const int HIGH_VAL = 1;
const int LOW_VAL = 0;

// 장치에 대한 환경 설정
void setup() {
  // 아두이노 핀맵 참조
  // 13번 핀 출력 방향 설정
  pinMode(LED_BUILTIN, OUTPUT);
  // pinMode(13, OUTPUT);
}

// main() 숨겨져 있음
// 동작하는 루틴 적용
void loop() {
  // 13번 핀 디지털 신호 high
  digitalWrite(LED, HIGH_VAL);
  // 딜레이 시간 1초
  delay(100);
  // 13번 핀 디지털 신호 low
  digitalWrite(LED, LOW_VAL);
  delay(100);
}
