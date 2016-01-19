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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _05_ConsoleUpgrades
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }


        private void userInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            Console.ReadLine();
            string DateOfBirth = Console.ReadLine();

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            string DateOfBirth = userInput.Text;

            DateTime dateOfBirth = DateTime.Parse(DateOfBirth);

            DateTime todaysDate = DateTime.Today;

            TimeSpan theDifference = todaysDate.Subtract(dateOfBirth);

            double totalDays = theDifference.Days;

            double years = totalDays / 365.25;
            double wholeyears = Math.Floor(years);
            int pubyears = Convert.ToInt32(wholeyears);

            double yearsRemainder = totalDays % 365.25;
            double weeks = yearsRemainder / 7;
            double wholeweeks = Math.Floor(weeks);
            int pubweeks = Convert.ToInt32(wholeweeks);

            double weeksRemainder = weeks % 7;
            double days = weeksRemainder / 24;
            double wholedays = Math.Floor(days);
            int pubdays = Convert.ToInt32(wholedays);

            userBirthday.Text = ("You are " + pubyears + " years, " + pubweeks + " weeks, " + pubdays + " days old.");

        }


    }
}
