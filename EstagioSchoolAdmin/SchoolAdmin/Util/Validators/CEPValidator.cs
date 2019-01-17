using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Util.Validators
{
    public class CEPValidator
    {
        public bool Validar(string cep, string siglaEstado)
        {
            StringValidator strValidator = new StringValidator();
            if (!strValidator.Validar(cep))
                return false;

            cep = cep.Replace("-", "").Replace(" ", "").Trim();
            if (cep.Length != 8)
                return false;

            if (cep.Distinct().Count() == 1)
            {
                return false;
            }

            try
            {
                int cepNumber = int.Parse(cep);
                if (cepNumber <= 1000000)
                {
                    return false;
                }

                int cep1 = int.Parse(cep.Substring(0, 3));

                if (siglaEstado.Equals("SP") && cep1 >= 10 && cep1 <= 199)
                {
                    return true;
                }
                else if (siglaEstado.Equals("RJ") && cep1 >= 200 && cep1 <= 289)
                {
                    return true;
                }
                else if (siglaEstado.Equals("ES") && cep1 >= 290 && cep1 <= 299)
                {
                    return true;
                }
                else if (siglaEstado.Equals("MG") && cep1 >= 300 && cep1 <= 399)
                {
                    return true;
                }
                else if (siglaEstado.Equals("BA") && cep1 >= 400 && cep1 <= 489)
                {
                    return true;
                }
                else if (siglaEstado.Equals("SE") && cep1 >= 490 && cep1 <= 499)
                {
                    return true;
                }
                else if (siglaEstado.Equals("PE") && cep1 >= 500 && cep1 <= 569)
                {
                    return true;
                }
                else if (siglaEstado.Equals("AL") && cep1 >= 570 && cep1 <= 579)
                {
                    return true;
                }
                else if (siglaEstado.Equals("PB") && cep1 >= 580 && cep1 <= 589)
                {
                    return true;
                }
                else if (siglaEstado.Equals("RN") && cep1 >= 590 && cep1 <= 599)
                {
                    return true;
                }
                else if (siglaEstado.Equals("CE") && cep1 >= 600 && cep1 <= 639)
                {
                    return true;
                }
                else if (siglaEstado.Equals("PI") && cep1 >= 640 && cep1 <= 649)
                {
                    return true;
                }
                else if (siglaEstado.Equals("MA") && cep1 >= 650 && cep1 <= 659)
                {
                    return true;
                }
                else if (siglaEstado.Equals("PA") && cep1 >= 660 && cep1 <= 688)
                {
                    return true;
                }
                else if (siglaEstado.Equals("AM") && ((cep1 >= 690 && cep1 <= 692) || (cep1 >= 694 && cep1 <= 698)))
                {
                    return true;
                }
                else if (siglaEstado.Equals("AP") && cep1 == 689)
                {
                    return true;
                }
                else if (siglaEstado.Equals("RR") && cep1 == 693)
                {
                    return true;
                }
                else if (siglaEstado.Equals("AC") && cep1 == 699)
                {
                    return true;
                }
                else if (siglaEstado.Equals("AC") && cep1 == 699)
                {
                    return true;
                }
                else if ((siglaEstado.Equals("DF") || siglaEstado.Equals("GO")) && cep1 >= 000 && cep1 <= 999)
                {
                    return true;
                }
                else if (siglaEstado.Equals("TO") && cep1 >= 770 && cep1 <= 779)
                {
                    return true;
                }
                else if (siglaEstado.Equals("MT") && cep1 >= 780 && cep1 <= 788)
                {
                    return true;
                }
                else if (siglaEstado.Equals("MS") && cep1 >= 790 && cep1 <= 799)
                {
                    return true;
                }
                else if (siglaEstado.Equals("RO") && cep1 == 789)
                {
                    return true;
                }
                else if (siglaEstado.Equals("PR") && cep1 >= 800 && cep1 <= 879)
                {
                    return true;
                }
                else if (siglaEstado.Equals("SC") && cep1 >= 880 && cep1 <= 899)
                {
                    return true;
                }
                else if (siglaEstado.Equals("RS") && cep1 >= 900 && cep1 <= 999)
                {
                    return true;
                }

                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
