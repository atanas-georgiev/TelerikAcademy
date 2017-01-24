
namespace FurnitureManufacturer.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using FurnitureManufacturer.Interfaces;

    class Company : ICompany
    {
        private string name;
        private string registrationNumber;
        private List<IFurniture> furnitures;

        public Company(string nameCompany, string registrationNumberCompany)
        {
            this.name = nameCompany;
            this.registrationNumber = registrationNumberCompany;
            furnitures = new List<IFurniture>();
        }

        public string Name
        {
            get { return name; }
        }

        public string RegistrationNumber
        {
            get { return registrationNumber; }
        }

        public ICollection<IFurniture> Furnitures
        {
            get { return furnitures; }
        }

        public void Add(IFurniture furniture)
        {
            furnitures.Add(furniture);
        }

        public void Remove(IFurniture furniture)
        {
            var f = furnitures.Where(x => x.Equals(furniture)).FirstOrDefault<IFurniture>();

            if (f != null)
            {
                furnitures.Remove(f);
            }            
        }

        public IFurniture Find(string model)
        {
            return furnitures.Where(x => StringComparer.OrdinalIgnoreCase.Compare(x.Model, model) == 0).FirstOrDefault<IFurniture>();
        }
        public string Catalog()
        {
            StringBuilder result = new StringBuilder();
            result.Append(string.Format("{0} - {1} - {2} {3}\n",
                            this.Name,
                            this.RegistrationNumber,
                            this.Furnitures.Count != 0 ? this.Furnitures.Count.ToString() : "no",
                            this.Furnitures.Count != 1 ? "furnitures" : "furniture"
                            ));

            var f = Furnitures.OrderBy(x => x.Price).ThenBy(x => x.Model);

            foreach (var item in f)
            {
                result.Append(item + "\n");
            }

            return result.ToString().TrimEnd('\n');
        }
    }
}
