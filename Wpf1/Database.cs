using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLiteCommand = SQLite.SQLiteCommand;
using SQLiteConnection = SQLite.SQLiteConnection;

namespace Wpf1
{
        public sealed class SingletonDB
        {
            static string dbPath;

            static readonly SingletonDB instance = new SingletonDB();
            static SQLiteConnection con;


            private SingletonDB()
            {
                dbPath = "D:/MessagerieCsharp/packagesMyDatabase.db3";
                con = new SQLiteConnection(dbPath);

                // Utilisation de l'API en mode synchrone
                con.CreateTable<Personne>();
                con.CreateTable<User>();
                con.CreateTable<Message>();
                
            }

            public static SingletonDB Instance
            {
                get
                {
                    return instance;
                }
            }

            public static SQLiteConnection GetDBConnection()
            {
                return con;
            }

        public void removePersonne(SQLiteConnection connection, Personne p)
        {

            connection.Delete(p);
            this.getPersonnes(connection);
        }

        public void addPersonne(SQLiteConnection connection, Personne p)
        {

            connection.Insert(p);
            this.getPersonnes(connection);


        }
        public void addUser(SQLiteConnection connection, User u)
        {

            connection.Insert(u);
            
            
        }
        public void addMessage(SQLiteConnection connection, Message m)
        {
            connection.Insert(m);
            this.getPersonnes(connection);

        }

        public ObservableCollection<Personne> getPersonnes(SQLiteConnection connection)
        {
            SQLiteCommand Command = new SQLiteCommand(connection);
            Command.CommandText = "Select * from Personne";
            var list = Command.ExecuteQuery<Personne>();
            ObservableCollection<Personne>  contacts = new ObservableCollection<Personne>();
            foreach (var item in list)
                contacts.Add(item);
            return contacts;
        }
    }
    
}
