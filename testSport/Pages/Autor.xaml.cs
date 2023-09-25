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

namespace testSport.Pages
{
    /// <summary>
    /// Логика взаимодействия для Autor.xaml
    /// </summary>
    public partial class Autor : Window
    {
        public Autor()
        {
            InitializeComponent();
            Classes.dbconnect.modeldb = new Models.testsportEntities();
        }

        private void autorClick(object sender, RoutedEventArgs e)
        {
            var userobj = Classes.dbconnect.modeldb.users.FirstOrDefault(x => login.Text == x.login && password.Password == x.password);

            if(userobj.id_type == 1)
            {
                Users users = new Users();
                this.Visibility = Visibility.Hidden;
                users.Show();
            }
            if (userobj.id_type == 2)
            {
                Manager manager = new Manager();
                this.Visibility = Visibility.Hidden;
                manager.Show();
            }
            if (userobj.id_type == 3)
            {
                Client client = new Client();
                this.Visibility = Visibility.Hidden;
                client.Show();
            }
        }
    }
    }

