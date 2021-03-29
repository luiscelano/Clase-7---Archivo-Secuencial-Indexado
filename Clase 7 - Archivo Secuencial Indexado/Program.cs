using System;
using Clase_7___Archivo_Secuencial_Indexado.Models;
using Clase_7___Archivo_Secuencial_Indexado.Controllers;
namespace Clase_7___Archivo_Secuencial_Indexado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        static void PrintMenu()
        {
            CenterText("CONTROL DE EMPLEADOS");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("Curso: PROGRAMACIÓN I");
            Console.WriteLine("Nombre: Luis Eduardo Alvarado Celano");
            Console.WriteLine("Carnet: 0900-20-7376");
            Console.WriteLine("Sección: C");
            Console.WriteLine("\n");
            CenterText("-------------------------------------");
            CenterText("MENÚ PRINCIPAL");
            CenterText("-------------------------------------");
            CenterLeftText("(1). INSERTAR PUESTO");
            CenterLeftText("(2). INSERTAR EMPLEADO");
            CenterLeftText("(3). VER PLANILLA LABORAL");
            CenterLeftText("(5). AUMENTAR 5% AL PUESTO");
            CenterLeftText("(6). BUSCAR EMPLEADO");
            CenterLeftText("(7). ELIMINAR EMPLEADO");
            CenterLeftText("(Esc). SALIR");
            CenterText("-------------------------------------");
            CenterText("ELIJA EL NÚMERO DE OPCIÓN [ ]");
            CenterText("-------------------------------------");
        }
        static void CenterLeftText(string text)
        {
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + text.Length - 15) + "}", text));
        }
        static void CenterText(string text)
        {
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (text.Length / 2)) + "}", text));
        }
    }
}
