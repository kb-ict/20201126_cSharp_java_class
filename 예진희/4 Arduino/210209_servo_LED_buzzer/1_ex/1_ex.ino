void setup() {
  // c++ c에서는 함수라고 함 p10-14
  // 20,22, 24
  // 98 서보모터(로봇 팔 제어, 정밀)
  pinMode(LED_BUILTIN, OUTPUT);
  // 버튼이면 input
}

void loop() {
  // 무한루프
  digitalWrite(LED_BUILTIN, HIGH);
  delay(300);                    
  digitalWrite(LED_BUILTIN, LOW); 
  delay(300);                    
}
