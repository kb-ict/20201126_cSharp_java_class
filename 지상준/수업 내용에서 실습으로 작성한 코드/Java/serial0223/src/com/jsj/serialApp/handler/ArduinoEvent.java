package com.jsj.serialApp.handler;

import java.util.EventObject;

@SuppressWarnings("serial")
public class ArduinoEvent extends EventObject {
	public ArduinoEvent(Object source) {
		super(source);
	}
}