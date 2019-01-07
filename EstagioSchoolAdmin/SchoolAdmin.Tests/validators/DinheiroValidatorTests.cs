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
    class DinheiroValidatorTests
    {
        [Test]
        public void DeveInstanciarUmDinheiroValidator()
        {
            var sut = new DinheiroValidator();
            Assert.IsNotNull(sut);
        }

        [TestCase("abc")]
        [TestCase("-1")]
        [TestCase("R$ -1")]
        [TestCase("R$ - 0,01")]
        public void DeveValidarUmValorInvalido(string valor)
        {
            var sut = new DinheiroValidator();
            Assert.IsFalse(sut.Validar(valor));
        }

        [TestCase("1")]
        [TestCase("R$ 789,00")]
        [TestCase("R$ 789,50")]
        [TestCase("R$ 0,01")]
        public void DeveValidarUmValorVálido(string valor)
        {
            var sut = new DinheiroValidator();
            Assert.IsTrue(sut.Validar(valor));
        }
    }
}
