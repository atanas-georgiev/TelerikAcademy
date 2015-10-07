namespace Cars.Tests.JustMock
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Cars.Contracts;
    using Cars.Tests.JustMock.Mocks;
    using Cars.Controllers;
    using Cars.Models;
    
    [TestClass]
    public class CarsControllerTests
    {
        private readonly ICarsRepository carsData;
        private CarsController controller;
        private ICarsRepositoryMock mockedCarsData;

        public CarsControllerTests()            
             : this(new MoqCarsRepository())
        {
        }

        private CarsControllerTests(ICarsRepositoryMock carsDataMock)
        {            
            this.mockedCarsData = carsDataMock;
            this.carsData = carsDataMock.CarsData;
        }

        [TestInitialize]
        public void CreateController()
        {
            this.controller = new CarsController(this.carsData);
        }

        [TestMethod]
        public void IndexShouldReturnAllCars()
        {
            var model = (ICollection<Car>)this.GetModel(() => this.controller.Index());
            Assert.AreEqual(5, model.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarIsNull()
        {
            var model = (Car)this.GetModel(() => this.controller.Add(null));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarMakeIsNull()
        {
            var car = new Car
            {
                Id = 15,
                Make = "",
                Model = "330d",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarModelIsNull()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));
        }

        [TestMethod]
        public void AddingCarShouldReturnADetail()
        {
            var car = new Car
            {
                Id = 0,
                Make = "BMW",
                Model = "330d",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));

            Assert.AreEqual(1, model.Id);
            Assert.AreEqual("Audi", model.Make);
            Assert.AreEqual("A5", model.Model);
            Assert.AreEqual(2005, model.Year);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GettingDetailsOnNotExistingCarShouldThrow()
        {
            var details = (Car)this.GetModel(() => this.controller.Details(4));            
        }

        [TestMethod]
        public void SearchingDetailsShouldReturnValidData()
        {
            var details = (IList<Car>)this.GetModel(() => this.controller.Search("test"));                                                       
            Assert.AreEqual(0, details[0].Id);
            Assert.AreEqual("searchedCar", details[0].Make);
            Assert.AreEqual("searchedModel", details[0].Model);
            Assert.AreEqual(2000, details[0].Year);
        }

        [TestMethod]
        public void SortingByMakeShouldReturnValidData()
        {
            var details = (IList<Car>)this.GetModel(() => this.controller.Sort("make"));
            Assert.AreEqual(0, details[0].Id);
            Assert.AreEqual("sortedByMake", details[0].Make);
            Assert.AreEqual("sortedByMake", details[0].Model);
            Assert.AreEqual(2000, details[0].Year);
        }

        [TestMethod]
        public void SortingByYearShouldReturnValidData()
        {
            var details = (IList<Car>)this.GetModel(() => this.controller.Sort("year"));
            Assert.AreEqual(0, details[0].Id);
            Assert.AreEqual("sortedByYear", details[0].Make);
            Assert.AreEqual("sortedByYear", details[0].Model);
            Assert.AreEqual(2000, details[0].Year);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SortingByInvalidStringShouldThrow()
        {
            var details = (IList<Car>)this.GetModel(() => this.controller.Sort("invalid"));
        }

        [TestMethod]
        public void RepositoryWithDefaultConstructorShouldNotThrow()
        {
            var controllerTest = new CarsController();            
        }

        private object GetModel(Func<IView> funcView)
        {
            var view = funcView();
            return view.Model;
        }
    }
}
