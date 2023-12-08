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
using System.Collections;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string currentValue = "";
        public string history = "";
        string currentOp = null;
        string userTotal = "";
        double[] userValues = new double[3];
        int index = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

       
        private void number_Click(object sender, RoutedEventArgs e)
        {
            if (lblUserInput.Text == userValues[0].ToString() || lblUserInput.Text == userValues[1].ToString())
            {
                lblUserInput.Text = "";
            }
            Button b = (Button)sender; 
            string digit = b.Content.ToString(); //Gets the texts from button click
            lblUserInput.Text  += digit; // sets the userinput label to the value of number being clicked
            
            currentValue = lblUserInput.Text; // sets current/Value to text field

            if (history.Contains(" + ") || history.Contains(" X ") || history.Contains(" - ") || history.Contains(" % ") || history.Contains(" / ") || history.Contains(" ^ "))
            {
                lblTopHistory.Text = history;
            }
            else{
                history = currentValue;
                lblTopHistory.Text = history;
            }

            
            lblUserInput.Text = currentValue;
            
           

        }

        private void equalSign_Click(object sender, RoutedEventArgs e)
        {
            switchCalculation(currentOp);
        }

        private void addition_Click(object sender, RoutedEventArgs e)
        {

            double num = Convert.ToDouble(currentValue); // used to get previous value before op click

            if (userValues[0] == 0 || userValues[1] == 0)
            {
                userValues[index] = num; // saves previous value in array of 2
                index = index + 1;
            } 

            if (currentOp != null)
            { 
                switchCalculation(currentOp); // If the array is full and there is an operator assigned I want to do sthe calculation before hand
                index = 0;
                history = history + userValues[1];
                Array.Clear(userValues, 0, userValues.Length);
            }
          
            //Button b = (Button) sender;
            //string add = b.Content.ToString(); // get the + sign 
            string add = " + ";
            currentOp = add ; // set currentOp = + sign
            history = history + currentOp; 
            lblTopHistory.Text = history;
            lblUserInput.Text = currentValue;
           
        }

        private void subtraction_Click(object sender, RoutedEventArgs e)
        {
            double num = Convert.ToDouble(currentValue); // used to get previous value before op click

            if (userValues[0] == 0 || userValues[1] == 0)
            {
                userValues[index] = num; // saves previous value in array of 2
                index = index + 1;
            }

            if (currentOp != null)
            {
                switchCalculation(currentOp); // If the array is full and there is an operator assigned I want to do sthe calculation before hand
                index = 0;
                history = history + userValues[1];
                Array.Clear(userValues, 0, userValues.Length);
            }

            //Button b = (Button) sender;
            //string add = b.Content.ToString(); // get the + sign 
            string sub = " - ";
            currentOp = sub; // set currentOp = + sign
            history = history + currentOp;
            lblTopHistory.Text = history;
            lblUserInput.Text = currentValue;
        }

        private void multiplication_Click(object sender, RoutedEventArgs e)
        {
            double num = Convert.ToDouble(currentValue); // used to get previous value before op click

            if (userValues[0] == 0 || userValues[1] == 0)
            {
                userValues[index] = num; // saves previous value in array of 2
                index = index + 1;
            }

            if (currentOp != null)
            {
                switchCalculation(currentOp); // If the array is full and there is an operator assigned I want to do sthe calculation before hand
                index = 0;
                history = history + userValues[1];
                Array.Clear(userValues, 0, userValues.Length);
            }

            //Button b = (Button) sender;
            //string add = b.Content.ToString(); // get the + sign 
            string multi = " X ";
            currentOp = multi; // set currentOp = + sign
            history = history + currentOp;
            lblTopHistory.Text = history;
            lblUserInput.Text = currentValue;
        }

        private void division_Click(object sender, RoutedEventArgs e)
        {

            double num = Convert.ToDouble(currentValue); // used to get previous value before op click

            if (userValues[0] == 0 || userValues[1] == 0)
            {
                userValues[index] = num; // saves previous value in array of 2
                index = index + 1;
            }

            if (currentOp != null)
            {
                switchCalculation(currentOp); // If the array is full and there is an operator assigned I want to do sthe calculation before hand
                index = 0;
                history = history + userValues[1];
                Array.Clear(userValues, 0, userValues.Length);
            }

            //Button b = (Button) sender;
            //string add = b.Content.ToString(); // get the + sign 
            string div = " / ";
            currentOp = div; // set currentOp = + sign
            history = history + currentOp;
            lblTopHistory.Text = history;
            lblUserInput.Text = currentValue;

        }

        private void modulus_Click(object sender, RoutedEventArgs e)
        {
            double num = Convert.ToDouble(currentValue); // used to get previous value before op click

            if (userValues[0] == 0 || userValues[1] == 0)
            {
                userValues[index] = num; // saves previous value in array of 2
                index = index + 1;
            }

            if (currentOp != null)
            {
                switchCalculation(currentOp); // If the array is full and there is an operator assigned I want to do sthe calculation before hand
                index = 0;
                history = history + userValues[1];
                Array.Clear(userValues, 0, userValues.Length);
            }

            //Button b = (Button) sender;
            //string add = b.Content.ToString(); // get the + sign 
            string mod = " % ";
            currentOp = mod; // set currentOp = + sign
            history = history + currentOp;
            lblTopHistory.Text = history;
            lblUserInput.Text = currentValue;
        }

        private void exponential_Click(object sender, RoutedEventArgs e)
        {
            double num = Convert.ToDouble(currentValue); // used to get previous value before op click

            if (userValues[0] == 0 || userValues[1] == 0)
            {
                userValues[index] = num; // saves previous value in array of 2
                index = index + 1;
            }

            if (currentOp != null)
            {
                switchCalculation(currentOp); // If the array is full and there is an operator assigned I want to do sthe calculation before hand
                index = 0;
                history = history + userValues[1];
                Array.Clear(userValues, 0, userValues.Length);
            }

            //Button b = (Button) sender;
            //string add = b.Content.ToString(); // get the + sign 
            string exp = " ^ ";
            currentOp = exp; // set currentOp = + sign
            history = history + currentOp;
            lblTopHistory.Text = history;
            lblUserInput.Text = currentValue;
        }

        private void clearSign_Click(object sender, RoutedEventArgs e)
        {
            lblTopHistory.Text = "";
            lblUserInput.Text = "";
            userTotal = "";
            currentValue = "";
            history = "";
            Array.Clear(userValues, 0, userValues.Length);
            currentOp = null;
            index = 0;

        }


    private void doAddition()
        {
            double Total = userValues[0] + userValues[1];
            userTotal = Convert.ToString(Total);
            lblUserInput.Text = userTotal;
            lblTopHistory.Text = userTotal;
        }
        private void doSubtraction()
        {
            double Total = userValues[0] - userValues[1];
            userTotal = Convert.ToString(Total);
            lblUserInput.Text = userTotal;
            lblTopHistory.Text = userTotal;
        }

        private void doMultiplication()
        {
            double Total = userValues[0] * userValues[1];
            userTotal = Convert.ToString(Total);
            lblUserInput.Text = userTotal;
            lblTopHistory.Text = userTotal;
        }
        private void doDivision()
        {
            double Total = userValues[0] / userValues[1];
            userTotal = Convert.ToString(Total);
            lblUserInput.Text = userTotal;
            lblTopHistory.Text = userTotal;
        }

        private void doModulus()
        {
            double Total = userValues[0] % userValues[1];
            userTotal = Convert.ToString(Total);
            lblUserInput.Text = userTotal;
            lblTopHistory.Text = userTotal;
        }

        private void doExponential()
        {
            double Total = userValues[0];
            for (double i = 0; i <= userValues[1]-2; i++)
            {
                Total *= userValues[0];           
            }
            userTotal = Convert.ToString(Total);
            lblUserInput.Text = userTotal;
            lblTopHistory.Text = userTotal;

        }

        private void switchCalculation(string currentOpp)
        {
            if (userValues[1] == 0 && lblTopHistory.Text.Contains(" + ") || userValues[1] == 0 && lblTopHistory.Text.Contains(" - ") || userValues[1] == 0 && lblTopHistory.Text.Contains(" X ") || userValues[1] == 0 && lblTopHistory.Text.Contains(" % ") || userValues[1] == 0 && lblTopHistory.Text.Contains(" ^ ") || userValues[1] == 0 && lblTopHistory.Text.Contains(" / "))
            {
                userValues[1] = Convert.ToDouble(lblUserInput.Text);
            }

            switch (currentOpp)
            {
                case " + ":
                    doAddition();
                    break;
                case " - ":
                    doSubtraction();
                    break;
                case " / ":
                    doDivision();
                    break;
                case " X ":
                    doMultiplication();
                    break;
                case " ^ ":
                    doExponential();
                    break;
                case " % ":
                    doModulus();
                    break;
                default:
                    Console.WriteLine("Something went wrong in the equalSign Switch");
                    break;

            }
        }
    }
}