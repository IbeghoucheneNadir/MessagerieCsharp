using System;
using System.IO;
using System.Reflection;
using System.ComponentModel;
using System.Collections.ObjectModel;
using SQLite;

namespace Wpf1
{
    [Table("Personne")]
    public class Personne : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        //    [Sauvegarde()]

        [Column("ID")]
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        //    [Sauvegarde()]
        [Column("Nickname")]
        public string nickname { get; set; }
        [Column("Lastname")]
        public string lastname { get; set; }
        [Column("LastSeen")]
        public DateTime lastSeen { get; set; }
        [Column("Pubkey")]
        public string pubkey { get; set; }

        public Personne()
        {

        }
        public Personne(int id, String nickname, String lastname, DateTime lastSeen, String pubkey)
        {
            messages = new ObservableCollection<Message>();
            this.id = id;
            this.nickname = nickname;
            this.lastname = lastname;
            this.lastSeen = lastSeen;
            this.pubkey = pubkey;
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
            return "Personne " + id + " " + nickname + " " + lastname + " " + lastSeen + " " + pubkey;
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



