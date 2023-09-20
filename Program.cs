using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AlmacenObjetos<Empleado> archiobjetos = new AlmacenObjetos<Empleado>(5);//si quiero manejar string solo pongo entre los parentesis angulares <string> de esta manera podre ver los nombre de las siguientes lineas de abajo.
            /*archiobjetos.Agregar("felizia");                                      //se puede poner muchas cosas como <datetime>etc...
            archiobjetos.Agregar("lola");
            archiobjetos.Agregar("tereza");
            archiobjetos.Agregar("marco");
            archiobjetos.Agregar("arquimidez");*/

            // esto se conocse como clase generica. 

            archiobjetos.Agregar(new Empleado(1100));//en Empleado se cambia a string,datetime,etc...
            archiobjetos.Agregar(new Empleado(1200));
            archiobjetos.Agregar(new Empleado(1300));
            archiobjetos.Agregar(new Empleado(1400));
            archiobjetos.Agregar(new Empleado(1500));

            //en la variable /*(*/Empleado/*)*/ se reemplaza por string,datetime,etc... despues de poner arriba <string>,etc... de esta manera podemos ver los nombres al imprimir.
            /*(*/Empleado/*)*/ salarioemple = archiobjetos.GetElementos(2);// se puede hacer sin castin.
            Console.WriteLine(salarioemple.Getsalario());
            Console.WriteLine(" ");
            
            {
             
            }

        }
    }

    class AlmacenObjetos<T>// <- Con <T> le decimos a C# que esta clase va a manejar todo tipo de genericos string,objetos,datetime,etc...
    {
        private T[] DatosElementos;
        private int i = 0;

        public AlmacenObjetos(int z) 
        {
         DatosElementos = new T[z];
        }

        public void Agregar(T obj)
        {
            DatosElementos[i] = obj;
            i++;
        }

        public T GetElementos(int i) 
        {
         return DatosElementos[i];
        }
    }

    class Empleado
    {
        private double Salario;

        public Empleado(double salarioE) 
        {
         this.Salario = salarioE;
        }

        public double Getsalario()
        {
            return Salario;
        }
    }
}
