using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Activity3.Models
{
    public class CustomerModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public CustomerModel(int id, string name, int age)
        {
            this.ID = id;
            this.Name = name;
            this.Age = age;
        }
    }
} 