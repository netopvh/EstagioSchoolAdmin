using NUnit.Framework;
using SchoolAdmin.Util.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Tests.validators
{
    [TestFixture]
    class CEPValidatorTests
    {
        [Test]
        public void DeveInstanciarUmCEPValidator()
        {
            var sut = new CEPValidator();

            Assert.IsNotNull(sut);
        }

        [TestCase("", "SP")]
        [TestCase(null, "SP")]
        public void DeveValidarUmCEPVazioOuNulo(string cep, string sigla)
        {
            var sut = new CEPValidator();

            Assert.IsFalse(sut.Validar(cep, sigla));
        }

        [TestCase("17522-03", "SP")]   // cep.Length < 8
        [TestCase("17522-0300", "SP")] // cep.Length > 8
        public void DeveValidarCEPTamanhoInvalido(string cep, string sigla)
        {
            var sut = new CEPValidator();

            Assert.IsFalse(sut.Validar(cep, sigla));
        }

        [TestCase("11111-111", "SP")]
        [TestCase("99999-999", "SP")]
        [TestCase("26165-213", "SP")]
        [TestCase("ABCDE-FGH", "SP")]
        public void DeveValidarCEPInvalido(string cep, string sigla)
        {
            var sut = new CEPValidator();

            Assert.IsFalse(sut.Validar(cep, sigla));
        }

        [TestCase("19064-655", "SP")]
        [TestCase("86039-150", "PR")]
        [TestCase("85870-310", "PR")]
        [TestCase("88064-525", "SC")]
        [TestCase("89221-103", "SC")]
        public void DeveValidarCEPValido(string cep, string sigla)
        {
            var sut = new CEPValidator();

            Assert.IsTrue(sut.Validar(cep, sigla));
        }

    }
}
