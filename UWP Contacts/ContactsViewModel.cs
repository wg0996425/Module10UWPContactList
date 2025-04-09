using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWP_Contacts
{
    public class ContactsViewModel
    {
        private ObservableCollection<Contact> contacts = new ObservableCollection<Contact>();

        public ObservableCollection<Contact> Contacts
        {
            get { return contacts; }
            set { contacts = value; }
        }
    }
}
