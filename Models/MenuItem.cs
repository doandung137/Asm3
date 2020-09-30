using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FoodASM.Models
{
    class MenuItem
    {
        public char icon;
        public string name;
        public string des; 
        public MenuItem(char icon, string name, string des)
        {
            Icon = icon;
            Name = name;
            Des = des;
        }

        public char Icon
        {
            get => icon;
            set => icon = value;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public string Des
        {
            get => des;
            set => des = value;
        }
    }
}
