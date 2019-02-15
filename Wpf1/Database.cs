using SQLite;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                dbPath = "C:/Users/mbdse/source/repos/Projet_Csh/Projet_Csh/Test.db3";
                con = new SQLiteConnection(dbPath);

                // Utilisation de l'API en mode synchrone
                con.CreateTable<Personne>();
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
        }
    }
}
