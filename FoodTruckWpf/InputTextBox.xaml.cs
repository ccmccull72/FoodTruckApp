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

namespace FoodTruckWpf
{
   /// <summary>
   /// Interaction logic for InputTextBox.xaml
   /// </summary>
   public partial class InputTextBox : Window
   {
      public string inputText = "";

      public InputTextBox(string message)
      {
         InitializeComponent();
         messageLabel.Content = message;
         truckNameTextBox.Focus();
      }

      private void okButton_Click(object sender, RoutedEventArgs e)
      {
         inputText = truckNameTextBox.Text;
         Close();
      }

      private void cancelButton_Click(object sender, RoutedEventArgs e)
      {
         Close();
      }
   }
}
