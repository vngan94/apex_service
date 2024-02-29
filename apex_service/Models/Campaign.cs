namespace apex_service.Models
{
    public class Campaign
    {
        public int maCD { get; set; }
        public string chienDich { get; set; }
        public int nguonId { get; set; }
        public DateTime ngayTao { get; set; }
        public string taoBoi { get; set; }
        public DateTime batDau { get; set; }
        public DateTime ketThuc { get; set; }

        public int queue { get; set; }
        public int trangThaiId { get; set; }

        public int tongKH { get; set; } // Total customers
        public int khChuaTacDong { get; set; } // Customers not yet active
        public int khBatMayNhugKhongGapAgent { get; set; } // Customers who answered but did not meet the agent
        public int khConLai { get; set; } // Remaining customers
        public int khKhoiThucDuoc { get; set; } // Customers who could not be initiated
        public string nhanVienSanSang { get; set; } // Agents ready

        public string sanPham { get; set; } // Product
        public string tenChienDich { get; set; } // Campaign Name
        public DateTime ngayBatDau { get; set; } // Start Date
        public int soLanGoiToiDa { get; set; } // Max Call Attempts
        public int soLuongGoiMax { get; set; } // Max Calls per agent available
        public int maxChannel { get; set; }
        public int cheDoGoiId { get; set; } // Dialing Mode

        public DateTime ngayKetThuc { get; set; } // End Date
        public int acwTime { get; set; } // After Call Work Time in seconds
        public int khoangThoiGianGoiLai { get; set; } // Time between retries in minutes






    }
}
