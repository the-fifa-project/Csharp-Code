using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifaApi
{
    class User
    {
        public string Name { get; set; }

        public int Currency { get; set; }

        public User(int currency, string name)
        {
            Name = name;
            Currency = currency;
        }

    }
}
