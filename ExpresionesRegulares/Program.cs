using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExpresionesRegulares
{
    class Program
    {
        static void Main(string[] args)
        {
            //string strAlbaran = "A0800000000"; hasta B999999999;
            //Console.WriteLine(ExpresionesRegulares.ValidateAlbaran.MethodValidateAlbaran(strAlbaran));

            string strString = "www.blinblineo.net";
            Console.WriteLine(ExpresionesRegulares.ValidateAlbaran.ValidarDominioWeb(strString));

            Console.ReadKey();
        }
    }
}
