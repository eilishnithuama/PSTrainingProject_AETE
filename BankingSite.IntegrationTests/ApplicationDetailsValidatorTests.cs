using BankingSite.Model;
using BankingSite.Model.DomainEntities;
using NUnit.Framework;

namespace BankingSite.IntegrationTests
{
    [TestFixture]
    class ApplicationDetailsValidatorTests
    {

        [Test]
        [Category("smoke")]
        public void ShouldValidateApplicationDetails()
        {
            var applicant = new CreditCardApplication
            {
                ApplicantName = "John",
                ApplicantAgeInYears = 25,
                AirlineFrequentFlyerNumber = "C3456789"
            };
            var sut = new ApplicationDetailsValidator(new AirlineMembershipNumberValidator());

            var results = sut.Validate(applicant);
            Assert.That(results,Is.Empty);

        }
    }
}
