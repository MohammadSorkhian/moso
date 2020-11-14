public class Account {
    private  String accountNumber;
    private double balance;
    private String customerName;
    private String email;
    private int phoneNumber;

    public Account(){
    this("0000", 0, "Customer Name");
    }
    public Account(String accountNum, double balance, String customerName){
    this.accountNumber = accountNum;
    this.balance = balance;
    this.customerName = customerName;
    }
    public void setAccountNumber(String accountNumber) {
        this.accountNumber = accountNumber;
    }

    public void setBalance (double balance){
        this.balance = balance;
    }

    public void setCustomerName(String customerName) {
        this.customerName = customerName;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public void setPhoneNumber(int phoneNumber) {
        this.phoneNumber = phoneNumber;
    }

    public double getBalance() {
        return balance;
    }

    public String getAccountNumber() {
        return accountNumber;
    }

    public int getPhoneNumber() {
        return phoneNumber;
    }

    public String getCustomerName() {
        return customerName;
    }

    public String getEmail() {
        return email;
    }
    public void deposit(double deposit){
        this.balance += deposit;
    }
    public void withdraw(double withdraw){
        if (balance>=withdraw){
            this.balance -= withdraw;
        } else System.out.println("insufficient money");
    }
}
