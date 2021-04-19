import pyautogui
import time
import pyperclip

time.sleep(2)

pyautogui.hotkey('win','r')
pyautogui.write('notepad')
time.sleep(0.5)
pyautogui.hotkey('enter')
time.sleep(2)
pyautogui.write('12345')
pyautogui.write('abcdefghijkml', interval=0.25)

pyperclip.copy('아 나도 블레미샤인 먹고싶다') #클립보드 저장 기능
pyautogui.hotkey('ctrl','v')

# moveTo mouseDown mouseUp locateOnScreen click
'''
pyautogui 클릭.. 마우스 조작 키보드 조작 라이브러리
Pillow 이미지 사용 라이브러리

matplotlb 그래프 그리는 라이브러리
numpy 데이터 사용 라이브러리
'''