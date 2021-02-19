#define LIVINGROOM 10
#define SOUND 8

void setup() {
  Serial.begin(9600);
  pinMode(LIVINGROOM, OUTPUT);
  pinMode(SOUND, OUTPUT);
}

void loop() {
  if(Serial.available()){
    char ch = Serial.read();
    if(ch == '1'){
      digitalWrite(LIVINGROOM, HIGH);
      digitalWrite(SOUND, HIGH);
      delay(100);
      digitalWrite(SOUND, LOW);
      Serial.println("Light On");
    }
    else if(ch == '0'){
      digitalWrite(LIVINGROOM, LOW);
      for(int i = 0; i < 2; i++){
        digitalWrite(SOUND, HIGH);
        delay(100);
        digitalWrite(SOUND, LOW);  
        delay(100);
      }
      Serial.println("Light Off");
    }
  }
}
