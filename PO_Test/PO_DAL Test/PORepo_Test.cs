using System;
using Xunit;
using Moq;
using PO_DAL;
//using PO_DAL.Models;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Autofac.Extras.Moq;
using AutoFixture.Xunit2;
using Xunit.Extensions;
namespace PO_Test
{
    public class PORepo_Test
    {
        public IPORepo MockPORepo;
        Mock<IPORepo> mockRepository = new Mock<IPORepo>();

        //List<Vendors> vendors = new List<Vendors>()
        //    {
        //        new Vendors{VendorId=1001, VendorName="Mock Vendor",EmailId="mock@gmail.com",Address="123 hjkll dfhkhdf MH",Status="Active"},
        //        new Vendors{VendorId=1002,VendorName="Mock Vendor2",EmailId="mock@gmail.com2",Address="123 hjkll dfhkhdf MH22",Status="Active",},

        //    };

        //[Fact]
        //public void CanReturnAllVendors()
        //{ 
           
        //    //Arrange
        //    mockRepository.Setup(s => s.GetAllVendors()).Returns(vendors);
        //    this.MockPORepo = mockRepository.Object;

        //    //Act
        //    List<Vendors> testVendors = this.MockPORepo.GetAllVendors();

        //    //Assert
        //    Assert.NotNull(testVendors);
        //    Assert.Equal(2, testVendors.Count);
        //}

        //[Theory]
        //[InlineData(1001, "Mock Vendor")]
        //[InlineData(1002, "Mock Vendor2")]
        //public void ShouldReturnVendorById(int VendId,string VendName)
        //{
        //    //Arrange
        //    mockRepository.Setup(s => s.vendorById(It.IsAny<int>())).Returns((int i) => vendors.Where(x => x.VendorId == i).Single());
        //    this.MockPORepo = mockRepository.Object;

        //    //Act
        //    Vendors venObj = this.MockPORepo.vendorById(VendId);

        //    //Assert
        //    Assert.NotNull(venObj);
        //    Assert.Equal(VendName, venObj.VendorName);

        //}

        //[Fact]
        //public void CanAddVendors()
        //{
        //    Vendors newVendor = new Vendors
        //    { VendorId = 1003, VendorName = "Mock Vendor", EmailId = "mock@gmail.com", Address = "123 hjkll dfhkhdf MH", Status = "Active" };
        //    Mock<IPORepo> mockRepository = new Mock<IPORepo>();

          
        //    mockRepository.Setup(s => s.AddVendor(It.IsAny<Vendors>()))
        //                   .Returns(true);

        //    this.MockPORepo = mockRepository.Object;

        //    bool status=  this.MockPORepo.AddVendor(newVendor);
        //    Assert.True(status);


        //}



       












        ////  public DBContext TestContext { get; set; }

        ////[Fact]
        ////public void Test1()
        ////{
        ////    var moqContext = new Mock<PoDBContext>();
        ////    moqContext.Setup(s => s.Vendors.ToList())
        ////               .Returns(GetSampleVendor());

        ////    PORepo repoObj = new PORepo(moqContext.Object);

        ////   var actual= repoObj.GetAllVendors();

        ////    Assert.True(actual != null);

        ////}
        ////[Fact]
        ////public void GetAllVendors_validCall()
        ////{
        ////    //  VendorController vendor = new VendorController();
        ////    using (var mock = AutoMock.GetLoose()) {

        ////        mock.Mock<PoDBContext>()
        ////            .Setup(x => x.Vendors.ToList())
        ////            .Returns(GetSampleVendor());

        ////        var cls = mock.Create<Vendors>();
        ////        var exp = GetSampleVendor();

        ////        var actual = cls.VendorName;
        ////        Assert.True(actual != null);

        ////    }

        ////}

        ////private List<Vendors> GetSampleVendor()
        ////{
        ////    List<Vendors> output = new List<Vendors>()
        ////    {
        ////        new Vendors
        ////        {
        ////            VendorId=1001,
        ////            VendorName="Mock Vendor",
        ////            EmailId="mock@gmail.com",
        ////            Address="123 hjkll dfhkhdf MH",
        ////            Status="Active",
        ////        },
        ////         new Vendors
        ////        {
        ////            VendorId=1002,
        ////            VendorName="Mock Vendor2",
        ////            EmailId="mock@gmail.com2",
        ////            Address="123 hjkll dfhkhdf MH22",
        ////            Status="Active",
        ////        },

        ////    };
        ////    return output;
        ////}
        ////[Fact]
        ////public void test3()
        ////{
        ////    var moqContext = new Mock<PoDBContext>();
        ////    moqContext.Setup(s => s.Vendors.Add(new Vendors()
        ////    ));

        ////    var venobj = new Vendors()
        ////    {
        ////        VendorId = 1001,
        ////        VendorName = "Mock Vendor12131",
        ////        EmailId = "mock@gmail.com",
        ////        Address = "123 hjkll dfhkhdf MH",
        ////        Status = "Active",
        ////    };
        ////    PORepo repoObj = new PORepo(moqContext.Object);

        ////    var actual = repoObj.AddVendor(venobj);
        ////   // var expected = true;

        ////    Assert.True(actual);

        ////}


        ////[Theory]
        ////[InlineData("umeshgupta8213@gmail.com","ghghgh1544")]
        ////[InlineData(null, "ghghgh1544")]

        ////public void addUser_test(string userId, string pwd)
        ////{
        ////    var userMock = new Mock<PoDBContext>();
        ////    userMock.Setup(x => x.Users.Add(It.IsAny<Users>()));

        ////    PORepo repoObj = new PORepo(userMock.Object);

        ////    bool actual = repoObj.AddUser(userId, pwd);
        ////    bool expected = true;

        ////    Assert.Equal(actual,expected);



        ////}




    }
}
