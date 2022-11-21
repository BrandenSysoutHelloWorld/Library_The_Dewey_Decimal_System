 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_The_Dewey_Decimal_System.Controllers
{
    public class ReplacingBooks
    {
        // Variables
        public string callnumber;
        private int letterValue = new int();
        private double firstValue = new double();
        private double secoundValue = new double();
        // Random Genorators
        private readonly Random LetterRandom = new Random();
        private readonly Random NumberLetterRandom = new Random();
        private readonly Random FirstNumberRandom = new Random();
        private readonly Random SecoundNumberRandom = new Random();
        private readonly Random a = new Random();
        public string CallNumber_Generator()
        {
            // Variables
            int stringlen = LetterRandom.Next(3, 3);
            string str = "";
            char letter;
            // Creates random values for Callnumber.
            for (int i1 = 0; i1 < stringlen; i1++)
            {
                // Generating a random number.
                letterValue = NumberLetterRandom.Next(0, 26);
                // Converts random into Char.
                letter = Convert.ToChar(letterValue + 65);
                // Appending the letter to string.
                str += letter;
            }
            // Place holders for Callnumber.
            firstValue = FirstNumberRandom.Next(0, 900);
            secoundValue = SecoundNumberRandom.Next(0, 99);
            // Constructs CallNumber. (firstValue, secoundValue) Places "00" to fill CallNumber. (if nesseary)          
            if (firstValue < 10 && firstValue < 100)
            {
                return callnumber = "00" + firstValue.ToString() + "." +
                    secoundValue.ToString() + " " + str;
            }
            else if (firstValue < 100 && firstValue > 10)
            {
                return callnumber = "0" + firstValue.ToString() + "." +
                    secoundValue.ToString() + " " + str;
            }
            else
            {
                return callnumber = firstValue.ToString() + "." +
                    secoundValue.ToString() + " " + str;
            }
        }
        // Random Number Generator.
        public int IDGenerator()
        {
            return a.Next();
        }
        // Returns genorated Callnumber.
        public override string ToString()
        {
            return CallNumber_Generator();
        }
    }
}

