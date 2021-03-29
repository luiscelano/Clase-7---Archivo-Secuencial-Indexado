using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Clase_7___Archivo_Secuencial_Indexado.Models;
namespace Clase_7___Archivo_Secuencial_Indexado.Controllers
{
    class PositionControllers
    {
        static string projectFolder = "C:\\users\\"+Environment.UserName+"\\EmployeeSystem";
        static string positionsFilename = "\\positions.txt";
        static string path = projectFolder + positionsFilename;
        public void AddPosition(Position position)
        {
            string pathResult = GetPositionPath();
            using(StreamWriter sr = File.CreateText(pathResult))
            {
                sr.Write(position.GetLine);
                sr.Close();
            }
        }
        public static string GetPositionPath()
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
        public void UpdatePositionAmount(List<Position> positions)
        {

        }
          
    }
}
