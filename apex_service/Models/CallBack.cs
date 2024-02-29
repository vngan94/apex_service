namespace apex_service.Models
{
    public class CallBack
{
    public int id { get; set; } // Assuming there is an ID column which is not visible in the image.
    public string phoneNumberSet { get; set; } // SDT đã đặt
    public DateTime callBackTime { get; set; } // Thời gian gọi lại
    public DateTime creationDate { get; set; } // Ngày tạo
    public string customerName { get; set; } // Tên KH
    public string customerCode { get; set; } // Mã KH
    public string campaign { get; set; } // Chiến dịch
    public string phoneNumber { get; set; } // SDT KH
    public string status { get; set; } // Trạng thái
    public string agentName { get; set; } // Tên agent
    public string notes { get; set; } // Ghi chú
}
}
