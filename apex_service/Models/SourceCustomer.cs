namespace apex_service.Models
{
    public class SourceCustomer
    {
        public int id { get; set; }
        public int idSource { get; set; }
        public int customerId { get; set; }
        public string ten { get; set; }
        public DateTime ngaySinh { get; set; }
        public string gioiTinh { get; set; }
        public string cmndHc { get; set; }
        public string sdt { get; set; }
        public string diaChi { get; set; } // Assuming it's a string. Adjust the type if necessary.
        public string email { get; set; } // Assuming it's a string. Adjust the type if necessary.
        public DateTime dateCreated { get; set; }
    }
}
