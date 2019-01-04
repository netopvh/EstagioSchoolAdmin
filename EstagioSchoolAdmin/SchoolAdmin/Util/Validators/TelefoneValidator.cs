using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Util.Validators
{
    public class TelefoneValidator
    {
        public bool Validar(string telefone)
        {
            telefone = telefone.Replace("-", "").Replace(" ", "")
                                    .Replace("(", "").Replace(")", "").Trim();

            StringValidator StrValidator = new StringValidator();
            if (!StrValidator.Validar(telefone, 11))
                return false;

            return telefone.Length > 9;
        }
    }
}
