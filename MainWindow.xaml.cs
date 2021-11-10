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
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;



namespace ParkingLot
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var Valores = new List<Sexo>();
            Valores.Add(new Sexo() { Id = "Masculino", Nombre = "Masculino" });
            Valores.Add(new Sexo() { Id = "Femenino", Nombre = "Femenino" });

            //cmbSexo.DataSource = Valores;
            //cmbSexo.DisplayMember = "Value";
           // cmbSexo.ValueMember = "Index";

        }
        IFirebaseConfig firebase = new FirebaseConfig()
        {
            AuthSecret = "2Wh3EfKQUmi9VqsLo1ZyQXwGl7fr6d7tOger4Wo9",
            BasePath = "https://parkinglot-4bbda-default-rtdb.firebaseio.com/",

        };
        IFirebaseClient cliente;

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

public class Sexo
{
    public string Id { get; set; }
    public string Nombre { get; set; }
}