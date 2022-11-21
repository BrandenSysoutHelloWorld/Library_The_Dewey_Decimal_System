using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_The_Dewey_Decimal_System.Helper
{
    public class RandomGen
    {
        public Random random = new Random();
        public int RandomNumberGen(int start,int end)
        {

            return random.Next(start, end);
        }
    }
}
