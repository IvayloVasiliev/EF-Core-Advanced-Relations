using System;
using System.Collections.Generic;
using System.Text;
using BillsPaymentSystem.Data;

namespace BillsPaymentSystem
{
    public class DbInitializer
    {

        public static void Seed(BillsPaymentSystemContext context)
        {
            SeedUsers(context);
        
        }

        public static void SeedUsers(BillsPaymentSystemContext context)
        {
            string[] firstNames = { "Gosho", "Pesho", "Ivan", "Kiro", null, ""};
            string[] lastNames = { "Goshev", "Peshev", "Ivanov", "Kirov", null, "ERROR" };
            string[] firstNames = { "gosho@abv.bg", "pesho@abv.bg", "ivan@gmail.com", "Kiro@abv.bg",
                null, "ERROR" };
            string[] password = { "Gosh123o", "Pesho456", "Ivan400000", "Kiro16151", null, "ERROR" };

            List<User> users = new List<User>();

            for (int i = 0; i < firstNames.Lenght; i++)
            {


            }
        }

    }
}
