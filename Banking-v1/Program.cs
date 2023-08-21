using Banking_v1;
using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        Savings sav1 = new Savings();
        sav1.Description = "savings account";
        sav1.Deposit(400);
        sav1.Withdraw(50);
        sav1.Print();
        
        /*
        Checking Chk1 = new Checking();
        Checking Chk2 = new Checking();
        Chk1.Description = "Checking Account";
        Chk1.Deposit(300);
        Chk1.Withdraw(50);
        Chk1.WriteCheck(25);
        Chk2.Description = "Slush fund";
        Chk1.Transfer(Chk2, 25);

        Chk1.print();
        Chk2.print();
        /*
        Account AcctChecking = new Account();
        Account AcctSavings = new Account();
        AcctSavings.Deposit(500);
        AcctSavings.Withdraw(313);
        AcctSavings.transfer(AcctChecking, 187);
        AcctSavings.Deposit(-100);
        AcctSavings.Withdraw(200);
        AcctSavings.Withdraw(-100);
        AcctChecking.transfer(AcctSavings, 287);

        AcctChecking.Print();
        AcctSavings.Print();
        */

    }
}