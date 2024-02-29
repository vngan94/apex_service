using apex_service.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace apex_service.Controllers
{
    public class CampaignController : Controller
    {
        // Simulated data for demonstration
        private List<Campaign> campaigns = new List<Campaign>
        {
            new Campaign { maCD = 1, chienDich = "Campaign 1", nguonId = 1, ngayTao = DateTime.Now, taoBoi = "Creator 1", batDau = DateTime.Now, ketThuc = DateTime.Now, queue = 1, trangThaiId = 1, tongKH = 100, khChuaTacDong = 20, khBatMayNhugKhongGapAgent = 10, khConLai = 70, khKhoiThucDuoc = 60, nhanVienSanSang = "1:2", sanPham = "1", tenChienDich = "Campaign 1", ngayBatDau = DateTime.Now, soLanGoiToiDa = 3, soLuongGoiMax = 50, maxChannel = 2, cheDoGoiId = 1, ngayKetThuc = DateTime.Now, acwTime = 30, khoangThoiGianGoiLai = 10 },
            new Campaign { maCD = 2, chienDich = "Campaign 2", nguonId = 2, ngayTao = DateTime.Now, taoBoi = "Creator 2", batDau = DateTime.Now, ketThuc = DateTime.Now, queue = 2, trangThaiId = 2, tongKH = 150, khChuaTacDong = 30, khBatMayNhugKhongGapAgent = 20, khConLai = 100, khKhoiThucDuoc = 90, nhanVienSanSang = "2:3", sanPham = "2", tenChienDich = "Campaign 2", ngayBatDau = DateTime.Now, soLanGoiToiDa = 2, soLuongGoiMax = 40, maxChannel = 3, cheDoGoiId = 2, ngayKetThuc = DateTime.Now, acwTime = 20, khoangThoiGianGoiLai = 15 }
            // Add more campaigns as needed
            //new Campaign { maCD = 1 },
            


        };

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("campaigns")]
        public IActionResult Campaigns()
        {
            return Ok(campaigns);
        }
        [HttpGet]
        [Route("campaigns/{id}")]
        public IActionResult Campaign(int id)
        {
            Console.WriteLine("check");
            // Find the campaign by maCD
            var campaign = campaigns.Find(c => c.maCD == id);
            if (campaign != null)
            {
                return Ok(new Campaign { maCD = 2, nhanVienSanSang = "1:3" });
            }
            else
            {
                return NotFound();
            }
        }


    }
}
