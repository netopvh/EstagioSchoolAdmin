using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Util.Validators
{
    class RGValidator
    {
        public static bool Validar(string rg)
        {
            rg = rg.Replace(".", "").Replace("-", "").Replace(",", "").Replace(" ", "").Trim();
            if (rg.Length != 9)
                return false;

            return true;
        }
    }
}
