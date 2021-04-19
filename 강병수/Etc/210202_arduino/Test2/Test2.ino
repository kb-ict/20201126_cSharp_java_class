const int ANT = 8;
const int SEC = 6;
int note[] = {2093,2349,2637,2793,3136,3520,3951,4186}; //도레미파솔라시도

// tone(pin, frequency, duration)
// 핀 꽂은 숫자, 주파수, 지속시간
void setup() {
    pinMode(ANT, OUTPUT);
    pinMode(SEC, OUTPUT);
    int count = sizeof(note)/sizeof(int);
    for(int i = 0 ; i<count; i++)
    {
      tone(SEC,note[i],500);
      delay(750);
    }
}

void loop() {
  digitalWrite(ANT, HIGH);   
  delay(300);                       
  digitalWrite(ANT, LOW);    
  delay(300);                    
}
