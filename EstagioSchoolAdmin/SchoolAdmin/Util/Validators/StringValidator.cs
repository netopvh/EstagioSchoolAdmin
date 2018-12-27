using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Util.Validators
{
    public class StringValidator
    {
        public static bool Validar(string str)
        {
            return !(String.IsNullOrEmpty(str) || String.IsNullOrWhiteSpace(str));
        }

        public static bool Validar(string str, int tamanhoMaximo)
        {
            return str.Length <= tamanhoMaximo;
        }
    }
}
