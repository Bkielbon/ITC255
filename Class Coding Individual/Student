

import java.util.ArrayList;
import java.util.Date;

public class Student extends AbstractPerson{
	private ArrayList<Certification> certification;
	private double amt;

	public Student(String fn, String ln, String e, String pn, String lp) {
		super(ln, e, pn, lp, lp);
		certification = new ArrayList<Certification>();
	}

	public void addCertification(double credits, Date enrollDate){
		Certification certification = new Certification(credits, this, enrollDate);
		certification.add(certification);
	}
	
	public String printStudent(){
		return "This Student's info: \n"
				+ "First Name: \t" + this.getFirstName() + "\n"
				+ "Last Name: \t" + this.getLastName() + "\n"
				+ "E-Mail: \t" + this.getEmail() + "\n"
				+ "Phone Number: \t" + this.getPhoneNumber() + "\n"
				+ "Login Password: \t" + this.getLoginPassword() + "\n" + 
				"\n" +
				certification;
		
	}
	
	public static void Login(String userName, String password)
	{
	   System.out.println("Login Successfull");
	 
	}

}
