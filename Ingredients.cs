using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drinks_Machine
{
    public class Ingredients
    {
        public string Name { get; set; } 
        public string Image { get; set; }

        public Ingredients(string name, string image)
        {
            Name = name;
            Image = image;
        }

    }

}
