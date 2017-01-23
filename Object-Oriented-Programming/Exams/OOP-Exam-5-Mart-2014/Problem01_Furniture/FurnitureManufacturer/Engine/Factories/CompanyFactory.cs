namespace FurnitureManufacturer.Engine.Factories
{
    using Interfaces;
    using Interfaces.Engine;
    using Models;
    using System.Linq;

    public class CompanyFactory : ICompanyFactory
    {
        public ICompany CreateCompany(string name, string registrationNumber)
        {
            if ((name != "") &&
                (name != null) &&
                (name.Length >= 5) &&
                (registrationNumber.Length == 10) &&
                (registrationNumber.All(char.IsDigit)))
            {
                return new Company(name, registrationNumber);
            }
            else
            {
                return null;
            }
        }
    }
}
