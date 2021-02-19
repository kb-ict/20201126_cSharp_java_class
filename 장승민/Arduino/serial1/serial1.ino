//#define LED 13
const int LED = 13;
const int BUZZER = 10;
// #define BUZZER 10

#define DO1   262 // 4옥타브 도
#define RE    294 // 레
#define MI    330 // 미
#define FA    349
#define SOL   392
#define LA    440
#define SI    494
#define DO2   523

#define DELAY 300

const int hakGyo[] = {DO2, MI, LA, DO1, SOL, SOL, DO1, FA, RE,
  MI, MI, RE, SOL, RE, MI, MI, RE, SOL, MI, RE, MI, RE, MI, DO1};

#include <Servo.h>

Servo myservo;  // create servo object to control a servo
// twelve servo objects can be created on most boards

int pos = 0;    // variable to store the servo position

void setup() {
  // 시리얼 통신 속도
  Serial.begin(9600);
  //LED 출력 설정
  pinMode(LED,OUTPUT);
  myservo.attach(9);
}

void loop() {
 /* //데이터 송신: 아두이노 -> pc
  
  Serial.print("온도:26.5℃");
  Serial.println();
  delay(2000);}
*/
// 데이터 수신 : pc -> 아두이노
//if (Serial.available()){
//  char ch = Serial.read();
//  
//  if( ch=='1'){
//    digitalWrite(LED,HIGH);
//    Serial.println("LED ON");
//  }
//  else if( ch=='0'){
//    digitalWrite(LED,LOW);
//    Serial.println("LED OFF");
//  }
//}
//delay(100);
//
contrl();
}

void contrl(){
  if (Serial.available()){
  char ch = Serial.read();
  
  if( ch=='1'){
    digitalWrite(LED,HIGH);
    Serial.println("LED ON");
  }
  else if( ch=='0'){
    digitalWrite(LED,LOW);
    Serial.println("LED OFF");
  }
  else if(ch=='2'){
    musicStart();
    Serial.println("melody on");
  }
  else if(ch=='3'){
  for (pos = 0; pos <= 180; pos += 1) { // goes from 0 degrees to 180 degrees
    // in steps of 1 degree
    myservo.write(pos);              // tell servo to go to position in variable 'pos'
    delay(15);                       // waits 15ms for the servo to reach the position
  }
  for (pos = 180; pos >= 0; pos -= 1) { // goes from 180 degrees to 0 degrees
    myservo.write(pos);              // tell servo to go to position in variable 'pos'
    delay(15);                       // waits 15ms for the servo to reach the position
  }
  }
 
delay(100);
}
}




void musicStart(){
  for (int i=0; i<sizeof(hakGyo)/sizeof(int);i++){
    tone(BUZZER,hakGyo[i],300);
    delay(DELAY);
  }
  }
