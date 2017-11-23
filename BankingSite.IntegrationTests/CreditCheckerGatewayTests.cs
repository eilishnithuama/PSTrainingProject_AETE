
using NUnit.Framework;
using BankingSite.Model.ExternalComponentGateways;

namespace BankingSite.IntegrationTests
{
    [TestFixture]
    class CreditCheckerGatewayTests
    {

        [Test]
        public void ShouldCreditCheckGoodPerson()
        {

            var sut = new CreditCheckerGateway();
            var results =  sut.HasGoodCreditHistory("Maria");
            Assert.That(results, Is.True);

        }

        [Test]
        public void ShouldCreditCheckBadPerson()
        {

            var sut = new CreditCheckerGateway();
            var results = sut.HasGoodCreditHistory("John");
            Assert.That(results, Is.False);

        }


    }
}
