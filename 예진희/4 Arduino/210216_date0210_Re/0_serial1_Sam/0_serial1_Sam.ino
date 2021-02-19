// #define LED 13
const int LED = 13;

const int BUZZER = 10;
// #define BUZZER 10

#define DO1   262 // 4옥타브 도
#define RE    294 // 레
#define MI    330 // 미
#define FA    349
#define SOL   392
#define LA    440
#define SI    494
#define DO2   523

#define DELAY 300

void setup() {
  // 시리얼 통신 속도 (baudrate)
  Serial.begin(9600);
  // LED 출력 설정
  pinMode(LED, OUTPUT);
}

void loop() {
  // 데이터 송신: 아두이노 -> PC
  /*
  Serial.print("온도 : 36.5℃");
  Serial.println();
  delay(2000);
  */

  controlSystem();
}

  void controlSystem() {
    // 데이터 수신: PC -> 아두이노
  
  if (Serial.available()) {
    char ch = Serial.read();
    if (ch == '1') {
      digitalWrite(LED, HIGH);
      // 데이터 송신: 아두이노 -> PC
      Serial.println("LED ON");
    }
    else if (ch == '0') {
      digitalWrite(LED, LOW);
      Serial.println("LED OFF");
    }
    else if( ch == '2' ) {
     const int hakGyo[] = {DO1, DO1, DO1, RE, MI, MI, RE, MI, FA, SOL};

      for (int i=0; i<sizeof(hakGyo)/sizeof(int); i++) {
      tone(BUZZER, hakGyo[i], 100);
      delay(DELAY);
    }
    }
    else if( ch == '3') {
      
    }
    delay(50);
  }
   
  
        
  }
    
  
  
  








  
