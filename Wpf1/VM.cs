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
        
        private ObservableCollection<Personne> contacts;
        //private ObservableCollection<Message> messages;
        public event PropertyChangedEventHandler PropertyChanged;
        private List<Message> msg = new List<Message>();
        //ClassCommandParameters PersonSelectionChanged;

        public String Message { get; set; }
        //CONSTRUCTEUR(S)
        public VM()
        {/*
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
            */
            contacts = SingletonDB.Instance.getPersonnes(SingletonDB.GetDBConnection());

            addMessageCommand = new ClassCommandParameters(addMessage);
            addPersonneCommand = new ClassCommandParameters(addPersonne);
            removePersonneCommand = new ClassCommandParameters(removePersonne);
            
            }

        //FONCTIONS


        public  ClassCommandParameters addMessageCommand { get; set; }
        public ClassCommandParameters addPersonneCommand { get; set; }
        public ClassCommandParameters removePersonneCommand { get; set; }



        /*void addMessage(Object personne)
       {
            Window1 w = new Window1();
            
            if (personne == null) return;
            Personne p = (Personne)personne;
            Message m = new Message(4, Message, "me", p.nickname, DateTime.Now);
            w.MessageBox.Clear();
            p.Messages.Add(m);
       }*/


        void removePersonne(Object personne)
        {
            if (personne == null) return;
            Personne p = (Personne)personne;
            SingletonDB.Instance.removePersonne(SingletonDB.GetDBConnection(), p);
        }

        void addPersonne(Object personne)
        {
            if (personne == null) return;
            Personne p = new Personne((string)personne);
            SingletonDB.Instance.addPersonne(SingletonDB.GetDBConnection(), p);

        }
        void addMessage(Object message)
        {
            if (message == null) return;

            Message m = new Message((string)message);
            SingletonDB.Instance.addMessage(SingletonDB.GetDBConnection(), m);
                              }
        void getPersonnes()
        {
            SingletonDB.Instance.getPersonnes(SingletonDB.GetDBConnection());
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

  
