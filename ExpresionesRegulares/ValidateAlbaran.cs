using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExpresionesRegulares
{
    public class ValidateAlbaran
    {
        public static bool MethodValidateAlbaran(string strString)
        {
            string strPattern = @"\A[AB]([0-9]{9})\Z";

            return new Regex(strPattern).IsMatch(strString);
        }

        public static bool ValidatePatron(string strString)
        {
            //Validar que solo se pueda ingresar el patron: ABCD1720178068

            //string strPattern = @"\A[a-z]{4}-([0-9]{10})\Z";

            string strPattern = @"\A[AB]([0-9]{9})\Z";

            System.Diagnostics.Trace.WriteLine(strString);

            return new Regex(strPattern).IsMatch(strString);
        }

        public static bool ValidarNumeroTelefono(string strString)
        {
            //Validar 000 000 000

            string strPattern = @"\A[0-9]{3} [0-9]{3} [0-9]{3}\Z";

            return new Regex(strPattern).IsMatch(strString);
        }

        public static bool ValidarDominioWeb(string strString)
        {
            //Validar dominio web [www.nombredominio.tipodominio(.com, .net, .info, .org)]
            string strPattern = @"\A[w]{3}(\.)([a-z0-9])+(\.)(com|net|info|org)";

            return new Regex(strPattern).IsMatch(strString);
        }
    }
}
