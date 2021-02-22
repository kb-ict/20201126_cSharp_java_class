#define LED 13
#define BUZZER 10

void setup() {
  // 시리얼 통신 속도
  Serial.begin(9600);
  //LED 출력 설정
  pinMode(LED, OUTPUT);
}

void loop() {
  // 데이터 송신 : 아두이노 -> PC
//  Serial.print("sensor_value");
//  Serial.println();
//  delay(2000);
  if (Serial.available()){
    char ch = Serial.read();
    if (ch=='1'){
      tone(BUZZER,392,300);
      delay(300);
      tone(BUZZER,392,300);
      digitalWrite(LED, HIGH);
      Serial.println("LED ON");
      delay(500);
    }
    else if (ch=='0'){
      tone(BUZZER,392,300);
      digitalWrite(LED, LOW);
      Serial.println("LED OFF");
      delay(500);
    }
    delay(50);
  }
}
