package com.jsj.serialApp.handler;

import java.util.EventListener;

public interface ArduinoEventListener extends EventListener {
	void arduinoEvent(ArduinoEvent event);
}
