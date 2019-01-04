using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Util.Validators
{
    public class CPFValidator
    {
        public bool Validar(string cpf)
        {
            StringValidator validatorStr = new StringValidator();
            if (!validatorStr.Validar(cpf))
                return false;

            cpf = cpf.Replace(".", "").Replace("-", "").Replace(",", "").Replace(" ", "").Trim();

            if (cpf.Length != 11)
                return false;

            if (cpf.Distinct().Count() == 1)
            {
                return false;
            }

            try
            {
                int[] cpf_array;
                int digitoVerificador1, digitoVerificador2, somatorio1, somatorio2;

                foreach (char c in cpf)
                {
                    if (!char.IsNumber(c))
                        return false;
                }

                cpf_array = new int[11];
                for (int i = 0; i < cpf.Length; i++)
                {
                    cpf_array[i] = int.Parse(cpf[i].ToString());
                }

                somatorio1 = somatorio2 = 0;
                for (int posicao = 0; posicao < 9; posicao++)
                {
                    somatorio1 += cpf_array[posicao] * (10 - posicao);
                    somatorio2 += cpf_array[posicao] * (11 - posicao);
                }

                digitoVerificador1 = somatorio1 % 11;
                digitoVerificador1 = digitoVerificador1 < 2 ? 0 : 11 - digitoVerificador1;

                if (cpf_array[9] != digitoVerificador1)
                {
                    return false;
                }

                somatorio2 += digitoVerificador1 * 2;
                digitoVerificador2 = somatorio2 % 11;
                digitoVerificador2 = digitoVerificador2 < 2 ? 0 : 11 - digitoVerificador2;

                if(cpf_array[10] != digitoVerificador2)
                {
                    return false;
                }

            }
            catch
            {
                return false;
            }

            return true;
        }

    }
}
