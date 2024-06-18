using System.Reflection.PortableExecutable;
using ConsoleApp1.data;
using ConsoleApp1.Model;
using ConsoleApp1.Repository;
using ConsoleApp1.Service;





string filePath = "C:\\Users\\ANH KIET\\Downloads\\XXXX_DAILY_INVOICES_20231215_162415.EDI";
IDENTService _iDENTService = new IDENTService();
HEADERService _headerService = new HEADERService();
VEHICLEService _vEHICLEService = new VEHICLEService();
CCRService _rCCRService = new CCRService();
CONTACTService cONTACTService = new CONTACTService();
CUSTOMERService customerService = new CUSTOMERService();
JOBService jOBService = new JOBService();
LABORLINEService LABORLINEService = new LABORLINEService();
PARTLINEService partLineService = new PARTLINEService();
PRIVACYService PRIVACYService = new PRIVACYService();
MISCService MISCService = new MISCService();
Guid identID = new Guid();
Guid CrHeaderId = new Guid();



var listHeader = new List<HEADER>();
var listVEHICLE = new List<VEHICLE>();
var listJOB = new List<JOB>();
var listCustomer = new List<CUSTOMER>();
var listCONTACT = new List<CONTACT>();
var listPRIVACY = new List<PRIVACY>();
var listPARTLINE = new List<PARTLINE>();
var listLABORLINE = new List<LABORLINE>();
var listCCR = new List<CCR>();
var listMISC = new List<MISC>();
int count = 0;
int maxSize = 200;
try
{


    using (var context = new ApplicationDBContext())
    {
        context.Database.EnsureCreated();
        if (!File.Exists(filePath))
        {
            return;
        }
        string[] lines = File.ReadAllLines(filePath);
        foreach (string line in lines)
        {
            if (line.StartsWith("INV.IDENT") || line.StartsWith("RO.IDENT"))
            {
                _iDENTService.Add(line, ref identID);
            }
            else if (line.StartsWith("INV.HEADER") || line.StartsWith("RO.HEADER"))
            {
                _headerService.Add(line, ref identID, ref CrHeaderId, ref listHeader);
                count++;
            }
            else if (line.StartsWith("INV.VEHICLE") || line.StartsWith("RO.VEHICLE"))
            {
                _vEHICLEService.Add(line, ref CrHeaderId, ref listVEHICLE);
            }
            else if (line.StartsWith("INV.CCR") || line.StartsWith("RO.CCR"))
            {
                _rCCRService.Add(line, ref CrHeaderId, ref listCCR);
            }
            else if (line.StartsWith("INV.CONTACT") || line.StartsWith("RO.CONTACT"))
            {
                cONTACTService.Add(line, ref CrHeaderId, ref listCONTACT);
            }
            else if (line.StartsWith("INV.CUSTOMER") || line.StartsWith("RO.CUSTOMER"))
            {
                customerService.Add(line, ref CrHeaderId, ref listCustomer);
            }
            else if (line.StartsWith("INV.JOB") || line.StartsWith("RO.JOB"))
            {
                jOBService.Add(line, ref CrHeaderId, ref listJOB);
            }
            else if (line.StartsWith("INV.LABORLINE") || line.StartsWith("RO.LABORLINE"))
            {
                LABORLINEService.Add(line, ref CrHeaderId,ref listLABORLINE);
            }
            else if (line.StartsWith("INV.MISC") || line.StartsWith("RO.MISC"))
            {
                MISCService.Add(line, ref CrHeaderId, ref listMISC);
            }
            else if (line.StartsWith("INV.PARTLINE") || line.StartsWith("RO.PARTLINE"))
            {
                partLineService.Add(line, ref CrHeaderId, ref listPARTLINE);
            }
            else if (line.StartsWith("INV.PRIVACY") || line.StartsWith("RO.PRIVACY"))
            {
                PRIVACYService.Add(line, ref CrHeaderId, ref listPRIVACY);
            }

            if(count >= 500)
            {
                insert();
                count = 0;
            }
        }

        if (count > 0) {
            insert();
        }



    }


    Console.WriteLine("done");
    Console.ReadKey();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message + ex.StackTrace);
    Console.ReadKey();
}



void insert()
{
    new GenericRepository<HEADER>().BulkInsert(listHeader);
    new GenericRepository<VEHICLE>().BulkInsert(listVEHICLE);
    new GenericRepository<CUSTOMER>().BulkInsert(listCustomer);
    new GenericRepository<CONTACT>().BulkInsert(listCONTACT);
    new GenericRepository<PRIVACY>().BulkInsert(listPRIVACY);
    new GenericRepository<JOB>().BulkInsert(listJOB);
    new GenericRepository<PARTLINE>().BulkInsert(listPARTLINE);
    new GenericRepository<LABORLINE>().BulkInsert(listLABORLINE);
    new GenericRepository<CCR>().BulkInsert(listCCR);
    new GenericRepository<MISC>().BulkInsert(listMISC);

    listHeader.Clear();
    listJOB.Clear();
    listPARTLINE.Clear();
    listMISC.Clear();
    listVEHICLE.Clear();
    listCustomer.Clear();
    listCONTACT.Clear();
    listPRIVACY.Clear();
    listLABORLINE.Clear();
    listJOB.Clear();
    listCCR.Clear();
}