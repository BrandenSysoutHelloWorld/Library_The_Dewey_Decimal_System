using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_The_Dewey_Decimal_System.Controllers
{
    public class IdentifyingAreas
    {
        // Variables
        public string callnumber;
        // Random Genorators
        public Random a = new Random();
        // 
        public List<int> randomList = new List<int>();
        // 
        string str = "";
        // 
        readonly List<string> answer000 = new List<string>();
        readonly List<string> answer100 = new List<string>();
        readonly List<string> answer200 = new List<string>();
        readonly List<string> answer300 = new List<string>();
        readonly List<string> answer400 = new List<string>();
        readonly List<string> answer500 = new List<string>();
        readonly List<string> answer600 = new List<string>();
        readonly List<string> answer700 = new List<string>();
        readonly List<string> answer800 = new List<string>();
        readonly List<string> answer900 = new List<string>();
        public string Division_Generator(int div)
        {
            switch (div)
            {
                case 0:
                    str = "000 General Knowledge";
                    break;
                case 1:
                    str = "100 Psychology and Philosophy";
                    break;
                case 2:
                    str = "200 Religious and Mythology";
                    break;
                case 3:
                    str = "300 Social Sciences and Folklore";
                    break;
                case 4:
                    str = "400 Languages and Grammer";
                    break;
                case 5:
                    str = "500 Math and Science";
                    break;
                case 6:
                    str = "600 Medicine and Technolodgy";
                    break;
                case 7:
                    str = "700 Arts and Recreation";
                    break;
                case 8:
                    str = "800 Literature";
                    break;
                case 9:
                    str = "900 Geography and History";
                    break;
            }
            return str;
        }
        public string Description_Generator(int desc)
        {
            int r = a.Next(0, 3);
            string val = "null";
            switch (desc)
            {
                case 000:
                    val = "Computers and the Internet";            
                    break;
                case 100:
                    val = "Emotions and Feelings";
                    break;
                case 200:
                    val = "Quakers, other world religions, Greek, Roman and other myths";
                    break;
                case 300:
                    val = "Careers, Customs, Environment, Families";
                    break;
                case 400:
                    val = "Languages from around the world";
                    break;
                case 500:
                    val = "Physics, Biology, Fish and Planets";
                    break;
                case 600:
                    val = "Cookbooks, The Human Body, Farming and Health";
                    break;
                case 700:
                    val = "Architecture, Crafts, Jokes and Puppets";
                    break;
                case 800:
                    val = "Plays, Poetry and Movies";
                    break;
                case 900:
                    val = "Ancient World, Countries, Travel and Biographies";                   
                    break;
            }
            return val;
        }
        // Random Alpha ID Generator.
        public char IDGenerator()
        {
            char ch;
            char ch1 = ' ';
            for (ch = 'A'; ch < 'D'; ch++)
            {
                ch1 = ch;
            }
            return ch1;
        }
    }
}

