using DEINT_2Trim_Examen.MVVM.Models;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DEINT_2Trim_Examen.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class CompraViewModel
    {
        private int contDescuento;
        public List<CompraModel> Compras { get; set; }
        public double Total { get; set; }
        public DateTime Fecha { get; set; }
        public double Subtotal { get; set; }
        public int ContDescuento {
            get { return contDescuento; }
            set { 
                contDescuento = value;
                cambios();
            }
        }
        public double Descuento { get; set; }
        public ICommand ClickCommand { get; set; }
        public CompraViewModel()
        {
            Compras = new List<CompraModel>()
            {
                new CompraModel {
                    Modelo = "Nike Dbreack Sp",
                    Categoria = "Zapatillas Hombre",
                    Precio = 89.95,
                    Imagen = "zapato_1.png"
                },
                new CompraModel {
                    Modelo = "Nike Blazer",
                    Categoria = "Zapatillas Mujer",
                    Precio = 95.95,
                    Imagen = "zapato_2.png"
                }
            };

            Fecha = DateTime.Now;
            Total = 0;
            ContDescuento = 10;

            ClickCommand = new Command(async (s) =>
            {
                switch (s)
                {
                    case "1":
                        await App.Current.MainPage.DisplayAlert("Nike Store", "Pedido guardado", "OK");
                        break;
                    case "2":
                        await App.Current.MainPage.DisplayAlert("Nike Store", "Pagado " + Math.Round(Total, 2) + "€", "OK");
                        break;
                }
            });

            cambios();
        }

        private void cambios() {
            Subtotal = 0;
            foreach (CompraModel compra in Compras)
            {
                Subtotal += compra.Precio;
            }
            Descuento = Subtotal * (ContDescuento / 100.0);
            Total = Subtotal - Descuento;
        }
    }
}
