namespace PetStore.ConsoleClient
{
    using System;
    using System.Linq;
    using PetStore.Data;

    public class Startup
    {
        public static void Main()
        {
            var db = new PetStoreEntities();
            db.Database.Delete();
            db.Database.Create();

            db.Colors.Add(new Color() { Name = "black" });
            db.Colors.Add(new Color() { Name = "white" });
            db.Colors.Add(new Color() { Name = "red" });
            db.Colors.Add(new Color() { Name = "mixed" });

            // Add countries
            Console.Write("\nAdding countries");
            for (int i = 0; i < 20; i++)
            {

                db.Countries.Add(
                    new Country() { Name = RandomGenerator.RandomString(RandomGenerator.RandomInt(5, 50)), });

                if (i % 250 == 0)
                {
                    Console.Write(".");
                    db.SaveChanges();
                    db.Dispose();
                    db = new PetStoreEntities();
                }

            }

            db.SaveChanges();
            db.Dispose();
            db = new PetStoreEntities();

            // Get all country ids
            var countryIds = db.Countries.Select(x => x.Id).ToList();

            // add species
            Console.Write("\nAdding species");
            for (int i = 0; i < 100; i++)
            {

                db.Species.Add(
                    new Species()
                        {
                            Name = RandomGenerator.RandomString(RandomGenerator.RandomInt(5, 50)),
                            CountryId = countryIds[RandomGenerator.RandomInt(0, countryIds.Count - 1)]
                        });

                if (i % 250 == 0)
                {
                    Console.Write(".");
                    db.SaveChanges();
                    db.Dispose();
                    db = new PetStoreEntities();
                }
            }

            db.SaveChanges();
            db.Dispose();
            db = new PetStoreEntities();

            // Get all needed ids
            var speciesIds = db.Species.Select(x => x.Id).ToList();
            var colorIds = db.Colors.Select(x => x.Id).ToList();

            // add pets
            Console.Write("\nAdding pets");
            for (int i = 0; i < 5000; i++)
            {

                db.Pets.Add(
                    new Pet()
                        {
                            SpeciesId = speciesIds[RandomGenerator.RandomInt(0, speciesIds.Count - 1)],
                            Birthdate = RandomGenerator.RandomDate(DateTime.Now, DateTime.MaxValue), // todo ????
                            Price = RandomGenerator.RandomInt(500, 250000) / 100,
                            ColorId = colorIds[RandomGenerator.RandomInt(0, colorIds.Count - 1)],
                            Breed = RandomGenerator.RandomString(RandomGenerator.RandomInt(5, 30)),
                        });

                if (i % 250 == 0)
                {
                    Console.Write(".");
                    db.SaveChanges();
                    db.Dispose();
                    db = new PetStoreEntities();
                }

            }

            db.SaveChanges();
            db.Dispose();
            db = new PetStoreEntities();

            // add categories
            Console.Write("\nAdding categories");
            for (int i = 0; i < 50; i++)
            {

                db.ProductCategories.Add(
                    new ProductCategory() { Name = RandomGenerator.RandomString(RandomGenerator.RandomInt(5, 20)), });

                if (i % 250 == 0)
                {
                    Console.Write(".");
                    db.SaveChanges();
                    db.Dispose();
                    db = new PetStoreEntities();
                }
            }

            db.SaveChanges();
            db.Dispose();
            db = new PetStoreEntities();

            // Get all needed ids
            var productCategoryIds = db.ProductCategories.Select(x => x.Id).ToList();

            // add products
            Console.Write("\nAdding products");
            for (int i = 0; i < 20000; i++)
            {

                db.Products.Add(
                    new Product()
                        {
                            Name = RandomGenerator.RandomString(RandomGenerator.RandomInt(5, 25)),
                            CatyegoryId =
                                productCategoryIds[RandomGenerator.RandomInt(0, productCategoryIds.Count - 1)],
                            Price = RandomGenerator.RandomInt(1000, 100000) / 100,
                        });

                if (i % 250 == 0)
                {
                    Console.Write(".");
                    db.SaveChanges();
                    db.Dispose();
                    db = new PetStoreEntities();
                }
            }

            // Get all needed ids
            var productIds = db.Products.Select(x => x.Id).ToList();
            var speciesId = db.Species.Select(x => x.Id).ToList();

            Console.Write("\nAdding  products in species");
            //add products in species
            for (int i = 0; i < 2000; i++)
            {
                db.ProductSpecies.Add(
                    new ProductSpecy()
                        {
                            ProductId = productIds[RandomGenerator.RandomInt(0, productIds.Count - 1)],
                            SpeciesId = speciesId[RandomGenerator.RandomInt(0, speciesId.Count - 1)],
                    });

                if (i % 250 == 0)
                {
                    Console.Write(".");
                    db.SaveChanges();
                    db.Dispose();
                    db = new PetStoreEntities();
                }
            }

            db.SaveChanges();
            db.Dispose();
        }
    }
}
