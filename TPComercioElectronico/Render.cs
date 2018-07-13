using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPComercioElectronico
{
    public class Render
    {
        private int porcentaje(int porcentaje, int total)
        {
            System.Windows.Forms.Screen screen = System.Windows.Forms.Screen.PrimaryScreen;

            int Height = screen.Bounds.Width;
            int Width = screen.Bounds.Height;

            return total * porcentaje / 100;
        }

        public int porcentajeAlto(int porcentaje)
        {
            System.Windows.Forms.Screen screen = System.Windows.Forms.Screen.PrimaryScreen;
            return screen.Bounds.Height * porcentaje / 100;
        }

        public int porcentajeAncho(int porcentaje)
        {
            System.Windows.Forms.Screen screen = System.Windows.Forms.Screen.PrimaryScreen;
            return screen.Bounds.Width * porcentaje / 100;
        }
    }
}
