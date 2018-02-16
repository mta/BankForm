using System;
using System.IO;
using BankForm.Models;

namespace BankForm.Controllers
{
    internal class BankAccountControl
    {
        public BankAccountControl()
        {
        }
        public bool SaveAccountInformation(BankAccount myBankAccount)
        {
            try
            {
                string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                using (StreamWriter outputFile = new StreamWriter(mydocpath + @"\" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt"))
                {
                    outputFile.WriteLine(myBankAccount.BSB.ToString() + "-" + myBankAccount.AccountNumber.ToString() + "-" + myBankAccount.AccountName + "-" + myBankAccount.Reference);
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}