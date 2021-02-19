//const int melody[]{
//  262,
//  294,
//  330,
//  349,
//  392,
//  440,
//  494,
//  523
//};
//
//#define BUZZER 10
//
//
//void setup() {
//  for(int i = 0; i < 8; i++){
//    tone(BUZZER, melody[i],500);
//    delay(500);
//  }
//}
//
//void loop() {
//
//}

 #include "pitches.h"

// notes in the melody:
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

// note durations: 4 = quarter note, 8 = eighth note, etc.:
int noteDurations2[] = {
  4, 8, 4, 4, 8, 2, 2,
  8, 8, 8, 8, 8, 8, 8, 8, 2, 2,
  8, 8, 8, 4, 4, 8, 8, 8, 8, 4, 8, 8, 8,
  2, 4, 4, 1};

void setup() {
  // iterate over the notes of the melody:
  for (int thisNote = 0; thisNote < 37; thisNote++) {

    // to calculate the note duration, take one second
    // divided by the note type.
    //e.g. quarter note = 1000 / 4, eighth note = 1000/8, etc.
    int noteDuration = 1000/noteDurations1[thisNote];
    tone(8, melody1[thisNote],noteDuration);

    // to distinguish the notes, set a minimum time between them.
    // the note's duration + 30% seems to work well:
    int pauseBetweenNotes = noteDuration * 1.30;
    delay(pauseBetweenNotes);
    // stop the tone playing:
    noTone(8);
  }
 
  for (int thisNote = 0; thisNote < 34; thisNote++) {

    // to calculate the note duration, take one second
    // divided by the note type.
    //e.g. quarter note = 1000 / 4, eighth note = 1000/8, etc.
    int noteDuration = 1000/noteDurations2[thisNote];
    tone(8, melody2[thisNote],noteDuration);

    // to distinguish the notes, set a minimum time between them.
    // the note's duration + 30% seems to work well:
    int pauseBetweenNotes = noteDuration * 1.30;
    delay(pauseBetweenNotes);
    // stop the tone playing:
    noTone(8);
  }
}

void loop() {
  // no need to repeat the melody.
}
