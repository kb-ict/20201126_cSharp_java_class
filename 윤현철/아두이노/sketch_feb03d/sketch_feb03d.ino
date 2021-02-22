#define LED 13

void setup() {
  // 시리얼 통신 속도
  Serial.begin(9600);
  //LED 출력 설정
  pinMode(LED, OUTPUT);
}

void loop() {
  Serial.print("sensor_value");
  Serial.println();
  delay(2000);
}
