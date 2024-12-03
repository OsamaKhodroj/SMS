using Skynet.ERP.Domains;
using Skynet.ERP.Services;
using System.Linq;
namespace Skynet.ERP.SchoolManagmentSystemConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Todo

            var stuService = new StudentService();
            stuService.Insert(new Student()
            {
                Id = 1,
                Name = "Osama",
                Address = "Amman",
                PhoneNumber = "1234567890",
                EmailAddress = "osama@osama.com",
                Password = "102030"
            });

            stuService.Insert(new Student()
            {
                Id = 2,
                Name = "Ahmad",
                Address = "Zarqa",
                PhoneNumber = "9876354321",
                EmailAddress = "ahmad@osama.com",
                Password = "1111111"
            });
  
            //foreach (var item in order_1)
            //{
            //    Console.WriteLine($"Student Id: {item.Id}");
            //    Console.WriteLine($"Student Name: {item.Name}");
            //    Console.WriteLine($"Student Address: {item.Address}");
            //    Console.WriteLine($"Student Phone Number: {item.PhoneNumber}");
            //    Console.WriteLine($"Student Created Date: {item.CreatedDateTime}");
            //    Console.WriteLine($"Student Email Address: {item.EmailAddress}");
            //    Console.WriteLine($"Student Password: {item.Password}");
            //    Console.WriteLine($"***********************************************");
            //}

            #endregion 
        }
    }
}
