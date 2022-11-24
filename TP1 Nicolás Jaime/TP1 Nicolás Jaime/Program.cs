using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Nicolás_Jaime
{
    internal class Cuenta //clase: es un molde donde se crean objetos con sus respectivos metodos(cosas que puede hacer el objeto).
    {
        //ATRIBUTOS PRIVADOS(NO SE VEN FACILMENTE)
        string titular = "";
        double cantidad = 0;
        //
        //ATRIBUTOS PUBLICOS(FACIL DE ACCEDER)
        public string Titular { get { return titular; } set { titular = value; } } //Atributo publico que pasa sus datos al atributo privado
        public double Cantidad { get { return cantidad; } set { cantidad = value; } }
        //CONSTRUCTORES(las diferentes formas que se pueden crear un objeto)
        public Cuenta(string titular, double cantidad)
        {
            Titular = titular;
            Cantidad = cantidad;
        }
        public Cuenta(string titular)
        {
            Titular = titular;
        }
        //
        //METODOS: ACCIONES QUE PUEDE HACER EL OBJETO
        /*
         ingresar(double cantidad): se ingresa una cantidad a la cuenta, 
        si la cantidad introducida es negativa, no se hará nada.

         retirar(double cantidad): se retira una cantidad a la cuenta, 
        si restando la cantidad actual a la que nos pasan es negativa, la cantidad de la cuenta pasa a ser 0.
         */
        public void retirar(double plata)
        {
            if (plata > cantidad)
            {

                cantidad = 0;

            }
            else { cantidad -= plata; }

        }
        public void ingresar(double plata) //VOID es hacer algo, puede como no devolver algo
        {
            if (plata > 0)
            {
                cantidad += plata; //en este caso modifica un dato
            }
            else
            {
                Console.WriteLine("cantidad de plata negativa");//en este caso devuelve texto
            }
        }
        //
    }
}
