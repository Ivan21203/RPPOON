// See https://aka.ms/new-console-template for more information

using _1DZ;

class Program 
{
    static void Main(string[] args) 
    {
        Bank bank = new Bank();
        User user1 = new User(500);
        User user2 = new User(100);
        Console.WriteLine("Stanje korisnika 1:" + user1.CheckBalance());
        Console.WriteLine("Stanje korisnika 2:" +user2.CheckBalance());
        bank.AddUser(user1);
        bank.AddUser(user2);
        Transaction user1pay = new PayIn(user1, 100);
        Transaction payout= new PayOut(user2, 50);
        bank.MakeATransaction(user1pay);
        bank.MakeATransaction(payout);
        Console.WriteLine("Stanje korisnika 1: " + user1.CheckBalance());
        Console.WriteLine("Stanje korisnika 2: " + user2.CheckBalance());

    }
}