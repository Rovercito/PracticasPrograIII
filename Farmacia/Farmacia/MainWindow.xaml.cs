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
using System.IO; 

namespace Farmacia
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string pathName = @"E:\zpracticas\farmacos.txt";
        public MainWindow()
        {
            InitializeComponent();
            verificarCreacion();
            cargarFarmaco();
        }

        public void verificarCreacion()
        {
            try
            {
                if (!File.Exists(pathName))
                {
                    File.CreateText(pathName);
                    MessageBox.Show("El archibo se creo con exito..");
                }
                else
                {
                    MessageBox.Show("El archibo ya existe");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error a crea el archibo");
            }    
        }

        public void cargarFarmaco()
        {
            /* if (File.Exists(pathName))
            {
                txbLista.Text = "";
                StreamReader lectura = File.OpenText(pathName);
                string linea;
                linea = lectura.ReadLine();
                while (linea != null)
                {
                    txbLista.AppendText(linea + "\n");
                    linea = lectura.ReadLine();
                }
                lectura.Close();
            }
            else
            {
                MessageBox.Show("El archibo no existre.. no puede ser!;(");
            }*/

            Farmaco farmaco;
            List<Farmaco> listaFarmacos = new List<Farmaco>();
            string[] datoFarmaco;
            StreamReader lectura = File.OpenText(pathName);
            string linea = lectura.ReadLine();
            while (linea != null)
            {
                datoFarmaco = linea.Split('|');
                farmaco = new Farmaco(datoFarmaco[0], datoFarmaco[1], datoFarmaco[2]);
                listaFarmacos.Add(farmaco);
                linea = lectura.ReadLine();
            }
            lectura.Close();
            DgFarmaco.ItemsSource = listaFarmacos;
        
        }
         

        private void btnInsertar_Click(object sender, RoutedEventArgs e)
        {
            string nombreFarmaco = txbnombre.Text;
            int cantidad = int.Parse(txbcantidad.Text);
            int precio = int.Parse(txbprecio.Text);

            try
            {
                StreamWriter streamWriter = File.AppendText(pathName);
                streamWriter.WriteLine(nombreFarmaco + " | " + cantidad + " | " + precio );
                streamWriter.Close();

                MessageBox.Show("El farmaco se inserto con exito");

            }catch(Exception ex)
            {
                MessageBox.Show("Ocurrio un error al escribir.. me olvide escribir :(");
                Console.WriteLine("error: " + ex.Message);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bool encontrado = false;
                string[] datosFarmacos;
                string buscarfarmaco = TxbBusqueda.Text;
                StreamReader buscar = File.OpenText(pathName);
                string linea = buscar.ReadLine();

                while (linea != null)
                {
                    datosFarmacos = linea.Split(',');
                    if (buscarfarmaco == datosFarmacos[0])
                    {
                        encontrado = true;
                        txbLista.AppendText(linea + "\n");
                        MessageBox.Show("Farmaco encontrado \nNombre:" + datosFarmacos[0] + "\nPrecio: " + datosFarmacos[1] + "\nPrecio: " + datosFarmacos[2]);
                    }
                    linea = buscar.ReadLine();
                }
                buscar.Close();
                //DgFarmaco.ItemsSource = listaFarmacos;
                if(encontrado == false)
                {
                    MessageBox.Show("No se encontro el farmaco");
                }
            }catch(Exception ex)
            {

            }
        }
    }
}
