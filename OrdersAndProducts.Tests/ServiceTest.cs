using Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Services;
using Services.DTOs;
using Services.Interfaces;
using Services.Repository;
using Services.Service;
using System.Collections.Generic;

namespace OrdersAndProducts.Tests
{
    [TestClass]
    public class ServiceTest
    {

        [TestMethod]
        public void Can_Get_All_Product_Service()
        {
            List<Product> products = new List<Product>()
                                         {
                                             new Product(){Description="P1",Id=1,Name="p1Name"},
                                             new Product(){Description="P2",Id=2,Name="p2Name"},
                                             new Product(){Description="P3",Id=3,Name="p3Name"},
                                             new Product(){Description="P4",Id=4,Name="p4Name"},
                                             new Product(){Description="P5",Id=5,Name="p5Name"},
                                             new Product(){Description="P6",Id=6,Name="p6Name"},

                                         };

            Mock<IProductRepository> mockRepository = new Mock<IProductRepository>();
            mockRepository.Setup(m => m.GetAll()).Returns(products);

            Mock<IUnitOfWork> mockUOW = new Mock<IUnitOfWork>();

            mockUOW.Setup(m => m.ProductRepository).Returns(mockRepository.Object);
            Service service = new Service(mockUOW.Object);

            var result = service.GetAllProducts();
            Assert.AreEqual(products.Count, result.Count);


        }



    }
}
