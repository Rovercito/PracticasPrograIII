using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRestaurante
{
     class Menu
    {
        public string MenuName { get; set; }
        public string Ingredient { get; set; }


        public Menu(string name, string ingredient)
        {
            MenuName = name;
            Ingredient = ingredient;
        }
    }
}
