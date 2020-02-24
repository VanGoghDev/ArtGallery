using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using ArtGallery.Models;

namespace ArtGallery.DomainModels
{
    public class Parser
    {
        public void Parse(String filePath, Routes inObj)
        {
            string line;
            List<string> xCoord = new List<string>();
            List<string> yCoord = new List<string>();
            using (StreamReader inStream = new StreamReader(filePath))
            {
                while ((line = inStream.ReadLine()) != null)
                {
                    string[] foo = Regex.Split(line, "\t");
                    string[] foos = foo[0].Split(' ');
                    Point point = new Point(float.Parse(foos[0]), float.Parse(foos[1]));
                    inObj.addPoint(point);
                }
            }
        }
    }
}