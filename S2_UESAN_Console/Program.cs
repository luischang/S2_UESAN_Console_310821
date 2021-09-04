using S2_UESAN_Console.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace S2_UESAN_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string nombreCurso = "Desarrollo de Aplicaciones Web 2021-2";
            int edad = 20;
            double monto = 200.01;

            var nuevaEdad = "Veintiuno";
            var peso = 70.50;

            var listadoPersona = new List<Persona>();
            var persona = new Persona();
            persona.dni = "44110022";
            persona.nombreCompleto = "Paolo Guerrero";
            persona.telefono = 8854154;

            var persona2 = new Persona("77445588", "Gianluca Lapadula", 5565414);
            var persona3 = new Persona()
            {
                dni = "99663322",
                nombreCompleto = "Pedro Gallese",
                telefono=4471447
            };

            listadoPersona.Add(persona);
            listadoPersona.Add(persona2);
            listadoPersona.Add(persona3);

            foreach (var item in listadoPersona)
            {
                Console.WriteLine(item.dni + " " + item.nombreCompleto + " " + item.telefono);
            }

            var busqueda = listadoPersona.Where(x => x.dni == "99663322").FirstOrDefault();

            Console.WriteLine("La búsqueda encontró a: " + busqueda.nombreCompleto);
        }
    }
}
