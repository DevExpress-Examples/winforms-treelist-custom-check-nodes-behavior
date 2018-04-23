using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Example
{
    public class Customer : INotifyPropertyChanged
    {
        string firstName;
        int id;
        int parentID;

        public Customer()
        {
            FirstName = "FirstName";
            ParentID = 0;
            id = 0;
        }

        public Customer(string firstName, int parentID, int id)
        {
            FirstName = firstName;
            ParentID = parentID;
            this.id = id;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if(PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string FirstName {
            get { return firstName; }
            set {
                if(value != firstName)
                {
                    firstName = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public int ID {
            get { return id; }
        }
        public int ParentID {
            get { return parentID; }
            set {
                if(value != parentID)
                {
                    parentID = value;
                    NotifyPropertyChanged();
                }
            }
        }
    }
}