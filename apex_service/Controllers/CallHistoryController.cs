using apex_service.Models;
using Microsoft.AspNetCore.Mvc;

namespace apex_service.Controllers
{
    public class CallHistoryController : Controller
    {
        List<CallHistory> callHistories = new List<CallHistory>
        {
            new CallHistory
            {
                stt = 1,
                callId = 1,
                agent = "Agent1",
                maKhachHang = "CUST001",
                soDienThoai = "0123456789",
                thoiGianBatDau = DateTime.Now,
                thoiGianKetThuc = DateTime.Now.AddMinutes(5),
                thoiGianDoChuong = DateTime.Now,
                thoiGianTraLoi = DateTime.Now.AddSeconds(10),
                loaiCuocGoi = "Inbound",
                trangThaiCuocGoi = "Completed",
                chienDich = "Campaign1",
                mien = "North",
                ketThucBoi = "Customer",
                ghiAm = true
            },
            new CallHistory
            {
                stt = 2,
                callId = 2,
                agent = "Agent2",
                maKhachHang = "CUST002",
                soDienThoai = "0987654321",
                thoiGianBatDau = DateTime.Now,
                thoiGianKetThuc = DateTime.Now.AddMinutes(3),
                thoiGianDoChuong = DateTime.Now,
                thoiGianTraLoi = DateTime.Now.AddSeconds(5),
                loaiCuocGoi = "Outbound",
                trangThaiCuocGoi = "Not Answered",
                chienDich = "Campaign2",
                mien = "South",
                ketThucBoi = "Agent",
                ghiAm = false
            }
        };
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [Route("callhistories")]
        public IActionResult Campaigns()
        {
            // Return the list with an OK status code (200)
            return Ok(callHistories);
        }

    }
}
