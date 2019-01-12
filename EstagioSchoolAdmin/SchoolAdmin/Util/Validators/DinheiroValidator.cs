using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Util.Validators
{
    public class DinheiroValidator
    {
        public bool Validar(string valor)
        {
            valor = valor.Replace("R$", "").Trim();

            try
            {
                Decimal valorConvertido = Decimal.Parse(valor);

                if (valorConvertido <= 0)
                    return false;
            }
            catch
            {
                return false;
            }

            return true;
        }
    }
}
