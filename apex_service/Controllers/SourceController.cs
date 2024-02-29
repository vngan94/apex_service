using apex_service.Models;
using Microsoft.AspNetCore.Mvc;

namespace apex_service.Controllers
{
    public class SourceController : Controller
    {
        List<Source> sources = new List<Source>
            {
                // Add your Source objects here
                new Source
                {
                    id = 1,
                    sourceName = "demo01",
                    totalCustomers = 2,
                    createdBy = "Admin Admin (admin)",
                    recentEditor = "Admin Admin (admin)",
                    creationDate = new DateTime(2023, 12, 25, 14, 31, 10),
                    note = "OK",
                },
                 new Source
                {
                     id = 2,
                    sourceName = "demo02",
                    totalCustomers = 3,
                    createdBy = "Admin Gags (admin)",
                    recentEditor = "Admin Gags (admin)",
                    creationDate = new DateTime(2023, 12, 26, 14, 31, 10),
                     note = "OK 2",
                },

            };
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("sources")]
        public IActionResult sourceController()
        {
            // Return the list with an OK status code (200)
            return Ok(sources);
            //});
        }
        [HttpGet]
        [Route("sourcesAdd")]
        public IActionResult sourceAddController()
        {
            // Return the list with an OK status code (200)
            return Ok(new SourceAdd
            {
                id=1,
                name="sourceAdd",
                note="ok"
            });;
            //});
        }

        [HttpPost]
        [Route("sources")]
        public IActionResult CreateCustomer([FromBody] Source source)
        {


            // Assuming you have a way to generate a new ID, 
            // and the list 'customers' is accessible to modify.
            int newId = sources.Any() ? sources.Max(c => c.id) + 1 : 100;


            sources.Add(source); // Add the new customer to the list

            // The 'CreatedAtAction' is used to create the HTTP 201 status code
            // and will typically return a URI to the newly created resource.
            Console.WriteLine("sources.Count: " + sources.Count);
            return Ok(sources.Count);
        }

    }
}
