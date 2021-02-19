const int BUZZER = 10;
#define DO1 262
#define RE 294
#define MI 330
#define FA 349
#define SOL 392
#define LA 440
#define SHI 494
#define DO2 523

#define DELAY 300

#include "pitches.h"

const int hakGyo[]{
  NOTE_G5, NOTE_F5, NOTE_E5, NOTE_E3, NOTE_E4, 0, NOTE_E4, NOTE_F3, NOTE_D4, 0, NOTE_D4 
};

const int musicDelay[]{
  500, 500, 500, 500, 500, 500, 500, 500, 500, 500, 500
};


void setup() {
  musicStart();
}

void loop() {

}

void musicStart(){
  for(int i = 0; i< sizeof(hakGyo)/sizeof(int); i++){
    tone(BUZZER, hakGyo[i], musicDelay[i]);
    delay(DELAY);
  }
}
