using GApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities
{
    public class Group : BaseEntity
    {

        public Group()
        {

        }
        public Group(string Name)
        {
            this.Name = Name;
            this.Reference = this.Name;
        }

        public string Code { set; get; }
        public string Name { set; get; }
    }
}
