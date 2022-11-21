using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_The_Dewey_Decimal_System.Models
{
    /// <summary>
    /// Using JSON to store a users progress and points.
    /// If a user successed at any game the use is rewarded with 25 points.
    /// level 1:Noob < 100 points,
    /// level 2:Novice > 100 but < 200
    /// level 3:Impressive between 200 and 300 points
    /// level 4:Expert between 300 and 400 points
    /// and level 5:A GOD is any points above 400
    /// </summary>
    internal class GamificationData
    {
        int Points = new int();
        int eVal = new int();

        public int ReadFile()
        {

            JObject o1 = JObject.Parse(File.ReadAllText("UserPoints.json"));

            // read JSON directly from a file
            using (StreamReader file = File.OpenText("UserPoints.json"))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                JObject o2 = (JObject)JToken.ReadFrom(reader);
                string str = o2.ToString();
                string str1 = string.Empty;
                Console.WriteLine("JSON: " + str);
                for (int i = 0; i < str.Length; i++)
                {
                    if (Char.IsDigit(str[i]))
                        str1 += str[i];
                }
                if (str1.Length > 0)
                {
                    eVal = int.Parse(str1);
                    Console.WriteLine("Number: " + eVal);
                }

            }
            return eVal;
        }
        public void UpdateLevels()
        {
            Points = ReadFile() + 25;
            // Update File
            JObject UserPoints = new JObject(
                new JProperty("POINTS", Points));

            File.WriteAllText("UserPoints.json", UserPoints.ToString());

            // write JSON directly to a file
            using (StreamWriter file = File.CreateText("UserPoints.json"))
            using (JsonTextWriter writer = new JsonTextWriter(file))
            {
                UserPoints.WriteTo(writer);
            }
        }


        public int getProgress()
        {
            if (ReadFile() < 100)
            {
                return ReadFile();
            }
            else if (ReadFile() > 100 && ReadFile() < 200)
            {
                return ReadFile() - 100;
            }
            else if (ReadFile() > 200 && ReadFile() < 300)
            {
                return ReadFile() - 200;
            }
            else if (ReadFile() > 300 && ReadFile() < 400)
            {
                return ReadFile() - 300;
            }
            else if (ReadFile() > 400)
            {
                return ReadFile() - 400;
            }
            else
            {
                return 0;
            }
        }


        public string getName()
        {
            if (ReadFile() < 100)
            {
                return "Noob";
            }
            else if (ReadFile() > 99 && ReadFile() < 199)
            {
                return "Novice";
            }
            else if (ReadFile() > 199 && ReadFile() < 299)
            {
                return "Impressive";
            }
            else if (ReadFile() > 299 && ReadFile() < 399)
            {
                return "Expert";
            }
            else if (ReadFile() > 399)
            {
                return "A GOD";
            }
            else
            {
                return "Error";
            }
        }
    }
}
