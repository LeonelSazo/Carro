using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrito.Clases
{
    internal class Carro
    {
        public String Marca { get; }

        public int Modelo { get; }

        public String Color { get; set; }

        private int Encendido = 0;
        private int velocidad_actual = 0;
        
        public int MAXVELOCIDAD { get;}


        public Carro(string _marca, int _modelo, string _color, int _velmax)
        {
            Marca = _marca;
            Modelo = _modelo;
            Color = _color;
            MAXVELOCIDAD= _velmax;
            Encendido = 0;
            this.velocidad_actual=0;
        }

        public string acelerar()
        {
            if (Encendido == 0)
            {
                return $"El carro esta apagado, asi no se puede";
            }

            string mensaje = "";
            if (velocidad_actual <= MAXVELOCIDAD)
            {
                mensaje = $" Vas a {velocidad_actual}";
                velocidad_actual += 10;
            }
            else
            {
                velocidad_actual = MAXVELOCIDAD;
                mensaje = $"Llegaste a la maxima velocidad";
            }
            return mensaje;
        }

        public string desacelerar()
        {
            string mensaje = "";
            if(velocidad_actual >0)
            {
                velocidad_actual-= 10;
                mensaje = $"Vas a {velocidad_actual}";
            }
            else
            {
                mensaje = "El carro no esta en movimiento";
            } return mensaje;
        }

        public string frenar()
        {
            velocidad_actual = 0;
            string mensaje = " El carro se detuvo por completo \n";
            return mensaje;
        }

        public string bocina()
        {
            string mensaje = $"Piiiiiip Piiiiipp  Chuuchooo \n";
            return mensaje;
        }


        public string GetVelocidadActual()
        {
            return $"\n Vamos a {velocidad_actual} KPH \n";
        }

        public string EncenderMotor()
        {
            string mensaje = "";
            if (Encendido == 0)
            {
                Encendido = 1;
                mensaje = "Brurururururu Carro encendido \n";
                velocidad_actual = 0;
            } else
            {
                mensaje = "Ups el carro ya estaba encendido \n";
            } return mensaje;
                
        }

        public string ApagarMotor()
        {
            string mensaje = "";
            if (Encendido == 1)
            {
                Encendido = 0;
                mensaje = "El motor se ha apagado \n";
                velocidad_actual =0;
            }else
            {
                mensaje = "El motro ya esta apagado";

            }return mensaje;
        }

        


    }
}
