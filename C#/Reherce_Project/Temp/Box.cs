using System;
using System.Collections.Generic;
using System.Text;

namespace Temp
{
    class Box
    {
        public string Color { get; set; }
        public int Length { get; set; }
        public int Height { get; set; }
        public int Volume { get; set; }
        public int Width { get; set; }

        public Box(int length, int height, int width)
        {
            this.Length = length;
            this.Height = height;
            this.Width = width;
        }

        public int FrontSurface {
            get
            {
                return Height * Length;
            }
            private set { } 
        }
    }
}
