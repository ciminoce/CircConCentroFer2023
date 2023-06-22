using System;
using System.Text;

namespace CircConCentroFer2023.Entidades
{
    public class Circunferencia
    {
        private int _radio;
        public int Radio { get
            {
                return _radio;
            }
            set
            {
                _radio=SetRadio(value);
            }
        }
        public Punto Centro { get; set; }

        public Circunferencia(int radio, Punto centro)
        {
            Radio =SetRadio(radio);
            Centro = centro;
        }
        public override string ToString()
        {
            return $"Circunferencia de radio {Radio} y centro {Centro.ToString()}";
        }

        public double GetPerimetro()=>2*Math.PI*Radio;
        public double GetSuperficie()=>Math.PI*Math.Pow(Radio,2);

        public string MostrarInfo()
        {
            StringBuilder sb= new StringBuilder();
            sb.AppendLine($"Superficie: {GetSuperficie()}");
            sb.AppendLine($"Perímetro.: {GetPerimetro()}");
            return sb.ToString();
        }
        public bool PuntoPerteneceACircunferencia(Punto punto)
        {
            return Centro.GetDistanciaOtroPunto(punto) <= Radio;
        }
        public bool Validar()
        {
            return Radio > 0;
        }

        private int SetRadio(int radio)
        {
            if (radio <= 0)
            {
                throw new ArgumentOutOfRangeException("Radio no válido debe ser mayor a 0");
            }
            return radio;
        }
    }
}
