namespace apex_service.Models
{
   public class Source
    {
        public int id { get; set; }
        public string sourceName { get; set; } // Tên nguồn gọi
        public int totalCustomers { get; set; } // Tổng KH
        public string createdBy { get; set; } // Tạo bởi
        public string recentEditor { get; set; } // Người Edit gần nhất
        public DateTime creationDate { get; set; } // Ngày tạo
        public string note { get; set; } // note
        // ... other properties based on columns in your table
    }
}
