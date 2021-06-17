using System;

namespace dev_homework07
{
class Automovil{

        public double Velocidad {get;set;}
        public bool Encendido { get; set; }
        public string TipoLlantas {get;set;}
        public int NumeroLlantas {get;set;}
        public int NumeroPuertas {get;set;}
        public string TipoMotor {get;set;}
        public string Transmision {get;set;} //Automatico,Standard,
        public string Color {get;set;}
        public string MaterialAsientos {get;set;}
        public int NumeroAsientos {get;set;}
        private double _kilometraje {get;set;}
        public string TipoFaros{get;set;}
        public decimal Precio {get;set;}

        public void Encender(){}
        public void Apagar(){}
        public void Frenar(){}
        virtual public void Acelerar(){
            Velocidad = Velocidad + 1;
        }
        public void GirarDerecha(){
            for(int i=0; i < (int)_kilometraje; i++){
                Console.Write(" ");
            }
            System.Threading.Thread.Sleep(500/(int)Velocidad);
            Console.Write("*");
           Console.WriteLine("");
        }
        public void GirarIzquiereda(){}
        public void AvanzarRecto(){
            for(int i=0; i < (int)_kilometraje; i++){
                Console.Write(" ");
            }                       
            var kilometrajeAnterioor = _kilometraje;
            var nuevoRecorrido = kilometrajeAnterioor + (1 * Velocidad);
            _kilometraje = nuevoRecorrido;
            for(int i=0; i < (int)_kilometraje - (int)kilometrajeAnterioor; i++){
                System.Threading.Thread.Sleep(500/(int)Velocidad);
                Console.Write("*");
            }
            Console.WriteLine("");
        }
        public void Reversa(){
            _kilometraje = _kilometraje + 0.5;
        }

        public void VerVelocidad(){
            Console.WriteLine($" Vas a: { Velocidad } Km/hr");
        }
    
    }



}