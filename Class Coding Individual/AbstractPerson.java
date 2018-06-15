

public abstract class AbstractPerson{

	private String firstName;
	private String lastName;
	private String email;
	private String phoneNumber;
	private String loginPassword;

	public AbstractPerson(String fn, String ln, String e, String pn, String lp) {
		this.setFirstName(fn);
		this.setLastName(ln);
		this.setEmail(e);
		this.setPhoneNumber(pn);
		this.setLoginPassword(lp);
		
	}

	
	

	public String getFirstName() {
		return firstName;
	}

	public void setFirstName(String firstName) {
		this.firstName = firstName;
	}

	public String getLastName() {
		return lastName;
	}

	public void setLastName(String lastName) {
		this.lastName = lastName;
	}

	public String getEmail() {
		return email;
	}

	public void setEmail(String email) {
		this.email = email;
	}


	public String getPhoneNumber() {
		return phoneNumber;
	}

	public void setPhoneNumber(String phoneNumber) {
		this.phoneNumber = phoneNumber;
	}


	public String getLoginPassword() {
		return loginPassword;
	}

	public void setLoginPassword(String loginPassword) {
		this.loginPassword = loginPassword;
	}
}
