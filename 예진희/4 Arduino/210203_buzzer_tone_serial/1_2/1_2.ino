
void setup() {
//led on : 부저 2번, of : 부저 3번
pinMode(13, OUTPUT);
pinMode(10, OUTPUT);
}

void loop() {
//int eight = digitalRead(13);
  digitalWrite(13,HIGH);
  
  for(int i = 0; i<2; i++){
  bell();
    }
    delay(2000);

  digitalWrite(13,LOW);
  for(int i = 0; i<3; i++){
  bell();
  }
  delay(2000);
}

void bell(){
  digitalWrite(10, HIGH);
    delay(50);
    digitalWrite(10, LOW);
    delay(100);
}
