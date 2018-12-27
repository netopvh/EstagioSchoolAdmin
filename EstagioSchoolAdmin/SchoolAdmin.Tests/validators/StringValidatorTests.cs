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
    class StringValidatorTests
    {
        [Test]
        public void DeveInstanciarUmStringValidator()
        {
            var sut = new StringValidator();
            Assert.IsNotNull(sut);
        }

        [Test]
        public void DeveValidarUmaStringNull()
        {
            var sut = new StringValidator();
            string str = null;

            Assert.IsFalse(sut.Validar(str));
        }

        [Test]
        public void DeveValidarUmaStringVazia()
        {
            var sut = new StringValidator();
            string str = "";

            Assert.IsFalse(sut.Validar(str));
        }

        [Test]
        public void DeveValidarUmaStringComApenasEspacosEmBranco()
        {
            var sut = new StringValidator();
            string str = "                ";

            Assert.IsFalse(sut.Validar(str));
        }


        [Test]
        public void DeveValidarUmaStringComTamanhoMaximo()
        {
            var sut = new StringValidator();
            string str = "abcd123456789";

            Assert.IsFalse(sut.Validar(str, 10));
        }
    }
}
