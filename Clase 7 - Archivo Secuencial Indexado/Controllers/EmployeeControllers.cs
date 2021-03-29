using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Clase_7___Archivo_Secuencial_Indexado.Models;
namespace Clase_7___Archivo_Secuencial_Indexado.Controllers
{
    class EmployeeControllers
    {
        static string projectFolder = "C:\\users\\" + Environment.UserName + "\\EmployeeSystem";
        static string employeeFilename = "\\employees.txt";
        static string path = projectFolder + employeeFilename;

        public static void CreateEmployee(Employee employee)
        {
            string pathResult = GetEmployeePath();
            using(StreamWriter sr = File.CreateText(pathResult))
            {
                sr.WriteLine(employee.GetLine);
                sr.Close();
            }
        }
        public static string GetEmployeePath()
        {
            if (!Directory.Exists(projectFolder))
            {
                DirectoryInfo di = Directory.CreateDirectory(projectFolder);
            }
            if (!File.Exists(path))
            {
                using var file = File.Create(path);
                file.Close();
            }
            return path;
        }
        public List<Employee> GetEmployees()
        {

            return null;
        }
    }
}
