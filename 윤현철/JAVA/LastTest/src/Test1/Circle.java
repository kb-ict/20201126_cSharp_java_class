package Test1;

class Circle{
	double rad = 0;
	final double PI =3.14;
	private double r;
	public Circle(double r) {setRad(r);
		if(r<0) {
			System.exit(0);
		}
		rad = r*r*PI;
		System.out.println(rad);
	}
	private void setRad(double r) {
		this.r=r;
	}
	public double getArea() {return(r*r)*PI;}
	
}
