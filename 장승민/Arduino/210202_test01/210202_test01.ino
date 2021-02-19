// main() 숨겨져 있음.
const int LED = 8;
const int BOO = 10;
int valLed = "";
int valBOO = "";
//int note[] = {2093,2349,2637,2793,3136,3520,3951,4186}; //도레미파솔라시도
//int air[] = {2637,2349,2093,2349,2637,2637,2637,2349,2349,2349,2637,3136,3136,2637,2349,2093,2349,2637,2637,2637,2349,2349,2637,2349,2093};
// 장치에 대한 환경설정
void setup() {
  // put your setup code here, to run once:
  pinMode(LED, OUTPUT);
  /* int elementCount = sizeof(air) / sizeof(int);
    for (int i=0; i < elementCount; i++)    //note를 play
    {
     tone(BOO,air[i],500);
     delay(200);
    }
  */
}

// 동작하는 루틴 적용
// 무한루프 ↓
void loop() {
  // put your main code here, to run repeatedly:
  digitalWrite(LED, HIGH);

  if (digitalRead(LED) == HIGH) {
    for(int i = 0;i<2;i++){
       tone(BOO, 700,50);
      delay(100);
    }
  }
    delay(1000);
  digitalWrite(LED, LOW);
   if (digitalRead(LED) == LOW) {
    for(int i = 0;i<3;i++){
       tone(BOO, 500,50);
      delay(100);
    }
  }
  delay(1000);

}
