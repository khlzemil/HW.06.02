using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._06._02
{
    internal class User:IAccount
    {
        public string Fullname;
        public string Email;
        public string Password;

        public bool PasswordChecker()
        {
            
            char[] checkUpperLetter = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            char[] checkLowerLetter = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] checkNumber = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            bool flagForNumber = false;
            bool flagForUpperLetter = false;
            bool flagForLowerLetter = false;
            
            for (int i = 0; i < Password.Length; i++)
            {
                for (int j = 0; j < checkNumber.Length; j++)
                {
                    if (Password[i] == checkNumber[j])
                    {
                        flagForNumber = true;
                        break;

                    }
                }
            }

            for (int i = 0; i < Password.Length; i++)
            {
                for (int j = 0; j < checkUpperLetter.Length; j++)
                {
                    if (Password[i] == checkUpperLetter[j])
                    {
                        flagForUpperLetter = true;
                        break;

                    }
                }
            }

            for (int i = 0; i < Password.Length; i++)
            {
                for (int j = 0; j < checkLowerLetter.Length; j++)
                {
                    if (Password[i] == checkLowerLetter[j])
                    {
                        flagForLowerLetter = true;
                        break;

                    }
                }
            }

            if (flagForNumber == true && flagForLowerLetter == true && flagForUpperLetter == true && Password.Length >= 8)
            {
                return true;
            }
            else
                return false;

            
        }
    }
}
