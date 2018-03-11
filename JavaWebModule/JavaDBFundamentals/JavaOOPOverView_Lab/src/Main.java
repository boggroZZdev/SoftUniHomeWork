import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.HashMap;

public class Main {
    public static void main(String[] args) throws IOException {
        HashMap<Integer, BankAccount> bank = new HashMap<>();
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        while (true) {
            String command = reader.readLine();

            String[] argmunets = command.split(" ");
            if (command.equals("End")) {
                break;
            }
            int id = Integer.parseInt(argmunets[1]);
            double amount = 0f;
            switch (argmunets[0]) {
                case "Create":
                    if (bank.containsKey(id)){
                        System.out.println("Account with such ID already exists.");
                    }else{
                        BankAccount acc = new BankAccount();
                        acc.setId(id);
                        bank.put(id, acc);
                    }
                    break;

                case "Deposit":
                    amount = Double.parseDouble(argmunets[2]);
                    if (!bank.containsKey(id)) {
                        System.out.println("Account with such ID does not exist.");
                    }else{
                        bank.get(id).deposit(amount);
                    }
                    break;

                case "Withdraw":
                    amount = Double.parseDouble(argmunets[2]);

                    if (!bank.containsKey(id)){
                        System.out.println("Account with such ID does not exist.");
                    }else{
                        bank.get(id).withdraw(amount);
                    }
                    break;

                case "Print":
                    System.out.println(bank.get(id).toString());
                    break;
                case "SetInterest":
                    double interest = Double.parseDouble(argmunets[1]);
                    BankAccount.setInterestRate(interest);
                    System.out.printf("Current interest rate: %.2f\r\n", BankAccount.interestRate);
                    break;

                case "GetInterest":
                    if (!bank.containsKey(id)){
                        System.out.println("No such account.");
                    }
                    int years = Integer.parseInt(argmunets[2]);
                    System.out.printf("For %d years your interest is: %.2f\r\n",years,bank.get(id).getInterest(years));
                    break;
            }
        }
    }
}
