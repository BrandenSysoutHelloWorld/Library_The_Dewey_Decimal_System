using Library_The_Dewey_Decimal_System.Controllers;
using Library_The_Dewey_Decimal_System.Helper;
using Library_The_Dewey_Decimal_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Library_The_Dewey_Decimal_System.Pages
{
    /// <summary>
    /// Interaction logic for Find_Call_Numbers.xaml
    /// Play A Game:
    /// Using a Trees and List Arrays to Read values derived from the class [FindCallNumberData] Call-Number.
    /// A User must match a Third Layer Call-Number to a Top Layer Call-Number.
    /// If the user is correct - the user is rewarded, prompted to play again or quit.
    /// </summary>
    public partial class Find_Call_Numbers : Window
    {
        // List Arrays:
        List<string> top_layer = new List<string>();
        List<string> third_layer = new List<string>();
        // Variables:
        string random = "";
        // Classes:
        GamificationData gamification = new GamificationData();
        FindCallNumberData numberData = new FindCallNumberData();



        public Find_Call_Numbers()
        {
            InitializeComponent();
            InitializeList();
        }
        public struct CallNumberS
        {
            public CallNumberS(string _callNumber)
            {
                callNumber = _callNumber;
            }
            string callNumber;
            public string CallNumber
            {
                get { return callNumber; }
                set { callNumber = value; }
            }
        }

        private void InitializeList()
        {
            firstLevel();
        }
        private void firstLevel()
        {
            list_FirstLayerCallNumber.Items.Clear();
            foreach (TreeNode<string> node in numberData.getTree())
            {
                if (node.Level == 1)
                {
                    top_layer.Add(node.Data);
                }
                else if (node.Level == 2)
                {
                    third_layer.Add(node.Data);
                    Console.WriteLine(node.Data);
                }
            }
            // Adds callnumbers to listView.
            for (int i = 0; i < top_layer.Count; i++)
            {
                list_FirstLayerCallNumber.Items.Add(top_layer[i]);
            }
            for (int i = 0; i < third_layer.Count; i++)
            {
                //Console.WriteLine(third_layer[i].ToString());
            }

            random = third_layer[getNumber()];
            ThirdLayerCallNumber.Text = "Match a Top Layer in the List." + '\n' 
                + "===================" +'\n' 
                +"Third Layer Call Number: " + '\n' + third_layer[getNumber()];

        }
        private void Check_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string tmp1 = list_FirstLayerCallNumber.SelectedItem.ToString();
                // string parent = "";
                Boolean found = false;
                foreach (TreeNode<string> node in numberData.getTree())
                {
                    if (node.Data.ToString().Equals(random))
                    {
                        foreach (var parent in node.Parent)
                        {
                            if (parent.Data.ToString().Equals(tmp1))
                            {
                                found = true;
                            }
                        }
                    }
                }
                if (found == true)
                {
                    gamification.UpdateLevels();
                    // Displays users level and prgress.
                    this.Display_Rank.Content = "Current Rank: " + gamification.getName();
                    progressbar.Value = gamification.getProgress();
                    // Displays relevent message to user.
                    MessageBox.Show("Correct!");
                    MessageBoxResult result = MessageBox.Show("Do you want to Play Again?",
                        "Confirmation", MessageBoxButton.YesNoCancel);
                    if (result == MessageBoxResult.Yes)
                    {
                        this.Close();
                        Find_Call_Numbers find = new Find_Call_Numbers();
                        find.Show();
                    }
                    else if (result == MessageBoxResult.No)
                    {
                        this.Close();
                        MainWindow mainWindow = new MainWindow();
                        mainWindow.Show();
                    }
                    else
                    {
                        // Cancel code here  
                    }
                }
                else
                {
                    // Displays relevent message to user.
                    MessageBox.Show("Wrong!");
                }
            }
            catch
            {
                // Displays relevent message to user.
                MessageBox.Show("Please Select a Top Level Call Number froim the LIST!");
            }
        }
        List<int> nums = new List<int>(Enumerable.Range(0, 49));
        public int getNumber()
        {
            Random rand = new Random();
            int index = rand.Next(0, nums.Count);
            int num = nums[index];
            nums.RemoveAt(index);
            return num;

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}

