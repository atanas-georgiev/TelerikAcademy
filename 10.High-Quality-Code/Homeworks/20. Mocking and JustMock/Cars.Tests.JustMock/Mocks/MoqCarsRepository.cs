namespace Cars.Tests.JustMock.Mocks
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    using Cars.Contracts;
    using Cars.Models;
    using Moq;
    using System.Linq;
    using System.Security.Cryptography.X509Certificates;

    public class MoqCarsRepository : CarRepositoryMock, ICarsRepositoryMock
    {
        protected override void ArrangeCarsRepositoryMock()
        {
            var mockedCarsRepository = new Mock<ICarsRepository>();
            mockedCarsRepository.Setup(r => r.Add(It.IsAny<Car>())).Verifiable();
            mockedCarsRepository.Setup(r => r.All()).Returns(this.FakeCarCollection);
            mockedCarsRepository.Setup(r => r.Search(It.IsAny<string>())).Returns(
                () =>
                    {
                        var result = new Collection<Car>();
                        result.Add(new Car()
                                       {
                                           Id = 0,
                                           Make = "searchedCar",
                                           Model = "searchedModel",
                                           Year = 2000
                                       });
                        return result;
                    });
            mockedCarsRepository.Setup(r => r.GetById(It.IsAny<int>())).Returns((int input) => this.FakeCarCollection[input]);
            mockedCarsRepository.Setup(r => r.SortedByMake()).Returns(
                () =>
                {
                    var result = new Collection<Car>();
                    result.Add(new Car()
                    {
                        Id = 0,
                        Make = "sortedByMake",
                        Model = "sortedByMake",
                        Year = 2000
                    });
                    return result;
                });
            mockedCarsRepository.Setup(r => r.SortedByYear()).Returns(
                () =>
                {
                    var result = new Collection<Car>();
                    result.Add(new Car()
                    {
                        Id = 0,
                        Make = "sortedByYear",
                        Model = "sortedByYear",
                        Year = 2000
                    });
                    return result;
                });
            this.CarsData = mockedCarsRepository.Object;
        }
    }
}
