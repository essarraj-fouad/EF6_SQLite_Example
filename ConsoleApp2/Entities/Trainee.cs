using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities
{
    public class Trainee : User
    {
        private string name;

        public Trainee() : this(null)
        {
           
        }

        public Trainee(string TraineeDirctoryName)
        {
            if(!string.IsNullOrEmpty(TraineeDirctoryName))
            {
                string[] names = TraineeDirctoryName.Split(' ');
                if (names.Count() > 0)
                    this.FirstName = names[0];
                if (names.Count() > 1)
                    this.LastName = names[1];
                if (names.Count() == 0)
                    this.FirstName = TraineeDirctoryName;
            }
            this.DateOfBirth = DateTime.Now;

        }

        public Group Group { set; get; }
    }
}
