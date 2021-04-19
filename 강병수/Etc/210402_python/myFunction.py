import pyautogui
import pyperclip
import time

def han_write(text):
    pyperclip.copy(text)
    pyautogui.hotkey('ctrl', 'v')

def doA():
    for i in range(0,5):
        print("i = ", i)

# 10초동안 파일 이미지 찾기
def find_target(file_name,timeout=10):
    start = time.time()
    while True:
        time.sleep(1)
        end = time.time()
        # print('end',end)

        file_a = pyautogui.locateOnScreen(file_name)
        # print(file_a)
        if file_a is not None :
            # print("찾음")
            # pyautogui.click(file_a)
            return file_a
            

        if (start - end) > 10 :
            # print("10초지남")
            break
box = find_target('A.PNG') # def 그대로 타임아웃 10초
box = find_target('A.PNG',20) # 타임아웃 20초
pyautogui.click(box)