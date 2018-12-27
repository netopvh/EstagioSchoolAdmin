using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Util.Validators
{
    public class StringValidator
    {

        public bool Validar(string str)
        {
            if (String.IsNullOrEmpty(str))
                return false;
            if (String.IsNullOrWhiteSpace(str))
                return false;

            return true;
        }

        public bool Validar(string str, int tamanhoMaximo)
        {
            return Validar(str) && str.Length <= tamanhoMaximo;
        }
    }
}
