using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Account
{
    private String accName;
    private String accid;
    private int balance;
    private int amount;
    private int deposite;


    public Account() { }

    public Account(String accName, String accid, int balance, int amount)
    {
        this.accName = accName;
        this.accid = accid;
        this.balance = balance;
        this.amount = amount;


    }
    public void ShowAccountInfo()
    {
        Console.WriteLine("Account Name: " + accName);
        Console.WriteLine("Account ID: " + accid);
        Console.WriteLine("Account Balance: " + balance);
        Console.WriteLine("Account Deposited: " + (balance + amount));
        Console.WriteLine("Account Withdraw: " + (balance - amount));
    }
    public static void Main(string[] args)
    {
        Account a1=new Account();
        Account a2 = new Account("Rahman, Fozlur", "202", 10000, 5000, 6500);
        a2.ShowAccountInfo();

    }

}