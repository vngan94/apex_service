using apex_service.Models;
using Microsoft.AspNetCore.Mvc;

namespace apex_service.Controllers
{

    public class CustomerController : Controller
    {
        private List<Customer> customers = new List<Customer>
        {
                new Customer
                {
                    id = 1,
                    dateCreated = DateTime.Now,
                    dateModified = DateTime.Now,
                    createdBy = "Admin",
                    createdByName = "Admin User",
                    modifiedBy = "User1",
                    modifiedByName = "John Doe",
                    note = "This is a sample note.",
                    agent = "Agent123",
                    subject = "Customer Inquiry",
                    callStatus = "Open",
                    name = "John Smith",
                    status = "Active",
                    cdCampaign = "Campaign123",
                    cdSegment = "Segment456",
                    nhmHanmucTang = "Hanmuc123",
                    phone2 = "123-456-7890",
                    ngaysinh = new DateTime(1990, 1, 1),
                    tgTermowner = "Termowner123",
                    cmnd = "123456789",
                    cmndNoicap = "Noicap123",
                    vung = "Vung456",
                    cdObDate = DateTime.Now,
                    onboardLoaithe = "Loaithe123",
                    tgNoCard = "NoCard456",
                    tgHaveInstal2022 = "HaveInstal2022",
                    tuoi = 30,
                    ttkTtkichhoatDebit = "TtkichhoatDebit123",
                    ttkCardType = "CardType456",
                    cdTd = "Td123",
                    diachi = "123 Main Street",
                    tgPropensityScore2 = 75.5,
                    stt = 1,
                    tgGroupHaveInterest = "GroupInterest123",
                    tgCreditLimit = 5000.0,
                    phone = "987-654-3210",
                    cdRegion = "Region123",
                    nhmLoaithe = "Loaithe789",
                    onboardSanphamdadung = "Sanphamdadung123",
                    ttkNgaytaoekyc = DateTime.Now,
                    gioitinh = "Male",
                    ttkIssuedatetoprocessdate = "Issuedate123",
                    nhmNgaysaoke = DateTime.Now,
                    cmndNgaycap = DateTime.Now,
                    tenchinhanh = "Chinhanh123",
                    cdCurrentAddress = "456 Side Street",
                    nhmHanmucHt = "HanmucHt123",
                    cdCasa = "Casa456",
                    cdLending = "Lending123",
                    email = "john.smith@example.com",
                    tgTransactionAmount = 1000.0,
                    ttkTypeIssue = "TypeIssue123",
                    machinhanh = "Machinhanh456",
                    cdCreditCardLimit = 2000.0,
                    ttkTrangthailogin = "Trangthailogin123",
                    onboardCussince = DateTime.Now,
                    tgTransactorRevolver = "TransactorRevolver123",
                    onboardSpdamo = "Spdamo123",
                    thePropensityScore = 80.0,
                    nhmLoaithehtCao = "LoaithehtCao123",
                    theSuggestedLimit = 3000.0,
                    cdConsultationtime = DateTime.Now,
                    cdProductsRequire = "ProductsRequire123",
                    theOldNew = "OldNew123",
                    nhmHanmuc = "Hanmuc456",
                    fieldTab = "FieldTab123",
                    hhNgayhethan = DateTime.Now,
                    hhLimitCms = 1500.0,
                    hhLoaithe = "Loaithe456",
                    hhVnaId = "VnaId123",
                    cdSavedate = DateTime.Now,
                    source = "Source123",
                    idImport = 1,
                    error = "Error123",
                    customerId = 1001,
                    fkDSG = "DSG123",
                    oTP = "654321",
                    maHocVien = "MHV002",
                    field67 = "FieldValue2"
                },
                new Customer
                {
                     id = 2,
                    dateCreated = DateTime.Now,
                    dateModified = DateTime.Now,
                    createdBy = "Admin 2 ",
                    createdByName = "Admin User 2",
                    modifiedBy = "User2",
                    modifiedByName = "John Doe 2",
                    note = "This is a sample note. 2",
                    agent = "Agent123 2",
                    subject = "Customer Inquiry 2",
                    callStatus = "Open ",
                    name = "David Beckhend",
                    status = "Active",
                    cdCampaign = "Campaign123",
                    cdSegment = "Segment456",
                    nhmHanmucTang = "Hanmuc123",
                    phone2 = "123-456-7890",
                    ngaysinh = new DateTime(1990, 1, 1),
                    tgTermowner = "Termowner123x",
                    cmnd = "123456789x",
                    cmndNoicap = "Noicap123x",
                    vung = "Vung456x",
                    cdObDate = DateTime.Now,
                    onboardLoaithe = "Loaithe123x",
                    tgNoCard = "NoCard456x",
                    tgHaveInstal2022 = "HaveInstal2022x",
                    tuoi = 30,
                    ttkTtkichhoatDebit = "TtkichhoatDebit123x",
                    ttkCardType = "CardType4526x",
                    cdTd = "Td123x",
                    diachi = "123 Main Streetx",
                    tgPropensityScore2 = 75.5,
                    stt = 1,
                    tgGroupHaveInterest = "GroupInterest123x",
                    tgCreditLimit = 5000.0,
                    phone = "987-654-3210x",
                    cdRegion = "Region123x",
                    nhmLoaithe = "Loaithe789x",
                    onboardSanphamdadung = "Sanphamdadung123x",
                    ttkNgaytaoekyc = DateTime.Now,
                    gioitinh = "Malex",
                    ttkIssuedatetoprocessdate = "Issuedate12x3",
                    nhmNgaysaoke = DateTime.Now,
                    cmndNgaycap = DateTime.Now,
                    tenchinhanh = "Chinhanh123x",
                    cdCurrentAddress = "456 Side Streetx",
                    nhmHanmucHt = "HanmucHt123x",
                    cdCasa = "Casa456x",
                    cdLending = "Lending123x",
                    email = "john.smithx@example.com",
                    tgTransactionAmount = 1000.0,
                    ttkTypeIssue = "TypeIssue123x",
                    machinhanh = "Machinhanh456x",
                    cdCreditCardLimit = 2000.0,
                    ttkTrangthailogin = "Trangthailogin123x",
                    onboardCussince = DateTime.Now,
                    tgTransactorRevolver = "TransactorRevolver123x",
                    onboardSpdamo = "Spdamo123x",
                    thePropensityScore = 80.0,
                    nhmLoaithehtCao = "LoaithehtCao123x",
                    theSuggestedLimit = 3000.0,
                    cdConsultationtime = DateTime.Now,
                    cdProductsRequire = "ProductsRequire123x",
                    theOldNew = "OldNew123x",
                    nhmHanmuc = "Hanmuc456x",
                    fieldTab = "FieldTab123x",
                    hhNgayhethan = DateTime.Now,
                    hhLimitCms = 1500.0,
                    hhLoaithe = "Loaithe456x",
                    hhVnaId = "VnaId123x",
                    cdSavedate = DateTime.Now,
                    source = "Source123x",
                    idImport = 1,
                    error = "Error123x",
                    customerId = 1002,
                    fkDSG = "DSG123x",
                    oTP = "654321x",
                    maHocVien = "MHV002x",
                    field67 = "FieldValue2x"
                },
                // Add more static customers as needed
            };
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("customers")]
        public IActionResult customersController()
        {
            // Return the list with an OK status code (200)
            return Ok(customers);
           
        }

        [HttpGet]
        [Route("customers/{id}")]
        public IActionResult GetCustomerById(int id)
        {
            // Find the customer by ID
            var customer = customers.FirstOrDefault(c => c.id == id);

            // If no customer found, return NotFound (404)
            if (customer == null)
            {
                return NotFound();
            }

            // Return the found customer with an OK status code (200)
            return Ok(customer);
        }

        [HttpPost]
        [Route("customers")]
        public IActionResult CreateCustomer([FromBody] Customer customer)
        {

            // Assuming you have a way to generate a new ID, 
            // and the list 'customers' is accessible to modify.
            int newId = customers.Any() ? customers.Max(c => c.id) + 1 : 100;
           

            customers.Add(customer); // Add the new customer to the list
          
            // The 'CreatedAtAction' is used to create the HTTP 201 status code
            // and will typically return a URI to the newly created resource.
             return Ok(customers);
        }

    }
}
