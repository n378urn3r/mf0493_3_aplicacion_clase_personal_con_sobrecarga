using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasepersonal
{
    class calculadora
    {
       // private string nombreStaff;
        //private const int ratioSalarial = 30;
       // private int hTrabajadas;
      /*  public int horasTrabajadas  //version comun , sin utilizar la posibilidad de c# de indicar que variable usa set/get
        {
               get {
                return hTrabajadas;
                   }

               set {
                    if (value > 0)  // La palabra reservada value permite referenciar el objeto.propiedad.value que se va a instanciar.  . El signo = se permite en losmetodos set / get.
                        hTrabajadas = value;
                    else
                        hTrabajadas = 0;
                
                    }
        }
        */
        public int valorInicial{ get; set; } //C# permite indicar así que esta propiedad se accede por un get / set
        public int valorFinal { get; set; } //C# permite indicar así que esta propiedad se accede por un get / set

        public int opera()
        {
            return (valorFinal + valorInicial);
        }

        public int opera (char c)
        {
            return (valorInicial - valorFinal);
        }

        public float opera (string operacion)
        {
            switch (operacion)
            {
                /*case "resta":
                    return (valorFinal - valorInicial);
                    break;*/
                case "multiplica":

                    return (valorFinal * valorInicial);
                    break;
                case "dividir":
                    return (valorFinal / valorInicial);
                    break;
                default:

                    return (0);


            }

        }
        /*
        public void mostrarImpares()
        {
            Console.WriteLine("Mostrar Impares....");
            //int i = valorInicial;
            //
            if (valorInicial % 2 == 0)
                valorInicial = valorInicial + 1;
            while (valorInicial <= valorFinal)
                {
              

                Console.WriteLine(valorInicial);
                valorInicial = valorInicial + 2;

                }

        }
        /*public int CalcularPago(int bonus, int presentismo)

        {
            int vpagado;
            mostrarMensaje();
            vpagado = horasTrabajadas;
            if (horasTrabajadas > 0)

                return vpagado;

            else
                return 0;




        }
        
        public int CalcularPago() {
            mostrarMensaje();
            int  vpagado;
            vpagado = horasTrabajadas * ratioSalarial;
            if (horasTrabajadas > 0)
            
                return vpagado;
            
            else
                return 0;

        }
        */
    }
}
