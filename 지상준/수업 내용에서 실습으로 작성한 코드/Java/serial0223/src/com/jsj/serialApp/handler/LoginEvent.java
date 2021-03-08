package com.jsj.serialApp.handler;

import java.util.EventObject;

@SuppressWarnings("serial")
public class LoginEvent extends EventObject {
	public LoginEvent(Object source) {
		super(source);
	}
}