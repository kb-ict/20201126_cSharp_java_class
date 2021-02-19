
void setup() {
//led on : 부저 2번, of : 부저 3번
pinMode(8, OUTPUT);
pinMode(9, OUTPUT);
}

void loop() {
//int eight = digitalRead(8);
  digitalWrite(8,HIGH);
  
  for(int i = 0; i<2; i++){
    digitalWrite(9, HIGH);
    delay(150);
    digitalWrite(9, LOW);
    delay(80);
    }
    delay(3000);

  digitalWrite(8,LOW);
  for(int i = 0; i<3; i++){
      digitalWrite(9, HIGH);
      delay(150);
      digitalWrite(9, LOW);
      delay(80);
  }
  delay(3000);
}
