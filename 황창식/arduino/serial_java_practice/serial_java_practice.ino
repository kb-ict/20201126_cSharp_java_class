const int LED = 10;
const int BUZZER = 8;

#include <Servo.h>
Servo myservo;
int pos = 0;

void setup() {
  Serial.begin(9600);
  pinMode(LED, OUTPUT);
  pinMode(BUZZER, OUTPUT);
  myservo.attach(9);
}

void loop() {
  controlSystem();
}

void controlSystem(){
  if(Serial.available()){
    char ch = Serial.read();
    if(ch == '1'){
      digitalWrite(LED, HIGH);
    }
    else if(ch == '2'){
      digitalWrite(LED, LOW);
    }
    else if(ch == '3'){
      for(int i = 0; i < 3; i++){
        digitalWrite(BUZZER, HIGH);
        delay(100);
        digitalWrite(BUZZER, LOW);
        delay(100);
      }
      
    }
    else if(ch == '4'){
      for (pos = 0; pos <= 180; pos += 1) {
        myservo.write(pos);
        delay(15);
      }
      for (pos = 180; pos >= 0; pos -= 1) {
        myservo.write(pos);
        delay(15);
      }
    }
  }
}
