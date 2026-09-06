using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

namespace Tutorial_7.Views.CustomUserControls
{
    /// <summary>
    /// Interaction logic for ClearableTextBox.xaml
    /// </summary>
    public partial class ClearableTextBox : UserControl
    {
        public ClearableTextBox()
        {
            InitializeComponent();
        }
        private string placeHolder;

        public string Placeholder
        {
            get 
            { 
                return placeHolder;
            }
            set
            { 
                placeHolder = value;
                this.textBoxPlaceholder.Text = placeHolder; //Dont do this <<< this should be done with onproperty changed.
                // Other video does OnPropertyChanged, but I will do it this way for now.
                this is HttpWebRequest i left off https://www.youtube.com/watch?v=V86kaIBBcRk
            }
        }


        private void btnCLear_Click(object sender, RoutedEventArgs e)
        {
            customTxtInputControl.Clear();
            customTxtInputControl.Focus(); //puts cursor back in the box.
        }

        private void customTxtInputControl_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(string.IsNullOrEmpty(customTxtInputControl.Text))             {
                textBoxPlaceholder.Visibility = Visibility.Visible;
            }
            else
            {
                textBoxPlaceholder.Visibility = Visibility.Collapsed;
            }   
        }
    }
}
