using Microsoft.VisualBasic; 
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
using System.Resources;
using System.ComponentModel.Design.Serialization;
using System.ComponentModel;
using System.Reflection;


namespace language_resource

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



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //if (txtname.Text != "")
            //{
            //    MessageBox.Show("Registered successfully", "Register", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            //}
            //else
            //{
            //    MessageBox.Show("Please enter the value", "Register", MessageBoxButton.OK, MessageBoxImage.Error);
            //}

            if (txtname.Text == "")
            {
                lblname.Content = "Please enter the name";
            }

            int age = Convert.ToInt32(txtage.Text.ToString());
            if (age < 18)
            {
                lblage.Content = "Age should be above 18";
                txtage.Clear();
            }
            string email = txtemail.Text.ToString();
            char[] chars1 = email.ToCharArray();
            for (int i = 0; i > chars1.Length; i++)
            {
                if (chars1[i] == '@' || chars1[i] == '.')
                {
                    lblemail.Content = "Invalid Email Id";
                    txtemail.Clear();
                }
            }
            string password = txtpass.Text.ToString();
            char[] chars = password.ToCharArray();
            int pswdlength = chars.Length;
            if (pswdlength < 8)
            {
                lblpswd.Content = "PASSWORD SHOULD HAVE 8 CHARACTERS";
                txtpass.Clear();
            }
            if (txtcpass.Text != txtcpass.Text)
            {
                lblcpswd.Content = "PASSWORD ARE NOT MATCHED";
                txtcpass.Clear();
            }


            ResourceManager rm = new ResourceManager("language_resource.properties.language.Resource1", Assembly.GetExecutingAssembly());

            if ((txtname.Text != "") && (txtage.Text != "") && (txtemail.Text != "") && (txtpass.Text != "") && (txtcpass.Text != ""))
            {
                MessageBox.Show(rm.GetString("content1") +  txtname.Text, "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show(rm.GetString("content2") +  txtname.Text, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }







        }
    }
}
