using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carro_modificaciones_semana_8.Carro
{
    internal class ClsRace
    {
        private Carro CarroA;
        private Carro CarroB;
        private Carro CarroC;


        public void PedirDatosCarrera()
        {

            CarroA = GetData();
            Console.WriteLine("Ahora datos del B");
            CarroB = GetData();
            Console.WriteLine("Ahora datos del C");
            CarroC = GetData(); 

        }

        public void IniciarCarrera()
        {
            string msgCarroA, msgCarroB, msgCarroC;
            Random velRandom = new Random();
            int corredorA = 0;
            int corredorB = 0;
            int corredorC = 0;

            msgCarroA = CarroA.EncenderMotor();
            msgCarroB = CarroB.EncenderMotor();
            msgCarroC = CarroC.EncenderMotor();
            Console.WriteLine($"{CarroA.Marca} {msgCarroA}");
            Console.WriteLine($"{CarroB.Marca} {msgCarroB}");
            Console.WriteLine($"{CarroC.Marca} {msgCarroC}");


            for (int i = 0; i < 10; i++)
            {
                int acelera;
                acelera = velRandom.Next(1, 21);
                msgCarroA = CarroA.acelerar(acelera);
                acelera = velRandom.Next(1, 21);
                msgCarroB = CarroB.acelerar(acelera);
                acelera = velRandom.Next(1, 21);
                msgCarroC = CarroC.acelerar(acelera);
                acelera = velRandom.Next(1, 21);
                Console.WriteLine($"{i + 1}- {CarroA.owner}:{msgCarroA}  {CarroB.owner}:{msgCarroB} {CarroC.owner}:{msgCarroC}");

            }

            if (CarroA.GetVelocidadActual() > CarroB.GetVelocidadActual())
                if (CarroA.GetVelocidadActual() > CarroC.GetVelocidadActual())
                {
                    Console.WriteLine($"El ganador es:{CarroA.owner}");
                    Console.WriteLine($"Ganador Manga 1:{ corredorA++}");
                }
                else if (CarroC.GetVelocidadActual() > CarroB.GetVelocidadActual())
                {
                    Console.WriteLine($"El ganador es:{CarroC.owner}");
                    Console.WriteLine($"Ganador Manga:{ corredorC++}");
                }
                else
                {
                    Console.WriteLine($"El ganador es:{CarroB.owner}");
                    Console.WriteLine($"Ganador Manga:{ corredorB++}");
                }
                else if (CarroB.GetVelocidadActual() > CarroC.GetVelocidadActual())
                {
                Console.WriteLine($"El ganador es:{CarroB.owner}");
                Console.WriteLine($"Ganador Manga:{ corredorB++}");
            }
                else
                {
                Console.WriteLine($"El ganador es:{CarroC.owner}");
                Console.WriteLine($"Ganador Manga:{ corredorC++}");
            }
           


        } 




        private Carro GetData()
        {
            string marca;
            int modelo;
            int velocidad;
            string propietario;
            Carro carroTemporal;


            Console.WriteLine("Ingrese marca");
            marca = Console.ReadLine();

            Console.WriteLine("ingrese modelo");
            modelo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese velocidad max");
            velocidad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Propietario:");
            propietario = Console.ReadLine();
            carroTemporal = new Carro(marca, modelo, velocidad, propietario);
            return carroTemporal;
        }
    }
}
