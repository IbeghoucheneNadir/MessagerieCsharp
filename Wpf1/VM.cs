using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Wpf1
{
    class VM : INotifyPropertyChanged
    {

        //DECLARATIONS DES VARIABLES
        string dbPath = "C:/Users/mbdse/source/repos/Wpf1/packagesMyDatabase.db3";
        SQLiteConnection connection;
        Database dabatase;
        private ObservableCollection<Personne> contacts;
        private ObservableCollection<Message> messages;
        public event PropertyChangedEventHandler PropertyChanged;
        private List<Message> msg = new List<Message>();
        ClassCommandParameters PersonSelectionChanged;

        public String Message { get; set; }
        //CONSTRUCTEUR(S)
        public VM()
        {
            connection = new SQLiteConnection(dbPath);
            dabatase = new Database();
            Personne p1 = new Personne(1, "alex", "lastname", DateTime.Now, "123");
            Personne p2 = new Personne(2, "fred", "fred", DateTime.Now, "555");
            Personne p3 = new Personne(3, "roman", "gari", DateTime.Now, "456");

            Message m1 = new Message(1, "coucouc", "alex", "fred", DateTime.Now);
            Message m2 = new Message(2, "coucouc", "fred", "frezefzed", DateTime.Now);
            Message m3 = new Message(3, "coucouc", "alex", "fred", DateTime.Now);

            p1.Messages.Add(m1);
            p1.Messages.Add(m2);
            p1.Messages.Add(m3);
            p2.Messages.Add(m1);

            contacts = new ObservableCollection<Personne>();
       /*     foreach (Personne p in dabatase.getListPersonne(connection))
            {
                contacts.Add(p);
            }  */
             contacts.Add(p1);
             contacts.Add(p2);
             contacts.Add(p3);
            addMessageCommand = new ClassCommandParameters(addMessage);
            removePersonneCommand = new ClassCommandParameters(removePersonne);
        }

        //FONCTIONS


       public  ClassCommandParameters addMessageCommand { get; set; }
      
       void addMessage(Object personne)
       {
            if (personne == null) return;
            Personne p = (Personne)personne;
            Message m = new Message(4, Message, "me", p.nickname, DateTime.Now);
            p.Messages.Add(m);
            dabatase.Test(connection);
       }

        public ClassCommandParameters removePersonneCommand { get; set; }

        void removePersonne(Object personne)
        {
            if (personne == null) return;
            Personne p = (Personne)personne;
            contacts.Remove(p);
            dabatase.removePersonne(connection,p);
        }

        //ACCESSEURS


        public ObservableCollection<Personne> Contacts
        {
            get { return contacts; }
            set
            {
                this.contacts = value;
                this.NotifyPropertyChanged("Contacts");
            }
        }
        


        public void NotifyPropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
        

        
        


        
    }
}

  
