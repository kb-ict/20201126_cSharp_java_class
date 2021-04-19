import pyperclip, pyautogui, time

pyautogui.hotkey('win','r')
pyautogui.write('mspaint')
time.sleep(1.5)
pyautogui.hotkey('enter')

time.sleep(2)
pyautogui.moveTo(342,92, duration=2)
pyautogui.click(x=342, y=92)
time.sleep(1)
pyautogui.click(x=500, y=400)
pyautogui.write('Well done!')