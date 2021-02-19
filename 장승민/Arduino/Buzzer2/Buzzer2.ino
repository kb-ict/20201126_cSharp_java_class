const int melody[] = {
  262,  //도
  294,  //레
  330,  //미
  349,  //파
  392,  //솔
  440,
  494,
  523   //도
};

//상수변수
//  const int BUZZER =10;

#define BUZZER 10


void setup() {
  // put your setup code here, to run once:
  
  for(int i = 0; i<8; i++){
    tone(BUZZER, melody[i], 500);
    delay(400);
  }
}

void loop() {
  // put your main code here, to run repeatedly:

}
