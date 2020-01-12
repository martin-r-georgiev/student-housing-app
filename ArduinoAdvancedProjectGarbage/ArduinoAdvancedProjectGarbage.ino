const int BUTTON_INPUT = 9;
const int BUTTON_CONFIRM = 8;
const int DEBOUNCE_DELAY = 50;
const int BUZZER = 3;
const int NOTEDURATION = 100;
const int TONEBUTTON2 = 600;
const int TONEBUTTON1 = 450;
const int KNOB = A0;
int buttonState1;
int buttonState2;
int lastButtonState1;
int lastDebounceTime1;
int lastButtonState2;
int lastDebounceTime2;
enum Mode {MANUAL, KNOBMODE};
enum Mode currentMode;
int garbageData;
int previousKnobAmount;
int divider;
#include "Display.h"

void setup() {
  pinMode(BUTTON_INPUT, INPUT_PULLUP);
  pinMode(BUTTON_CONFIRM, INPUT_PULLUP);
  pinMode(BUZZER,OUTPUT);
  pinMode(KNOB, INPUT);
  lastButtonState1 = HIGH;
  lastDebounceTime1 = 0;
  lastButtonState2 = HIGH;
  lastDebounceTime2 = 0;
  currentMode = MANUAL;
  garbageData = 0;
  previousKnobAmount = 1;
  divider = 4;
  Serial.begin(9600);
  Display.show(garbageData);
}
int ReadKnob(){
  int KnobAmmount = analogRead(KNOB);
  KnobAmmount /= 100;
  if (KnobAmmount == 0) return 1;
  return KnobAmmount;
}
int readKeys() {
  int answer = 0;                                           
  int reading = digitalRead(BUTTON_INPUT);
  if (reading != lastButtonState1) {
    lastDebounceTime1 = millis();
  }
  if ((millis() - lastDebounceTime1) > DEBOUNCE_DELAY) {
    if (reading != buttonState1) {
      buttonState1 = reading;
      if (buttonState1 == LOW) {
        lastButtonState1 = reading;
        answer = 1;                                         
      }
    }
  }
  lastButtonState1 = reading;                               
  if (answer == 0) {                                        
    reading = digitalRead(BUTTON_CONFIRM);
    if (reading != lastButtonState2) {
      lastDebounceTime2 = millis();
    }
    if ((millis() - lastDebounceTime2) > DEBOUNCE_DELAY) {
      if (reading != buttonState2) {
        buttonState2 = reading;
        if (buttonState2 == LOW) {
          answer = 2;                                       
        }
      }
    }
  }                                                         
  lastButtonState2 = reading;                               
  return answer;                                            
}

void ChangeMode(){
      int KnobAmount = ReadKnob();
      tone (BUZZER, TONEBUTTON2, NOTEDURATION);
      divider = KnobAmount;
      currentMode = MANUAL;
      garbageData = 0;
      Serial.println(garbageData);
}

void ManualSwitch(){
    if (garbageData < 100){
      garbageData += 100 / divider;
      if (garbageData > 95) garbageData = 100;
      tone (BUZZER, TONEBUTTON1, NOTEDURATION); 
    } else {
      garbageData = 0;
      tone (BUZZER, TONEBUTTON1 * 2, NOTEDURATION); 
    }
    Serial.println(garbageData);
    Display.show(garbageData);
}

void SwitchToKnobMode(){
    if (currentMode != KNOBMODE) tone (BUZZER, TONEBUTTON2, NOTEDURATION);
    currentMode = KNOBMODE;

}
void ReceiveData(){
    if (Serial.available() > 0) {
    String line = Serial.readStringUntil('\n');
    if (line == "garbage") {
      Serial.println(garbageData);
      }
  }
}
void loop() {
  int pressedKey = readKeys();
  int KnobAmount = ReadKnob();
//Read Input
  if (KnobAmount != previousKnobAmount){
    SwitchToKnobMode();
    previousKnobAmount = KnobAmount;
  }
//Mode Changing

  switch (currentMode) {
    case MANUAL:
      if (pressedKey == 1) ManualSwitch();
      break;
    case KNOBMODE:
      Display.show(KnobAmount);
      if (pressedKey == 1) ChangeMode();
      break;
  }
  ReceiveData();  
}
