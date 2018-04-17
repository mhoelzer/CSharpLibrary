using System;
namespace _Encapsulation
{
    class BankProtected
    {
        // when closeaccount is fired off, they will all be fired off. this is the only one accessible by main 
        // program and is at a parallel level to the protected ones. 
        public void CloseAccount()
        {
            ApplyLateFees();
            ClearUserFromDB();
            BanUserFromBankForever();
        }

        // dont want these accessed/available outside; these are just demo
        protected void ApplyLateFees()
        {
            Console.WriteLine("Late charges were assigned");
        }
        protected void ClearUserFromDB()
        {
            Console.WriteLine("user cleared");
        }
        private void BanUserFromBankForever()
        {
            Console.WriteLine("user banned forever");
        }
    }
}
