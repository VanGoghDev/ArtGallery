using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArtGallery.Models
{
    public class Point
    {
        public double x { get; set; }
        public double y { get; set; }
        public int pathNum { get; set; }

        public Point()
        { }
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public Point(double x, double y, int pathNum, int pointNum)
        {
            this.x = x;
            this.y = y;
        }
    }
}