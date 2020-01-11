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

namespace first_shop_page
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        private void enter_Click(object sender, RoutedEventArgs e)
        {
            if (Textlogin.Text.Length > 0) 
            {
                if (password.Password.Length > 0)          
                {                   
                    
                    if (.Rows.Count > 0)     
                    {
                        MessageBox.Show("Пользователь авторизовался");       
                    }
                    else MessageBox.Show("Пользователя не найден"); 
                }
                else MessageBox.Show("Введите пароль"); 
            }
            else MessageBox.Show("Введите логин"); 
        }
        private void regin_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
