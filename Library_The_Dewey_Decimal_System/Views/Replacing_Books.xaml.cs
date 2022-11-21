using Library_The_Dewey_Decimal_System.Controllers;
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
    /// Interaction logic for Replacing_Books.xaml
    /// </summary>
    public partial class Replacing_Books : Window
    {
        // Queue used to read data into Dictionary.
        private Queue<string> value = new Queue<string>();
        private Queue<int> key = new Queue<int>();
        // Dictionary used to store callnumbers.
        Dictionary<int, string> CallNumberList = new Dictionary<int, string>();
        // Variables
        private int tmp = new int();
        readonly ReplacingBooks replacingBooks = new ReplacingBooks();
        // Random number genorator to create callnumbers
        Random random = new Random();
        // Gamification form.
        GamificationData gamification = new GamificationData();
        List<string> Sortedlist = new List<string>();
        List<Object> UserSortedlist = new List<Object>();

        public Replacing_Books()
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
            CallNumberList.Clear();
            CallNumberListView.Items.Clear();           
            Sortedlist.Clear();
            UserSortedlist.Clear();
            GridView view = new GridView();

            GridViewColumn col1 = new GridViewColumn();
            col1.Header = "CallNumber";
            col1.DisplayMemberBinding = new Binding("CallNumber");
            view.Columns.Add(col1);
            CallNumberListView.View = view;

            // Creates 10 random Callnumbers which are then added to a Dictoionary.
            for (int i = 0; i < 10; i++)
            {
                key.Enqueue(replacingBooks.IDGenerator());
                value.Enqueue(replacingBooks.CallNumber_Generator().ToString());
                CallNumberList.Add(key.Dequeue(), value.Dequeue());

            }
            // Adds callnumbers to listView.
            foreach (KeyValuePair<int, string> callnumber in CallNumberList)
            {
                CallNumberListView.Items.Add(new CallNumberS(callnumber.Value));
                Sortedlist.Add(callnumber.Value);               

            }
        }
        private void Sort_Validation()
        {
            // Sort
            Sortedlist.Sort();       
            int count = 0;
            foreach (CallNumberS item in CallNumberListView.Items)
            {                
                UserSortedlist.Add(item.CallNumber);

            }
            for (int i = 0; i < Sortedlist.Count; i++)
            {                
                Console.WriteLine(Sortedlist[i] + " || " + UserSortedlist[i]);
                if (Sortedlist[i].Equals(UserSortedlist[i]))
                {
                    count++;
                }
            }            
            // Checks if list is sorted correcntly.
            if (count == Sortedlist.Count())
            {
                // Updates users level and progress.
                gamification.UpdateLevels();
                // Displays relevent message to user.
                MessageBox.Show("Order is Correct! WellDone");
                // Displays users level and prgress.
                this.Display_Rank.Content = "Current Rank: " + gamification.getName();
                progressbar.Value = gamification.getProgress();
            }
            else
            {
                // Displays relevent message to user
                MessageBox.Show("Incorrect, Try Again.");
                // Resets the List
                InitializeList();

            }
        }
        // Moves selected callnumber in list upwards. Allows user to sort the listView
        private void Update_List()
        {
            try
            {
                var currentIndex = CallNumberListView.SelectedIndex;
                var item = CallNumberListView.Items[currentIndex];
                if (currentIndex > 0)
                {
                    CallNumberListView.Items.RemoveAt(currentIndex);
                    CallNumberListView.Items.Insert(currentIndex - 1, item);
                }
            }
            catch
            {
                MessageBox.Show("Please Select an Item First!");
            }
        }

        private void Btn_Submit_Click(object sender, RoutedEventArgs e)
        {
            Sort_Validation();
        }

        private void Btn_Validate_Click(object sender, RoutedEventArgs e)
        {
            Update_List();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}
