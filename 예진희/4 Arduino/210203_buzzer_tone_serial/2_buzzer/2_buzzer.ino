const int melody[] = {
  262, //도
  294, //레
  330,
  349,
  392, 
  440,
  494,
  523
  };

//상수변수, 자바,c# = final
//const int BUZZER = 10;
// c/c++ 사용 문법
#define BUZZER 10

void setup() {
  //tone(BUZZER, melody[0],500);
  //핀에 주파수로 500 밀리세컨드 0.5초

  for(int i = 0; i < 8; i++){
    tone(BUZZER, melody[i], 500); //0.5소리내고 딜레이
    delay(200);
  }
}

void loop() {

}
