using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Nicolás_Jaime
{
    internal class Persona
    {
        static Random rnd = new Random();
        string nombre = "";
        int edad = 20;
        int dni = 34835781;
        char sexo = 'H';
        double peso = 70;
        double altura = 1.70;

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public int Edad { get { return edad; } set { edad = value; } }
        public int Dni { get { return dni; } set { dni = value; } }
        public char Sexo { get { return sexo; } set { sexo = value; } }
        public double Peso { get { return peso; } set { peso = value; } }
        public double Altura { get { return altura; } set { altura = value; } }

        public Persona()
        {
            Dni = generaDNI();
        }

        public Persona(string nombre, int edad, int dni, double peso, double altura)
        {
            Nombre = nombre;
            Edad = edad;
            Dni = dni;
            Peso = peso;
            Altura = altura;
        }
        public Persona(string nombre, int edad, char sexo)
        {
            Nombre = nombre;
            Edad = edad;
            Sexo = sexo;
        }


        public int calcularIMC(double peso, double altura, double cosito)
        {

            cosito = peso / altura;
            if (cosito < 20) { return -1; }
            else if (cosito >= 20 && cosito <= 25) { return 0; }
            else { return 1; }

        }

        public bool esMayorDeEdad()
        {
            if (Edad > 17) { return true; }
            else { return false; }

        }

        public void comprobarSexo()
        {

            if (Sexo != 'H') { Sexo = 'H'; }

        }

        public void toString()
        {
            Console.WriteLine($"nombre: {Nombre} \n edad: {Edad} \n dni: {Dni} \n peso: {Peso} \n altura: {Altura}");
        }

        public int generaDNI()
        {
            int num = rnd.Next(10000000, 99999999);
            return num;
        }

    }
}
