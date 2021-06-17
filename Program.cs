using System;

namespace dev_homework07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Abstracción
            Console.WriteLine("BOCHO");
            Automovil bocho = new Automovil();
            bocho.NumeroAsientos = 5;            
            bocho.Encender();
            bocho.Acelerar();            
            bocho.AvanzarRecto();
            bocho.VerVelocidad();

            Console.WriteLine("FERRARI");
            Deportivo ferrari = new Deportivo();
            ferrari.NumeroAsientos = 2;
            ferrari.Descapotable = true;
            ferrari.TieneTurbo = true;
            ferrari.Color = "Rojo";
            ferrari.Encender();
            ferrari.Acelerar();
            ferrari.Acelerar();
            ferrari.Acelerar();
            ferrari.VerVelocidad();

             ferrari.AvanzarRecto();
             ferrari.AvanzarRecto();
             ferrari.AvanzarRecto();
             ferrari.GirarDerecha();
             ferrari.GirarDerecha();
             ferrari.Acelerar();
             ferrari.Acelerar();
             ferrari.AvanzarRecto();
             ferrari.AvanzarRecto();
             ferrari.GirarDerecha();
             ferrari.GirarDerecha();
             ferrari.GirarDerecha();
             ferrari.GirarDerecha();
             ferrari.Acelerar();
             ferrari.Acelerar();
             ferrari.Acelerar();
             ferrari.Acelerar();
             ferrari.AvanzarRecto();
             ferrari.AvanzarRecto();
             ferrari.AvanzarRecto();

            Console.WriteLine("WINDSTARD");
            MiniVan windstard = new MiniVan();
            windstard.Color = "Rojo";
            windstard.NumeroAsientos = 8;
            windstard.TieneTerceraFilaDeAsientos = true;
            windstard.CentroDeEntretenimiento = true;
            windstard.Encender();
            windstard.Acelerar();
            windstard.Acelerar();
            windstard.Acelerar();
            windstard.VerVelocidad();
            

        }

        class Deportivo:Automovil{
            public bool Descapotable {get;set;}
            public bool TieneTurbo {get;set;}

           override public void Acelerar(){
                Velocidad = Velocidad + 5;
            }

        }

        class MiniVan:Automovil{
            public bool TieneTerceraFilaDeAsientos {get;set;}
            public bool CentroDeEntretenimiento {get;set;}
            public bool AsistenciaReversa {get;set;}

            override public void Acelerar(){
                Velocidad = Velocidad + 0.5D;
            }
        }



    }

    //Debe hacer un automovil: Encender, Apagar, Frenar, Acelerar, Girar a la derecha, Girar a la izquierda, Avanzar recto, Reversa.
    //Que debe tener un automovil: Llantas, puertas, motor, color, asientos, kilometraje, faros, calavera, precio.

    



}
