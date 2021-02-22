package serial20210203;

import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;

import gnu.io.CommPort;
import gnu.io.CommPortIdentifier;
import gnu.io.NoSuchPortException;
import gnu.io.PortInUseException;
import gnu.io.SerialPort;
import gnu.io.UnsupportedCommOperationException;

public class MySerial {
	void connect(String portName) {
		try {
			CommPortIdentifier portId= CommPortIdentifier.getPortIdentifier(portName);
			if (portId.isCurrentlyOwned()) {
				System.out.println("[에러] 포트 사용중");
			}
			else {
				CommPort commPort = portId.open(getClass().getName(),2000);		
				if (commPort instanceof SerialPort) {
					SerialPort serialPort = (SerialPort) commPort;
					serialPort.setSerialPortParams(9600, SerialPort.DATABITS_8,SerialPort.STOPBITS_1,SerialPort.PARITY_NONE);
					InputStream in = serialPort.getInputStream();
					OutputStream out = serialPort.getOutputStream();
					
					new Thread(new SerialReader(in)).start();
					new Thread (new SerialWriter(out)).start();
				}
			}
		} catch (NoSuchPortException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (PortInUseException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (UnsupportedCommOperationException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
	
	// inner calss
	public static class SerialReader implements Runnable{
		InputStream in;
		
		public SerialReader(InputStream in) {
			this.in = in;
		}

		@Override
		public void run() {
			byte[] buf = new byte[1024];
			int len = -1;
			try {
				while ((len = in.read(buf))>-1) {
					System.out.println((new String(buf,0,len)));				
				}
			} catch (IOException e) {
				e.printStackTrace();
			}
			
		}
	}
	
	public static class SerialWriter implements Runnable{
		OutputStream out;
		
		public SerialWriter(OutputStream out) {
			this.out =out;
		}
		@Override
		public void run() {
			int c =0;
			try {
				while((c=System.in.read())>-1) {
					out.write(c);
				}
			} catch (IOException e) {
				e.printStackTrace();
			}
		}
		
	}
}
