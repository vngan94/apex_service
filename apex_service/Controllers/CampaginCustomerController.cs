using apex_service.Models;
using Microsoft.AspNetCore.Mvc;

namespace apex_service.Controllers
{
    public class CampaginCustomerController : Controller
    {
        private List<Campaign_Customer> campaignCustomers = new List<Campaign_Customer>
        {
            new Campaign_Customer
            {
                stt = 1,
                name = "John Doe",
                customerId = 101,
                phone = "123-456-7890",
                region = "North",
                userres = "User1",
                responsibleUser = "Manager1",
                resultCall = "Interested",
                receiveUser = "User2",
                callStatus = 1,
                statusOfCall = "Completed",
                reason = "N/A",
                campaignId = 1
            },
            new Campaign_Customer
            {
                stt = 2,
                name = "Jane Smith",
                customerId = 102,
                phone = "098-765-4321",
                region = "South",
                userres = "User3",
                responsibleUser = "Manager2",
                resultCall = "Not Interested",
                receiveUser = "User4",
                callStatus = 2,
                statusOfCall = "No Answer",
                reason = "Busy",
                campaignId = 1
            },
            new Campaign_Customer
            {
                stt = 3,
                name = "Emily Johnson",
                customerId = 103,
                phone = "555-123-4567",
                region = "East",
                userres = "User5",
                responsibleUser = "Manager3",
                resultCall = "Callback",
                receiveUser = "User6",
                callStatus = 3,
                statusOfCall = "Left Message",
                reason = "Requested Callback",
                campaignId = 2
            }
        };

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [Route("campaign_customers")]
        public IActionResult sourceCustomerController()
        {

            // Return the list with an OK status code (200)
            return Ok(campaignCustomers);
            //});
        }
    }
}
