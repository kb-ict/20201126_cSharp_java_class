const int LED = 13;
const int HIGH_VAL = 1;
const int LOW_VAL = 0;
#define BUZZER 10

void setup() {
  pinMode(LED, OUTPUT);
  pinMode(BUZZER, OUTPUT);
}

void loop() {
  digitalWrite(LED, HIGH_VAL);
  buzStart();
  delay(2000);
  
  digitalWrite(LED, LOW_VAL);
  buzStart();
  delay(2000);
}

void buzStart(){
  digitalWrite (BUZZER, HIGH_VAL);
  delay(100);
  digitalWrite (BUZZER, LOW_VAL);
}
