// using _0._05_OOP_Game;
using System;

namespace _Encapsulation
{
    class MainClass
    {
        protected internal static void Main(string[] args)
        {
            // public is open to ALL
            // portected is open to the class and all derived clssess
            // private is open only to the class tiself 

            // public
            BankPublic bankPublic = new BankPublic();
            decimal amount = bankPublic.GetAmount();
            Console.WriteLine("Your balance is: {0}", amount);

            //protected
            BankProtected bankProtected = new BankProtected();
            // we wont be able to access the applylatefees by self b/c of its access status and not part of 
            // namespace (program is class, but not not namepsace, and bankprotected isnt a namepsace)
            // even private fired b/c all is fired off 
            bankProtected.CloseAccount();

            //BankProtectedSubclass bankProtectedSubclass = new BankProtectedSubclass();
            //bankProtectedSubclass.ClearUserFromDB();

            // ASSEMBLY REFERENCE 
            // Creature steve = new Creature(); 

            Console.ReadLine();
        }
    }
}
