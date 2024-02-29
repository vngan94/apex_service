using apex_service.Models;
using Microsoft.AspNetCore.Mvc;

namespace apex_service.Controllers
{
    public class CallBackController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("callbacks")]
        public IActionResult callBackController()
        {
            List<CallBack> callBacks = new List<CallBack>
            {
                new CallBack
                {
                    id = 1,
                    phoneNumberSet = "0123456789",
                    callBackTime = DateTime.Now.AddHours(2),
                    creationDate = DateTime.Today,
                    customerName = "John Doe",
                    customerCode = "C001",
                    campaign = "Spring Sale",
                    phoneNumber = "0987654321",
                    status = "Pending",
                    agentName = "Agent Smith",
                    notes = "Needs follow-up"
                },
                 new CallBack
                {
                    id = 2,
                    phoneNumberSet = "20123456789",
                    callBackTime = DateTime.Now.AddHours(2),
                    creationDate = DateTime.Today,
                    customerName = "Daneil",
                    customerCode = "C002",
                    campaign = "Autumne Sale",
                    phoneNumber = "0654343",
                    status = "Done",
                    agentName = "Agent Lame",
                    notes = "Nothing"
                },
                // Add more CallBack objects here
            };

          

            // Return the list with an OK status code (200)
            return Ok(callBacks);
            //});
        }
    }
}
