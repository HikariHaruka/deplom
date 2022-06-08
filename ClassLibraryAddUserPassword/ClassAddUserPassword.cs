using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryAddUserPassword
{
    public class ClassAddUserPassword
    {
        public static bool checkPassword(string password)
        {
            int trufal = 0;

            if (password.Length >= 5)
            {
                bool en = true;
                bool symbol = false;
                bool number = false;
                
                for (int i = 0; i <password.Length; i++)
                {
                    if (password[i] >= 'А' && password[i] <= 'Я') en = false;
                    if (password[i] >= '0' && password[i] <= '9') number = true;
                    if (password[i] == '_' || password[i] == '$' || password[i] == '!') symbol = true;
                }

                if (en != true) trufal++;
                if (symbol != true) trufal++;
                if (number != true) trufal++;
            }
            else trufal++;

            if (trufal == 0) return true;
            else return false;
        }
    }
}
