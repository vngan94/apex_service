using apex_service.Models;
using Microsoft.AspNetCore.Mvc;

namespace apex_service.Controllers
{
    public class Campaign_AgentController : Controller
    {
        List<Campaign_Agent> agentList = new List<Campaign_Agent>
            {
                new Campaign_Agent { id = 1, account = "account1", name = "Agent 1", nhomAgent = "Alex", nhomAgentId="1", numberCustomer = "100", campaignId=1 },
                new Campaign_Agent { id = 2, account = "account2", name = "Agent 2", nhomAgent = "IT Test", nhomAgentId="2", numberCustomer = "2", campaignId=1 },
                                new Campaign_Agent { id = 3, account = "account3", name = "Agent 1", nhomAgent = "Alex", nhomAgentId="1", numberCustomer = "100", campaignId=2 },
                new Campaign_Agent { id = 4, account = "account 4", name = "IT Test", nhomAgent = "IT Test",nhomAgentId="2", numberCustomer = "2", campaignId=2}

            };
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [Route("campaign_team_agents")]
        public IActionResult importController()
        {
            // Return the list with an OK status code (200)
            return Ok(agentList);
            //});
        }
    }
}
