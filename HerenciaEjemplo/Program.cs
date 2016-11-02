using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HerenciaEjemplo.Inheritance2;
using HerenciaEjemplo.Interface;

namespace HerenciaEjemplo
{
    class Program
    {
        static void Main(string[] args)
        {


            /* Inheritance1
            var cuadrado = new Cuadrado(4.0);
            cuadrado.Dibujar();
            Console.WriteLine("El area del cuadrado es: {0}", cuadrado.Area());
            Console.WriteLine();
            var circulo = new Circulo(2.5);
            circulo.Dibujar();
            Console.WriteLine("El area del círculo es: {0}", circulo.Area());
            Console.ReadLine();
            */

            //==================================================================
            /*Inheritance2
            var std = new Student();
            std.FirstName = "Alice 2";
            std.LastName = "Romanson";
            std.CompletedCourse = 20;
            std.Display();

            //1) Creating a "base class instance (superclass)" from a derived class (childclass) --> It's possible!
            Person person_student = new Student();
            //2) But I cannot create an "derived class (childclass)" instance from the "base class (superclass)"
            //Student student = new Person(); //--> NOT POSSIBLE

            
            */


            //Strategy Pattern
            //Source: https://www.youtube.com/watch?v=e7Yj6vLyYOI
            //==================================================================
            var ostrich = new Ostrich();
            var parrot = new Parrot();
            var penguin = new Penguin();
            var rubberBird = new RubberBird();

            //An ostrich does not fly, does speak, does not swin
            ostrich.Display();
            ostrich.Fly();
            ostrich.Speak();
            ostrich.Swin();

            //A parrot Flies, Speaks, but DOES NOT SWIN
            Console.WriteLine("");
            parrot.Display();
            parrot.Fly();
            parrot.Speak();
            parrot.Swin();

            //A penguin does not fly, does speak, does swin
            Console.WriteLine("");
            penguin.Display();
            penguin.Fly();
            penguin.Speak();
            penguin.Swin();

            //A rubberbird does nothing
            Console.WriteLine("");
            rubberBird.Display();
            rubberBird.Fly();
            rubberBird.Speak();
            rubberBird.Swin();
            Console.WriteLine("modifying the usesless rubberbird to Fly");
            rubberBird.FlyBehaviour = new FlyBehaviour();
            rubberBird.Fly();


        }

    }

   
}
