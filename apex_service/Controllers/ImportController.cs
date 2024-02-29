using apex_service.Models;
using Microsoft.AspNetCore.Mvc;

namespace apex_service.Controllers
{

    public class ImportController : Controller
    {
        List<Import> importList = new List<Import>
        {
            new Import
            {
                id = 1,
                source = "Source1",
                dateCreated = DateTime.Now,
                fileUpload = "file1.xlsx",
                duplicateRowExcel = 0,
                duplicateWithSystem = 0,
                errors = 1,
                success = 10,
                notes = "First import",
                idSource = 1
            },
            new Import
            {
                id = 2,
                source = "Source1",
                dateCreated = DateTime.Now,
                fileUpload = "file2.xlsx",
                duplicateRowExcel = 2,
                duplicateWithSystem = 1,
                errors = 0,
                success = 8,
                notes = "First import",
                idSource = 1
            },
            new Import
            {
                id = 3,
                source = "Source2",
                dateCreated = DateTime.Now,
                fileUpload = "file3.xlsx",
                duplicateRowExcel = 2,
                duplicateWithSystem = 1,
                errors = 0,
                success = 3,
                notes = "Second import",
                 idSource = 2
            },
            new Import
            {
                id = 4,
                source = "Source4",
                dateCreated = DateTime.Now,
                fileUpload = "file3.xlsx",
                duplicateRowExcel = 2,
                duplicateWithSystem = 1,
                errors = 0,
                success = 3,
                notes = "Second import",
                idSource = 4
            }
            // Add more Import objects as needed
        };


        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("imports")]
        public IActionResult importController()
        {
            // Return the list with an OK status code (200)
            return Ok(importList);
            //});
        }

        [HttpPost]
        [Route("imports")]
        public IActionResult CreateImports([FromBody] Import import)
        {


            // Assuming you have a way to generate a new ID, 
            // and the list 'customers' is accessible to modify.
            int newId = importList.Any() ? importList.Max(c => c.id) + 1 : 100;


            importList.Add(import); // Add the new customer to the list

            // The 'CreatedAtAction' is used to create the HTTP 201 status code
            // and will typically return a URI to the newly created resource.
            Console.WriteLine("importList.Count: " + importList.Count);
            return Ok(importList.Count);
        }
    }
}
