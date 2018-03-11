

public class BankAccount {
    public int id;
    public double balance;
    public static double interestRate;


    public void setId(int id) {
        this.id = id;
    }

    public double getBalance() {
        return this.balance;
    }

    public void deposit(double amount) {
        if (amount > 0) {
            this.balance += amount;
        } else {
            System.out.println("Can not deposit zero or negative amount");
        }
    }


    public void withdraw(double amount) {
        if (amount <= 0 || amount > this.balance) {
            System.out.println("Can not withdraw this amount.");
        } else {
            this.balance -= amount;
        }
    }

    public static void setInterestRate(double interest) {
        interestRate = interest;
    }

    public double getInterest(int years) {
        return this.balance*interestRate*years;
    }



    @Override
    public String toString(){
        return "Bank Account ID " + this.id+", balance : " + this.balance+" .";
    }
}
