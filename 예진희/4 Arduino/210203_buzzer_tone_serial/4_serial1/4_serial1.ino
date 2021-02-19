#define LED 13
void setup() {
  //시리얼 통신 속도 (baudrate)
  Serial.begin(9600); //(-)통신 시작하겠다. 9600bps: 문자 전송속도(옛날 모뎀 기준), 좀 느려도 안정적 빠르면 로스율..
  //LED 출력 설정
  pinMode(LED, OUTPUT);
  // 카톡: TCP/IP, 
  // 1,2,3(아두이노) --- (PC),web 아두이노가 sensor value를 2초마다 피씨로 보냄
  // 케이블(유선) 통한, 시리얼 통신 RS-232통신 _ 아래쪽 물리계층
  // 2m이하, 근거리 (2m이상 시 노이즈 발생)
  
  // 찍히는건 PC, 아두이노 기준: 송신한다. 
}

void loop() {
  // 데이터 송신: 아두이노 -> PC
  /*
  Serial.print("sensor_value");
  Serial.println();
  delay(2000);
  */

  // 데이터 수신: PC(입력 1) -> 아두이노(LED ON 보냄)
  if (Serial.available()){
    char ch = Serial.read();
    if (ch == '1'){
      digitalWrite(LED, HIGH);
      // 데이터 송신: 아두이노 -> PC
      Serial.println("LED ON");
    }
    else if (ch =='0') {
      digitalWrite(LED, LOW);
      Serial.println("LED OFF");
    }
    delay(50);
  }
}
