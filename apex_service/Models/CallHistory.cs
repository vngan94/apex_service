namespace apex_service.Models
{
    public class CallHistory
    {
        public int stt { get; set; } // Sequence number or ID
        public int callId { get; set; } // Unique identifier for the call
        public string agent { get; set; } // Agent who made/received the call
        public string maKhachHang { get; set; } // Customer code
        public string soDienThoai { get; set; } // Phone number
        public DateTime thoiGianBatDau { get; set; } // Start time of the call
        public DateTime thoiGianKetThuc { get; set; } // End time of the call
        public DateTime thoiGianDoChuong { get; set; } // Ring time
        public DateTime thoiGianTraLoi { get; set; } // Response time
        public string loaiCuocGoi { get; set; } // Type of call
        public string trangThaiCuocGoi { get; set; } // Status of the call
        public string chienDich { get; set; } // Campaign associated with the call
        public string mien { get; set; } // Region or area
        public string ketThucBoi { get; set; } // Ended by (agent or customer)
        public bool ghiAm { get; set; } // Whether the call was recorded
                                        // Add additional properties here as needed.
    }

}
