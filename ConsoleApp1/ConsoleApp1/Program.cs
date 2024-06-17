using System.Reflection.PortableExecutable;
using ConsoleApp1.data;
using ConsoleApp1.Model;
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
                _headerService.Add(line, ref identID, ref CrHeaderId);
            }
            else if (line.StartsWith("INV.VEHICLE") || line.StartsWith("RO.VEHICLE"))
            {
                _vEHICLEService.Add(line, ref CrHeaderId);
            }
            else if (line.StartsWith("INV.CCR") || line.StartsWith("RO.CCR"))
            {
                _rCCRService.Add(line, ref CrHeaderId);
            }
            else if (line.StartsWith("INV.CONTACT") || line.StartsWith("RO.CONTACT"))
            {
                cONTACTService.Add(line, ref CrHeaderId);
            }
            else if (line.StartsWith("INV.CUSTOMER") || line.StartsWith("RO.CUSTOMER"))
            {
                customerService.Add(line, ref CrHeaderId);
            }
            else if (line.StartsWith("INV.JOB") || line.StartsWith("RO.JOB"))
            {
                jOBService.Add(line, ref CrHeaderId);
            }
            else if (line.StartsWith("INV.LABORLINE") || line.StartsWith("RO.LABORLINE"))
            {
                LABORLINEService.Add(line, ref CrHeaderId);
            }
            else if (line.StartsWith("INV.MISC") || line.StartsWith("RO.MISC"))
            {
                MISCService.Add(line, ref CrHeaderId);
            }
            else if (line.StartsWith("INV.PARTLINE") || line.StartsWith("RO.PARTLINE"))
            {
                partLineService.Add(line, ref CrHeaderId);
            }
            else if (line.StartsWith("INV.PRIVACY") || line.StartsWith("RO.PRIVACY"))
            {
                PRIVACYService.Add(line, ref CrHeaderId);
            }
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