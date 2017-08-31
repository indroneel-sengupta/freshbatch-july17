using DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginEntityApplication
{
    class BusinessLogic
    {
        public static void CheckLogin(string userName,string password)
        {
            bool flag = false;
            using (var LogObj = new LoginEntityEntities())
            {
                //foreach (var e1 in LogObj.BankDetails)
                //{
                //    MessageBox.Show("Result " + (string.Compare(e1.UserName, userName, false)) + " " + (string.Compare(e1.Password, password, false)));
                //}

                foreach (var e in LogObj.BankDetails.Where((e1) => (string.Equals(e1.UserName, userName, StringComparison.CurrentCulture) && string.Equals(e1.Password, password, StringComparison.CurrentCulture))))
                {
                    flag = true;
                    AfterLogin af = new AfterLogin(userName,password);
                    af.ShowDialog();

                }
                if (flag == false) MessageBox.Show("Invalid Username or password");

            }
        }
        public static decimal? ClickDeposit(string userName, string password,decimal amount)
        {
            decimal? tmp = 0;
            using (var obj = new LoginEntityEntities())
            {
                foreach (var e in obj.BankDetails.Where((e1) => e1.UserName == userName && e1.Password == password))
                {
                    e.Balance += amount;
                    tmp = e.Balance;

                }
                obj.SaveChanges();
                

            }
            return tmp;
        }

        public static decimal? ClickWithdraw(string userName, string password, decimal amount)
        {
            decimal? tmp = 0;
            using (var obj = new LoginEntityEntities())
            {
                foreach (var e in obj.BankDetails.Where((e1) => e1.UserName == userName && e1.Password == password))
                {
                    if(e.Balance>0)
                    {
                        if(e.Balance>amount)
                        {
                            e.Balance -= amount;
                            tmp = e.Balance;
                        }
                        else
                        {
                            return e.Balance;
                        }                       
                    }
                    else
                    {
                        return e.Balance;
                    }           
                }
                obj.SaveChanges();
            }
            return tmp;
        }

        public static void Register_Click(int acntNumber,string userName,string password,decimal? balance)
        {
            using (var obj = new LoginEntityEntities())
            {
                var bnk = new BankDetail();
                bnk.AccountNumber = acntNumber;
                bnk.UserName = userName;
                bnk.Password = password;
                bnk.Balance = balance;

                obj.BankDetails.Add(bnk);
                obj.SaveChanges();
                //foreach (var e in obj.BankDetails.Where((e1) => e1.UserName == userName && e1.Password == password))
                //{
                //    e.Balance += amount;
                //    tmp = e.Balance;
                //}
                //obj.SaveChanges();
            }
        }
    }
}
