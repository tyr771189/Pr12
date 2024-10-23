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

namespace Interface
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Classes.UsersContext UsersContext = new Classes.UsersContext();
        public Classes.MessagesContext MessagesContext = new Classes.MessagesContext();
        public int IdSelectUser = -1;
        public static MainWindow mainWindow;

        public MainWindow()
        {
            InitializeComponent();

            mainWindow = this;

            LoadUser();
        }

        public void SelectUser(Models.Users user)
        {
            if (user != null)
                IdSelectUser = UsersContext.AllUsers.FindIndex(x => x == user);

            ParentMessage.Children.Clear();

            foreach (Classes.MessagesContext messages in Classes.MessagesContext.AllMessages.FindAll(x => x.UserId == IdSelectUser))
                ParentMessage.Children.Add(new Elements.Messages(messages));

            BlockMessage.IsEnabled = true;
        }
        public void LoadUser()
        {
            foreach (Models.Users user in UsersContext.AllUsers)
                ParentUser.Children.Add(new Elements.Users(user));
        }
        private void SendMessage(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (IdSelectUser == -1)
                    return;

                Classes.MessagesContext newMessages = new Classes.MessagesContext(Message.Text, DateTime.Now, IdSelectUser);
                newMessages.Save();
                Message.Text = String.Empty;
                SelectUser(null);
            }
        }
    }
}
