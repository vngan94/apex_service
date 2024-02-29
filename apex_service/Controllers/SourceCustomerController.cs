using apex_service.Models;
using Microsoft.AspNetCore.Mvc;

namespace apex_service.Controllers
{
    public class SourceCustomerController : Controller
    {
        List<SourceCustomer> sourceCustomers = new List<SourceCustomer>
            {
                // Add your Source objects here
               new SourceCustomer
            {
                id = 1,
                idSource = 1,
                customerId = 88888888,
                ten = "Sang",
                ngaySinh = new DateTime(1990, 1, 1), // example date
                gioiTinh = "Male",
                cmndHc = "123456789",
                sdt = "0366735212",
                diaChi = "123 Main Street",
                email = "sang@example.com",
                dateCreated = new DateTime(2023, 12, 26, 14, 31, 00)
            },
            new SourceCustomer
            {
                id = 2,
                idSource = 1,
                customerId = 88888890,
                ten = "Tung",
                ngaySinh = new DateTime(1992, 5, 21), // example date
                gioiTinh = "Male",
                cmndHc = "987654321",
                sdt = "0396054204",
                diaChi = "456 Side Street",
                email = "tung@example.com",
                dateCreated = new DateTime(2023, 12, 26, 14, 31, 00)
            },
            new SourceCustomer
            {
                id = 3,
                idSource = 2,
                customerId = 88888890,
                ten = "Quan",
                ngaySinh = new DateTime(1992, 5, 21), // example date
                gioiTinh = "Male",
                cmndHc = "987654321",
                sdt = "0396054204",
                diaChi = "456 Side Street",
                email = "tung@example.com",
                dateCreated = new DateTime(2023, 12, 26, 14, 31, 00)
            },
            new SourceCustomer
            {
                id = 4,
                idSource = 2,
                customerId = 88888890,
                ten = "Linh",
                ngaySinh = new DateTime(1992, 5, 21), // example date
                gioiTinh = "Male",
                cmndHc = "987654321",
                sdt = "0396054204",
                diaChi = "456 Side Street",
                email = "tung@example.com",
                dateCreated = new DateTime(2023, 12, 26, 14, 31, 00)
            },
            new SourceCustomer
            {
                id = 5,
                idSource = 2,
                customerId = 88888890,
                ten = "Tung",
                ngaySinh = new DateTime(1992, 5, 21), // example date
                gioiTinh = "Male",
                cmndHc = "987654321",
                sdt = "0396054204",
                diaChi = "456 Side Street",
                email = "tung@example.com",
                dateCreated = new DateTime(2023, 12, 26, 14, 31, 00)
            },



            };

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [Route("source_customers")]
        public IActionResult sourceCustomerController()
        {

            // Return the list with an OK status code (200)
            return Ok(sourceCustomers);
            //});
        }

    }
}
