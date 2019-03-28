using System;
using System.IO;
using System.Reflection;
using System.ComponentModel;
using System.Collections.ObjectModel;
using SQLite;

namespace Wpf1
{
    [Table("User")]
    public class User : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        //    [Sauvegarde()]

        [Column("ID")]
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        //    [Sauvegarde()]
        [Column("Name")]
        public string name { get; set; }
        [Column("Password")]
        public string password { get; set; }

        public User(int id, String name, String password)
        {
            messages = new ObservableCollection<Message>();
            this.id = id;
            this.name = name;
            this.password = password;
        }
        public User()
        { }
            public User(String nickname)
        {
            messages = new ObservableCollection<Message>();
            this.name = nickname;

        }
        private ObservableCollection<Message> messages;
        [Ignore]
        public ObservableCollection<Message> Messages
        {
            get { return messages; }
            set
            {
                this.messages = value;
                this.NotifyPropertyChanged("Messages");
            }
        }

        public class Sauvegarde : Attribute
        {
            public Sauvegarde()
            { }
        }

        public override string ToString()
        {
            return "User " + id + " " + name + " " + password;
        }

        public void maMethode(Object obj)
        {

            Type type = obj.GetType();
            PropertyInfo[] properties = type.GetProperties();
            using (StreamWriter writetext = new StreamWriter("C:\\Users\\mbdse\\source\\repos\\ConsoleApp1\\ConsoleApp1\\monFichier.txt"))

                foreach (PropertyInfo mInfo in type.GetProperties())
                {
                    foreach (Attribute attr in Attribute.GetCustomAttributes(mInfo))
                    {
                        if (attr.GetType() == typeof(Sauvegarde))
                            writetext.WriteLine(mInfo.Name);
                        Console.WriteLine(mInfo.Name);
                    }
                }
        }

        public void NotifyPropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
    
}


/*   void parcourSauvegarde(string chemain)

   {
       using (StreamReader readtext = new StreamReader("C:\\Users\\mbdse\\source\\repos\\ConsoleApp1\\ConsoleApp1\\Program.cs"))
       {

           string line;

           while ((line = readtext.ReadLine()) != null)
           {
               string monText = readtext.ReadLine();
               Console.WriteLine(monText);
           }
       }
   }

}*/



