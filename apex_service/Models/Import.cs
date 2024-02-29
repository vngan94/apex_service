namespace apex_service.Models
{
    public class Import
    {
        public int id { get; set; }
        public string source { get; set; }
        public DateTime dateCreated { get; set; }
        public string fileUpload { get; set; }
        public int duplicateRowExcel { get; set; }
        public int duplicateWithSystem { get; set; }
        public int errors { get; set; }
        public int success { get; set; }
        public string notes { get; set; }
        public int idSource { get; set; }
    }
}
