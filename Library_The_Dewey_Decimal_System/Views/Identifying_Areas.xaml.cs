using Library_The_Dewey_Decimal_System.Controllers;
using Library_The_Dewey_Decimal_System.Models;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows;

namespace Library_The_Dewey_Decimal_System.Pages
{
    /// <summary>
    /// Interaction logic for Identifying_Areas.xaml
    /// </summary>
    public partial class Identifying_Areas : Window
    {  // Queue used to read data into Dictionary.
        private Queue<string> value = new Queue<string>();
        private Queue<char> key = new Queue<char>();
        // Dictionary used to store callnumbers.
        Dictionary<char, string> DefaultDictionary = new Dictionary<char, string>();
        readonly IdentifyingAreas identifyingAreas = new IdentifyingAreas();
        List<string> Sortedlist = new List<string>();
        List<Object> UserSortedlist = new List<Object>();
        public Random a = new Random();
        public List<int> randomList = new List<int>();
        public List<char> randomSList = new List<char>();
        List<string> list2 = new List<string>(3);
        List<string> list = new List<string>();
        int MyNumber = 0;
        GamificationData gamification = new GamificationData();

        public Identifying_Areas()
        {
            InitializeComponent();
            InitializeList();
        }

        public struct DivisionNumberS
        {
            public DivisionNumberS(string _id, string _divisionNumber)
            {
                id = _id;
                divisionNumber = _divisionNumber;
            }
            string divisionNumber;
            string id;
            public string Division
            {
                get { return divisionNumber; }
                set { divisionNumber = value; }
            }
            public string ID
            {
                get { return id; }
                set { id = value; }
            }
        }

        private void InitializeList()
        {

            DefaultDictionary.Clear();
            list.Clear();
            list2.Clear();
            DivisionList.Items.Clear();
            randomList.Clear();
            randomSList.Clear();
            Sortedlist.Clear();
            UserSortedlist.Clear();
            // Creates 10 random Callnumbers which are then added to a Dictoionary.
            for (int i = 0; i < 5; i++)
            {
                NewNumber();
            }

            for (int i = 0; i < randomList.Count; i++)
            {
                key.Enqueue(randomSList[i]);
                value.Enqueue(identifyingAreas.Division_Generator(randomList[i]));
                DefaultDictionary.Add(key.Dequeue(), value.Dequeue());

            }
            // Adds callnumbers to listView.
            foreach (KeyValuePair<char, string> divisionnumber in DefaultDictionary)
            {
                key.Enqueue(divisionnumber.Key);
                value.Enqueue(Regex.Match(divisionnumber.Value, @"\d+").Value);
                DivisionList.Items.Add(new DivisionNumberS() { ID = divisionnumber.Key.ToString(), Division = divisionnumber.Value });
                list2.Add(divisionnumber.Key.ToString());                
            }           
            PopulateComboBoxes();
        }

        public void PopulateComboBoxes()
        {
            try
            {
                this.opt1.Text = list2[0];
                this.opt2.Text = list2[1];
                this.opt3.Text = list2[2];
                this.opt4.Text = list2[3];
            }
            catch
            {
                MessageBox.Show("Error: Please Reload Application");
            }
  

            while (value.Count > 0)
            {
                int val = new int();
                val = int.Parse(value.Dequeue());
                list.Add(identifyingAreas.Description_Generator(val));
            }

            for (int i = 0; i < list.Count; i++)
            {
                opt1_combo.Items.Add(list[i]);
                opt1_combo.Items.Add("Family, Logic and Meditation");

                opt2_combo.Items.Add(list[i]);
                opt2_combo.Items.Add("Fun, Events and Parties");

                opt3_combo.Items.Add(list[i]);
                opt3_combo.Items.Add("Gaming, Exploration and Fantasy");

                opt4_combo.Items.Add(list[i]);
                opt4_combo.Items.Add("Food, Culture and Reality");


            }
        }
        //
        private void NewNumber()
        {
            MyNumber = a.Next(0, 9);
            if (!randomList.Contains(MyNumber))
                randomList.Add(MyNumber);
            if (!randomSList.Contains(Convert.ToChar(MyNumber + 65)))            
                randomSList.Add(Convert.ToChar(MyNumber + 65));
        }
        //
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
        //
        private void Btn_Validate_Click(object sender, RoutedEventArgs e)
        {
            if (opt1_combo.SelectedIndex == 0 && opt2_combo.SelectedIndex == 2 && opt3_combo.SelectedIndex == 4 && opt4_combo.SelectedIndex == 6)
            {
                MessageBox.Show("Correct!");
                // Updates users level and progress.
                gamification.UpdateLevels();
                // Displays users level and prgress.
                this.Display_Rank.Content = "Current Rank: " + gamification.getName();
                progressbar.Value = gamification.getProgress();
            }
            else
            {
                MessageBox.Show("Incorrect!");
            }
        }
    }
}
