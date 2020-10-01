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

namespace CS_ASP_012CheckBoxChallange
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (radioButtonPencil.IsChecked == true)
            {
                labelAnswer.Content = " Pencil, Very Reliable! ";
                imagePencil.Opacity = 100;
                imagePen.Opacity = 0;
                imagePhone.Opacity = 0;
                imagePad.Opacity = 0;
            }
            else if (radioButtonPen.IsChecked == true)
            {
                labelAnswer.Content = " Pen, Nice Choice ";
                imagePencil.Opacity = 0;
                imagePen.Opacity = 100;
                imagePhone.Opacity = 0;
                imagePad.Opacity = 0;
            }
            else if (radioButtonPhone.IsChecked == true)
            {
                labelAnswer.Content = " Phone, Must be from the future ";
                imagePencil.Opacity = 0;
                imagePen.Opacity = 0;
                imagePhone.Opacity = 100;
                imagePad.Opacity = 0;
            }
            else if (radioButtonPad.IsChecked == true)
            {
                labelAnswer.Content = " Pad, Welcome to 2020";
                imagePencil.Opacity = 0;
                imagePen.Opacity = 0;
                imagePhone.Opacity = 0;
                imagePad.Opacity = 100;
            }
        }
    }
}
