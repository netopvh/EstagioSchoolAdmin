using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Util.Validators
{
    public class CPFValidator
    {
        public static bool Validar(string cpf)
        {
            cpf = cpf.Replace(".", "").Replace("-", "").Replace(",", "").Replace(" ", "").Trim();
            if (cpf.Length != 11)
                return false;

            try
            {
               
            }
            catch
            {
                return false;
            }

            return false;
        }
    }
}
