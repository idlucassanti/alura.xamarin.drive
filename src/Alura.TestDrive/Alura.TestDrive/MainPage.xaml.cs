using Alura.TestDrive.Models;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Alura.TestDrive
{
    public partial class MainPage : ContentPage
    {
        public List<VeiculoModel> Veiculos { get; set; }
        public MainPage()
        {
            InitializeComponent();

            Veiculos = new List<VeiculoModel>();

            Veiculos.Add(new VeiculoModel(1, "Azera", 60000));
            Veiculos.Add(new VeiculoModel(2, "HB20", 55000));
            Veiculos.Add(new VeiculoModel(3, "Fiesta Turno", 45000));

            BindingContext = this;
        }
    }
}
