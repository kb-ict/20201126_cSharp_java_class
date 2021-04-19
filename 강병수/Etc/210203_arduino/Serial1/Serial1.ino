#define LED 10

void setup() {
  // 시리얼 통신 속도
 Serial.begin(9600);
 // LED 출력 설정
 pinMode(LED, OUTPUT);
}

void loop() {
  // 데이터 송신: 아두이노 -> PC
  /*
  Serial.print("sensor_value");
  Serial.println();
  delay(2000);
  */
  // 데이터 수신: PC -> 아두이노
  if (Serial.available()) {
    char ch = Serial.read();
    if (ch == '1'){
      digitalWrite(LED, HIGH);
      // 데이터 송신: 아두이노 -> PC
      Serial.println("LED ON");
    }
    else if (ch == '0') {
      digitalWrite(LED, LOW);
      Serial.println("LED OFF");
    }
  }
}
