package com.jsj.serialApp.handler;

import java.util.EventListener;

public interface LoginEventListener extends EventListener {
	void loginEvent(LoginEvent event);
}
