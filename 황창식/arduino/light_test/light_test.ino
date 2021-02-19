#define LIGHT 10
#define SOUND 8

void setup() {
  Serial.begin(9600);
  pinMode(LIGHT, OUTPUT);
  pinMode(SOUND, OUTPUT);
}

void loop() {
  if(Serial.available()){
    char ch = Serial.read();
    if(ch == '1'){
      digitalWrite(LIGHT, HIGH);
      for(int i = 0; i < 2; i++){
        digitalWrite(SOUND, HIGH);
        delay(100);
        digitalWrite(SOUND, LOW);
        delay(100);
      }
      Serial.println("Light On");
    }
    else if(ch == '0'){
      digitalWrite(LIGHT, LOW);
      digitalWrite(SOUND, HIGH);
      delay(100);
      digitalWrite(SOUND, LOW);
      delay(100);
      Serial.println("Light Off");
    }
  }

}
