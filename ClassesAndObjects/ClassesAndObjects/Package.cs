using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
* ---------------------------------------|
* |               Package                |
* |--------------------------------------|
* | + width: double                      |
* | + length: double                     |
* | + height: double                     |
* |--------------------------------------|
* | + GetVolume(): double                |
* | + GetSurfaceArea(): double           |
* |--------------------------------------|
* 
* 
* 
* 
*/


namespace ClassesAndObjects
{
    class package
    {
        // Property Variables are Title Case
        // Field Variables are Camel Case
        public double Width { get; set; }
        public double Length { get; set; }
        public double Height { get; set; }

        public double GetVolume()
        {
            return Width * Length * Height;
        }
        public double GetSurfaceArea()
        {
            return 2 * (Height * Width) + 2 * (Height * Length) + 2 * (Length * Width);
        }
    }
}
