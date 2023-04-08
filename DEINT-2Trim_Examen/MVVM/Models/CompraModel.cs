using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_2Trim_Examen.MVVM.Models
{
    [AddINotifyPropertyChangedInterface]
    public class CompraModel
    {
        public string Modelo { get; set; }
        public string Categoria { get; set; }
        public string Imagen { get; set; }
        public double Precio { get; set; }
    }
}
