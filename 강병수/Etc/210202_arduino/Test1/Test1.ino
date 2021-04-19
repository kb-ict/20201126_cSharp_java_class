//상수 변수 선언
const int LED = 13;
const int HIGH_VALUE = 1;
const int LOW_VALUE = 0;

// 장치에 대한 환경 설정
void setup() {
  // 아두이노 핀맵 참조
  // 13번핀(LED_BUILTIN) 출력 방향 설정
  pinMode(LED, OUTPUT);

}
// main() 메서드 숨겨져있음.
// 동작하는 루틴 적용.
void loop() {
  // 13번핀 디지털 신호 high
  digitalWrite(LED, HIGH_VALUE);
  // 시간 딜레이 1초 2초 등 바꿀 수 있음 ms 기준으로 1000ms = 1초
  delay(1000);
  // 13번핀 디지털 신호 low
  digitalWrite(LED, LOW_VALUE);    
  delay(1000);                       
}
