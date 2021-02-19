const int LED = 8;
int HIGH_VAL = 1;
int LOW_VAL = 0;
#define BUZZER 10

void setup() {
  // put your setup code here, to run once:
pinMode(LED, OUTPUT);
pinMode(BUZZER, OUTPUT);
} 

void loop() {
  // put your main code here, to run repeatedly:
 digitalWrite(LED,HIGH_VAL);
 buzStart();
 delay(2000);

  digitalWrite(LED,LOW_VAL);
 buzStart();
 delay(2000);
}

void buzStart(){
  for(int i=0;i<10;i++){
  digitalWrite(BUZZER,HIGH);
  tone(BUZZER, 1000,50);
  delay(100);
  digitalWrite(BUZZER,LOW);
  }
}
