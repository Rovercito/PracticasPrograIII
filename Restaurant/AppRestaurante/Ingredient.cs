using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRestaurante
{
    class Ingredient
    {
        public string Category { get; set; }

        List<Menu> MenuList;

        public List<Menu> Menus { get { return MenuList; } }

        public Ingredient(string category)
        {
            Category = category;
            MenuList = new List<Menu>();
        }

        public Ingredient(string category, List<Menu> menus)
        {
            Category = category;
            MenuList = new List<Menu>();
        }

        public void AddMenu(List<Menu> newList)
        {
            MenuList = newList;
        }
    }
}
