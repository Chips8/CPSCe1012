using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 *  ________________________________
 * |        Package                 |
 * |________________________________|
 * |    + width: double             |
 * |    + length: double            |
 * |    + height: double            |
 * |--------------------------------|
 * |    + GetVolume(): double       |
 * |    + GetSurfaceArea(): double  |
 * |________________________________|
 */


namespace Box
{
    class package
    {
        public double Width { get; set; } //because this is a property, it needs to be TitleCase
        public double Length { get; set; }
        public double Height { get; set; }

        //the big difference is we are now getting rid of the word static
        //these guys here are going to be available just by their name, we need our accessor in this case, Public.
        public double GetVolume()
        {
            return Width * Length * Height;
        }
        public double GetSurfaceAreas()
        {
            return (2 * Length * Width) + (2 * Length * Height) + (2 * Height * Width);
        }
    }
}
