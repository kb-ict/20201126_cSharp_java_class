#include "pitches.h"

int song[] = {
  NOTE_E6, NOTE_F6, NOTE_E6, NOTE_C6, NOTE_E6, 0,
  NOTE_E6, NOTE_F6, NOTE_E6, NOTE_F6, NOTE_A6, NOTE_F6,
  NOTE_E6, NOTE_F6, NOTE_E6, NOTE_C6, NOTE_D6,0
};

int time[] = {
  250, 250, 250, 250, 750, 250,
  250, 250, 250, 250, 250, 250,
  250, 250, 250, 250, 750, 250
};

void setup(){
  pinMode(8, OUTPUT);
  delay(1000);
  for(int i = 0; i < 16; i++){
    tone(8, song[i], time[i]);
    delay(time[i]);
  }
}

void loop(){
  
}
