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
    public class Database
    {
        
        // Instanciation de notre connexion
        //public SQLiteConnection connection;

        // Utilisation de l'API en mode synchrone
        public void Test(SQLiteConnection connection)
        {
            connection.CreateTable<Personne>();
            Personne p1 = new Personne(5,"zekbfzef", "Pierre" ,DateTime.Now,"Date");
            //connection.Insert(p1);
            //connection.Delete(p1);


            //select ex1:
            // List<Personne> personnes = conn.Table<Personne>().Where(x => x.LastName == "TOTO").ToList();
            //select ex2:
            //IEnumerable<Personne> personnes = conn.Query<Personne>("SELECT * FROM People WHERE ...", r1.Id)
        }
        public List<Personne> getListPersonne(SQLiteConnection conne)
        {
            return (List<Personne>)conne.Query<Personne>("SELECT * FROM Personne");
        }

        public void removePersonne(SQLiteConnection connection, Personne p)
        {
            connection.Delete(p);

            //select ex1:
            // List<Personne> personnes = conn.Table<Personne>().Where(x => x.LastName == "TOTO").ToList();

            //select ex2:
            //IEnumerable<Personne> personnes = conn.Query<Personne>("SELECT * FROM People WHERE ...", r1.Id)
        }

    }
}
