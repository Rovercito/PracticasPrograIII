using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AppRestaurante
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Ingredient> ingredientList = new List<Ingredient>();
        public MainWindow()
        {
            InitializeComponent();
            ShowMenu();

            List<Menu> menuListTmp = new List<Menu>() { new Menu("Desayuno: ","Ingredientes"), new Menu("Desayuno: ","Ingrediente")  };
            ingredientList.Add(new Ingredient("Desayuno", menuListTmp));
        }

        public void ShowMenu()
        {
            foreach (Ingredient ingredient in ingredientList)
            {
                LbxResult.Items.Add(ingredient.Category.ToUpper());

                foreach(Menu menu in ingredient.Menus)
                {
                    LbxResult.Items.Add(menu.MenuName + " " + menu.Ingredient);
                }
            }
        }

        private void BtnMostrar_Click(object sender, RoutedEventArgs e)
        {
            ShowMenu();
        }
    }
}
