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
    class CPFValidatorTests
    {
        [Test]
        public void DeveInstanciarUmCPFValidator()
        {
            var sut = new CPFValidator();
            Assert.IsNotNull(sut);
        }

        [TestCase("")]
        [TestCase(null)]
        public void DeveValidarUmCPFVazioOuNulo(string cpf)
        {
            var sut = new CPFValidator();

            Assert.IsFalse(sut.Validar(cpf));
        }


        [TestCase("1112223334")]   // cpf.Length < 11
        [TestCase("111222333444")] // cpf.Length > 11
        public void DeveValidarCPFTamanhoInvalido(string cpf)
        {
            var sut = new CPFValidator();

            Assert.IsFalse(sut.Validar(cpf));
        }

        [TestCase("11122233344")]
        [TestCase("111.222.333-44")]
        [TestCase("000.000.000-00")]
        [TestCase("111.111.111-11")]
        [TestCase("222.222.222-22")]
        [TestCase("333.333.333-33")]
        [TestCase("444.444.444-44")]
        [TestCase("555.555.555-55")]
        [TestCase("666.666.666-66")]
        [TestCase("777.777.777-77")]
        [TestCase("888.888.888-88")]
        [TestCase("999.999.999-99")]
        [TestCase("ABC.DEF.GHI-JK")]
        public void DeveValidarCPFInvalido(string cpf)
        {
            var sut = new CPFValidator();

            Assert.IsFalse(sut.Validar(cpf));
        }

        // referência: "https://www.4devs.com.br/gerador_de_cpf"
        [TestCase("25811556047")]
        [TestCase("258.115.560-47")]
        [TestCase("96707170007")]
        [TestCase("967.071.700-07")]
        public void DeveValidarCPFValido(string cpf)
        {
            var sut = new CPFValidator();

            Assert.IsTrue(sut.Validar(cpf));
        }

    }
}
