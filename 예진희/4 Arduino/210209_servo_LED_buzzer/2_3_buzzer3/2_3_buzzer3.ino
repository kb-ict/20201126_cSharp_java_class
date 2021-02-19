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

const int hakGyo[] = {SOL, SOL, LA, LA, SOL, SOL, MI, SOL, SOL,
  MI, MI, RE, SOL, SOL, LA, LA, SOL, SOL, MI, SOL, MI, RE, MI, DO1};

void setup() {
  musicStart();
}

void loop() {}

void musicStart() {
  for (int i=0; i<sizeof(hakGyo)/sizeof(int); i++) {
    tone(BUZZER, hakGyo[i], 300);
    delay(DELAY);
  }
}
