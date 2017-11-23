using NUnit.Framework;
using Moq;
using BankingSite.Services;
using BankingSite.Model;
using BankingSite.Model.DomainEntities;

namespace BankingSite.IntegrationTests
{
    [TestFixture]
    class CreditCardApplicationServiceTests
    {
        [Test]
        public void ShouldGetSuccessfulApplicatantsName()
        {
            var sut = new CreditCardApplicationServiceReference.CreditCardApplicationServiceClient();

            var application = new CreditCardApplication { ApplicantName = "Jack", ApplicantAgeInYears = 27, AirlineFrequentFlyerNumber = "W9876543"};

            var results = sut.SubmitApplication(application);

            Assert.That(results.ValidationErrors,Is.Empty);
            Assert.That(results.ReferenceNumber,Is.Not.Null);

            var successfulApplicant = sut.GetSuccesfulApplicantsName(results.ReferenceNumber.Value);

            Assert.That(successfulApplicant, Is.EqualTo("Jack"));


        }

    }
}
