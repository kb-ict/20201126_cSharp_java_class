const int melody[] = {
  262,//도
  294,
  330,
  349,
  392,
  440,
  494,
  523
};

// 상수 변수
//const int BUZZER = 10;
// c/c++ 사용 문법
#define BUZZER 10
void setup() {
  tone(BUZZER, melody[4], 500);
  delay(500);
  tone(BUZZER, melody[4], 500);
  delay(500);
  tone(BUZZER, melody[5], 500);
  delay(500);
  tone(BUZZER, melody[5], 500);
  delay(500);
  tone(BUZZER, melody[4], 500);
  delay(500);
  tone(BUZZER, melody[4], 500);
  delay(500);
  tone(BUZZER, melody[2], 500);
  delay(1000);
  tone(BUZZER, melody[4], 500);
  delay(500);
  tone(BUZZER, melody[4], 500);
  delay(500);
  tone(BUZZER, melody[2], 500);
  delay(500);
  tone(BUZZER, melody[2], 500);
  delay(500);
  tone(BUZZER, melody[1], 500);
  delay(1000);
  tone(BUZZER, melody[4], 500);
  delay(500);
  tone(BUZZER, melody[4], 500);
  delay(500);
  tone(BUZZER, melody[5], 500);
  delay(500);
  tone(BUZZER, melody[5], 500);
  delay(500);
  tone(BUZZER, melody[4], 500);
  delay(500);
  tone(BUZZER, melody[4], 500);
  delay(500);
  tone(BUZZER, melody[2], 500);
  delay(1000);
  tone(BUZZER, melody[4], 500);
  delay(500);
  tone(BUZZER, melody[2], 500);
  delay(500);
  tone(BUZZER, melody[1], 500);
  delay(500);
  tone(BUZZER, melody[2], 500);
  delay(500);
  tone(BUZZER, melody[0], 500);
 }

void loop() {
  
}
