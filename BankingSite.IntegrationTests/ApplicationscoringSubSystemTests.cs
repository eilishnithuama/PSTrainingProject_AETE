using NUnit.Framework;
using Moq;
using BankingSite.Model.DomainEntities;
using BankingSite.Model;
using BankingSite.Model.ExternalComponentGateways;
using Ninject;

namespace BankingSite.IntegrationTests
{
    [TestFixture]
    class ApplicationscoringSubSystemTests
    {

        [Test]
        public void ShouldScoreApplicationCorrectly()
        {

            var realCreditCheckerGateway = new CreditCheckerGateway();
            var fakeMainframe = new Mock<IBankMainframeGateway>();

            var application = new CreditCardApplication { ApplicantName = "Maire",ApplicantAgeInYears = 25, AirlineFrequentFlyerNumber = "C3456789" };

            fakeMainframe.Setup(x => x.CreateNew(application)).Returns(35);


            var sut = new CreditCardApplicationScorer(realCreditCheckerGateway, fakeMainframe.Object);

            var result = sut.ScoreApplication(application);

            Assert.That(result, Is.Not.Null);


        }

        [Test]
        public void ShouldScoreApplicationCorrectlyInjection()
        {
            var application = new CreditCardApplication { ApplicantName = "Maire", ApplicantAgeInYears = 25, AirlineFrequentFlyerNumber = "C3456789" };
            var fakeMainframe = new Mock<IBankMainframeGateway>();
            fakeMainframe.Setup(x => x.CreateNew(application)).Returns(35);

            var kernel = new StandardKernel();
            kernel.Bind<ICreditCheckerGateway>().To<CreditCheckerGateway>();
            kernel.Bind<IBankMainframeGateway>().ToConstant(fakeMainframe.Object);

            var sut = kernel.Get<CreditCardApplicationScorer>();
            
            var result = sut.ScoreApplication(application);

            Assert.That(result, Is.Not.Null);


        }


    }
}
