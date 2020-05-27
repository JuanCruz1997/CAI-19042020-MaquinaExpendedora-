using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class CatalogoLatas
    {
        private List<Lata> _catalogo = new List<Lata>();
        private List<String> _codigos = new List<string>();
        public CatalogoLatas()
        {
            _catalogo.Add(new Lata("CO1", 0.355));
            _catalogo.Add(new Lata("CO2", 0.355));
            _catalogo.Add(new Lata("SP1", 0.220));
            _catalogo.Add(new Lata("SP2", 0.220));
            _catalogo.Add(new Lata("FA1", 0.355));
            _catalogo.Add(new Lata("FA2", 0.355));
            foreach(Lata l in _catalogo)
            {
                if (l.Codigo.Contains("CO"))
                {
                    l.Nombre = "Coca Cola";
                    l.Precio = 35;
                }
                else if (l.Codigo.Contains("SP"))
                {
                    l.Nombre = "Sprite";
                    l.Precio = 33;
                }
                else if (l.Codigo.Contains("FA"))
                {
                    l.Nombre = "Fanta";
                    l.Precio = 50;
                }
                if (l.Codigo.Contains("1"))
                {
                    l.Sabor = "Regular";
                }
                else if (l.Codigo.Contains("2"))
                {
                    l.Sabor = "Zero";
                    l.Precio += 10;
                }
            }
        }
        public List<Lata> GetAll
        {
            get
            {
                return this._catalogo;
            }
        }
    }
}
