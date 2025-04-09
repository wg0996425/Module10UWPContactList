using System;
using System.Collections.ObjectModel;
using System.Security.Cryptography.X509Certificates;
using UWP_Contacts.ViewModels;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;

namespace UWP_Contacts.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();

        public MainPage()
        {
            DataContext = this;
            contacts = new ObservableCollection<Contact>();

            InitializeComponent();
        }


        private ObservableCollection<Contact> contacts = new ObservableCollection<Contact>();

        public ObservableCollection<Contact> Contacts
        {
            get { return contacts; }
            set { contacts = value; }
        }


        private void Add_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            string name = NameText.Text;
            string number = NumberText.Text;

            Contact contact = new Contact();
            contact.Name = name;
            contact.Number = number;

            Contacts.Add(contact);
        }

        private void Delete_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Contact contact = ContactsList.SelectedItem as Contact;

            if (contact != null)
            {
                Contacts.Remove(contact);
            }
        }

        private void ContactsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Contact contact = ContactsList.SelectedItem as Contact;

            if (contact != null)
            {
                NameText.Text = contact.Name;
                NumberText.Text = contact.Number;
            }
        }
    }
}
