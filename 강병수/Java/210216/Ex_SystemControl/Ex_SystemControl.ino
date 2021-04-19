const int LED = 10;
const int BUZZER = 13;
const int melody[] = {
  262, //도
  293, //레
  330, //미
  349, //파
  392, //솔
  440, //라
  494, //시
  523 //도
};
#include <Servo.h>

Servo myservo;
int pos = 0;

void setup() {
  // 시리얼 통신 속도 (baudrate)
 Serial.begin(9600);
 pinMode(LED, OUTPUT);
 myservo.attach(8);
}

void loop() {
  Control();
}

// 함수(메소드) 사용
void Control() {
  // 데이터 수신: PC -> 아두이노
  if (Serial.available()) {
    char ch = Serial.read();
    if (ch == '1') {
      digitalWrite(LED, LOW);
      Serial.println("TV 끄기");
    }
    else if (ch == '2'){
      digitalWrite(LED, HIGH);
      // 데이터 송신: 아두이노 -> PC
      Serial.println("TV 켜기");
    }
    else if (ch == '3') {
      for(int i = 0 ; i<8 ; i++){
    tone(BUZZER, melody[i], 500);
    delay(100);
    }
    Serial.println("보일러 동작");
  }
    else if (ch == '4') {
      for (pos = 0; pos <= 180; pos += 1) { 
      myservo.write(pos);              
      delay(15);                       
      }
      for (pos = 180; pos >= 0; pos -= 1) { 
      myservo.write(pos);              
      delay(15);                       
      }
      Serial.println("세탁기 동작");
    }
    else if (ch == '5') {
      Serial.println("프로그램 종료");
    }
  }
}
