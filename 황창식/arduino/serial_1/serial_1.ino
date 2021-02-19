//#define LED 10
const int LED = 10;
const int BUZZER = 8;

#include "pitches.h"
#include <Servo.h>
Servo myservo;
int pos = 0;

int melody1[] = {
  NOTE_E4, NOTE_F4, NOTE_G4, NOTE_A4, NOTE_E4, NOTE_G4, NOTE_C4,
  NOTE_C5, NOTE_C5, NOTE_C5, NOTE_B4, NOTE_B4, NOTE_B4, NOTE_A4, NOTE_A4, NOTE_A4, NOTE_A4, NOTE_E4, NOTE_G4, NOTE_F4,
  NOTE_D4, NOTE_E4, NOTE_F4, NOTE_D4, NOTE_E4, NOTE_F4, NOTE_D4,
  NOTE_B4, NOTE_B4, NOTE_B4, NOTE_A4, NOTE_A4, NOTE_A4, NOTE_G4, NOTE_G4, NOTE_G4, NOTE_G4, NOTE_F4, NOTE_E4};
 
int noteDurations1[] = {
  4, 8, 4, 4, 8, 2, 2,
  8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 2, 2,
  4, 8, 4, 4, 8, 2, 2,
  8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 2};
 
int melody2[] = {
  NOTE_E4, NOTE_F4, NOTE_G4, NOTE_A4, NOTE_E4, NOTE_G4, NOTE_C4,
  NOTE_C5, NOTE_C5, NOTE_C5, NOTE_B4, NOTE_B4, NOTE_C5, NOTE_B4, NOTE_C5, NOTE_D5, NOTE_D5, NOTE_A4,
  NOTE_D4, NOTE_C4, NOTE_B4, NOTE_C4, NOTE_B4, NOTE_A4, NOTE_G4, NOTE_E4, NOTE_G4, NOTE_A4, NOTE_E4, NOTE_F4, NOTE_G4,
  NOTE_A4, NOTE_B4, NOTE_F4, NOTE_C5};

int noteDurations2[] = {
  4, 8, 4, 4, 8, 2, 2,
  8, 8, 8, 8, 8, 8, 8, 8, 2, 2,
  8, 8, 8, 4, 4, 8, 8, 8, 8, 4, 8, 8, 8,
  2, 4, 4, 1};


void setup() {
  // 시리얼 통신 속도 (baudrate)
  Serial.begin(9600);
  // LED 출력 설정
  pinMode(LED, OUTPUT);
  pinMode(BUZZER, OUTPUT);
  myservo.attach(9);
}

void loop() {
  // 데이터 송신 : 아두이노 -> PC
//  Serial.print("온도 : 26.5℃");
//  Serial.println();
//  delay(2000);
  controlSystem();
}

void controlSystem(){
  if(Serial.available()){
    char ch = Serial.read();
    if(ch == '1'){
      digitalWrite(LED, HIGH);
      Serial.println("LED ON");
    }
    else if(ch == '0'){
      digitalWrite(LED, LOW);
      Serial.println("LED OFF");
    }
    else if(ch == '2'){
      Serial.println("Beep!");
      for (int thisNote = 0; thisNote < 37; thisNote++) {
        int noteDuration = 1000/noteDurations1[thisNote];
        tone(8, melody1[thisNote],noteDuration);
        int pauseBetweenNotes = noteDuration * 1.30;
        delay(pauseBetweenNotes);
        noTone(8);
      }
 
      for (int thisNote = 0; thisNote < 34; thisNote++) {
        int noteDuration = 1000/noteDurations2[thisNote];
        tone(8, melody2[thisNote],noteDuration);
        int pauseBetweenNotes = noteDuration * 1.30;
        delay(pauseBetweenNotes);
        noTone(8);
  }
    }
    else if(ch == '3'){
      Serial.println("Turbo ON!");
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
