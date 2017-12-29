using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseContext db = new DatabaseContext();

            db.Trainees.Add(new App.Entities.Trainee());
                db.SaveChanges();
               

        }
    }
}
