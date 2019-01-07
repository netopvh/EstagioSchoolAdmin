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
    class TelefoneValidatorTests
    {
        [Test]
        public void DeveInstaciarTelefoneValidator()
        {
            var sut = new TelefoneValidator();
            Assert.IsNotNull(sut);
        }

        [TestCase("(44) 2630-673")]    // telefone.Length < 10
        [TestCase("(44) 99703-47741")] // telefone.Length > 11
        public void DeveValidarTelefoneInvalido(String telefone)
        {
            var sut = new TelefoneValidator();
            Assert.IsFalse(sut.Validar(telefone));
        }


        // referência: "https://www.4devs.com.br/gerador_de_pessoas"
        [TestCase("(44) 2630-6732")]
        [TestCase("(44) 99703-4774")]
        public void DeveValidarTelefoneValido(String telefone)
        {
            var sut = new TelefoneValidator();
            Assert.IsTrue(sut.Validar(telefone));
        }
    }
}
