using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Box
    {
      
        // Member variable
        private int _length { get; set; }
        private int _height { get; set; }
        private int _width  { get; set; }
        private int _volume { get; set; }


       public Box(int length = -1, int height = -1, int width = -1)
        {
            if (length.Equals(-1) && height.Equals(-1) && width.Equals(-1))
                Console.WriteLine("no params entered");
            else
            {
                _length = length;
                _height = height;
                _width = width;
                _volume = length * height * width;
            }
        }

        public int frontSurface()
        {
            return _height * _length;
        }
            
        

        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0}. Height is {1}. Width is {2}. Volume is {3}.", 
                _length, _height, _width, _volume);
        }

    }
}
