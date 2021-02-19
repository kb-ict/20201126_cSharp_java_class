void setup() {
  // 거실등 ON,  알람 2회
  // 거실등 OFF, 알람 1회

  // PC프로그램에서 메시지 수신
  // 거실등 ON
  // 거실등 OFF

  Serial.begin(9600);
  #define LED 13 //변수로 지정하면 코드가 길어질 때 변수값만 수정가능
  #define BUZZER 10
  pinMode(LED, OUTPUT);
  pinMode(BUZZER, OUTPUT);
  Serial.begin(9600);
}

void loop() {
  if(Serial.available()){
  char ch = Serial.read();

    if(ch =='1'){
    digitalWrite(LED,HIGH);
    Serial.println("거실등 ON");
      for(int i = 0; i<2; i++){
      buzzerRing();
      }
    }
    else if (ch == '0'){
    digitalWrite(LED,LOW);
    Serial.println("거실등 OFF");
    buzzerRing();
    }
    delay(100);
  }
}
void buzzerRing(){
  digitalWrite(BUZZER, HIGH);
  delay(100);
  digitalWrite(BUZZER, LOW);
  delay(100);
}
