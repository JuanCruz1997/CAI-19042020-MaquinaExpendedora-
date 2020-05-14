using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalExceptions;

namespace ClassLibrary
{
    public class Expendedora
    {
        private List<Lata> _latas = new List<Lata>();
        private string _proveedor;
        private int _capacidad;
        private double _dinero;
        private bool _encendida;
        public Expendedora(string proveedor, int capacidad)
        {
            this._proveedor = proveedor;
            this._capacidad = capacidad;
            _latas.Add(new Lata("CO1", 0.355));
            _latas.Add(new Lata("CO2", 0.355));
            _latas.Add(new Lata("SP1", 0.220));
            _latas.Add(new Lata("SP2", 0.220));
            _latas.Add(new Lata("FA1", 0.355));
            _latas.Add(new Lata("FA2", 0.355));
        }
        public List<Lata> Latas
        {
            get
            {
                return this._latas;
            }
        }
        public double Dinero
        {
            get
            {
                return this._dinero;
            }
        }
        public Boolean Encendida
        {
            set
            {
                _encendida = value;
            }
            get
            {
                return this._encendida;
            }
        }
        public void AgregarLata(Lata lata)
        {
            if (GetCapacidadRestante() > 0)
            {
                this._latas.Add(lata);
            }
            else
            {
                throw new CapacidadInsuficienteException();
            }
        }
        public Lata ExtraerLata(string codigo, double dinero)
        {
            Lata extraccion = null;
            foreach (Lata l in this._latas)
            {
                if (codigo == l.Codigo)
                {
                    if (dinero == l.Precio || dinero > l.Precio)
                    {
                        extraccion = l;
                        this._latas.Remove(l);
                        this._dinero += dinero;
                        break;
                    }
                    else
                    {
                        throw new DineroInsuficienteException((l.Precio-dinero).ToString());
                    }
                }
            }
            if (extraccion != null)
            {
                return extraccion;
            }
            else
            {
                throw new SinStockException();
            }
        }
        public string GetBalance()
        {
            return "Dinero en máquina: " + this._dinero + "\nStock de latas: " + this._latas.Count;
        }
        public int GetCapacidadRestante()
        {
            return this._capacidad - this._latas.Count;
        }
        public void EncenderMaquina()
        {
            _encendida = true;
        }
        public Boolean EstaVacia()
        {
            if (this._latas.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
