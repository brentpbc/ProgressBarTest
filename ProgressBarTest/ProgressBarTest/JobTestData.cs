namespace ProgressBarTest;

public class JobTestData : BaseModel
{
    public string Contract { get; set; }
    public string JobNumber { get; set; }
    public string CustomerName { get; set; }
    public string Address { get; set; }
    public DateTime CreationDate { get; set; }
    public bool IsMyJob { get; set; } = false;
    public string ProjectCode { get; set; }
    public string ProjectDescription { get; set; }
    public string Status { get; set; }
    public string StatusDescription { get; set; }
    public Color StatusColor { get; set; }
    public string SupervisorInitials { get; set; }
    public string SupervisorName { get; set; }
    
    double percentCmpl = 0;
    public double PercentCmpl
    {
        get { return percentCmpl; }
        set { SetProperty(ref percentCmpl, value); }
    }

    public const string CONTRACT_CODE = "CONTRACT";
    public const string JOBNO_CODE = "JOBNO";
    public const string CUSTNO_CODE = "CUSTNO";
    public const string PROJECT_CODE = "PROJECT_CODE";
    public const string SUPERVISOR_CODE = "SUPERVISOR_CODE";
    public const string STATUS_CODE = "STATUS_CODE";
    public const string CREATEDATE_CODE = "CREATEDATE";
    public const string PROJECT_GLEN01_CODE = "GLEN01";
    public const string PROJECT_GLEN01_DESC = "Glendore Estate";
    public const string PROJECT_VALV01_CODE = "VALV01";
    public const string PROJECT_VALV01_DESC = "Valley Views";
    public const string PROJECT_NONE_LABEL = "Project";
    public const string STATUS_NEW_CODE = "NEW";
    public const string STATUS_NEW_DESC = "New Job";
    public static Color STATUS_NEW_COLOR = Colors.Red;
    public const string STATUS_INPROGRESS_CODE = "INPROGRESS";
    public const string STATUS_INPROGRESS_DESC = "In Progress";
    public static Color STATUS_INPROGRESS_COLOR = Colors.Grey;
    public const string STATUS_COMPLETED_CODE = "COMPLETED";
    public const string STATUS_COMPLETED_DESC = "Completed";
    public static Color STATUS_COMPLETED_COLOR = Colors.ForestGreen;
    public const string SUPER_INITIALS_JP1 = "JP1";
    public const string SUPER_NAME_JP1 = "JASON PARK";
    public const string SUPER_INITIALS_BB2 = "BB2";
    public const string SUPER_NAME_BB2 = "Brian Brockman";
    public const string SUPER_INITIALS_DBH = "DBH";
    public const string SUPER_NAME_DBH = "Deborah Hillman";
    public const string SUPER_INITIALS_JJF = "JJF";
    public const string SUPER_NAME_JJF = "Jeff Johnson";
    
    public static List<JobTestData> PopulateData()
    {
        List<JobTestData> data = new List<JobTestData>()
        {
            new JobTestData()
            {
                Contract = "123456",
                JobNumber = "J 123456",
                CustomerName = "Johnson & Johnson",
                Address = "418-420 Hunter Street, Newcastle, NSW, 2300, Australia",
                CreationDate = new DateTime(2021,11,03),
                ProjectCode = PROJECT_VALV01_CODE,
                ProjectDescription = PROJECT_VALV01_DESC,
                Status = STATUS_COMPLETED_CODE,
                StatusDescription = STATUS_COMPLETED_DESC,
                StatusColor = STATUS_COMPLETED_COLOR,
                SupervisorInitials = SUPER_INITIALS_BB2,
                SupervisorName = SUPER_NAME_BB2,
                PercentCmpl = 50
                
            },
            new JobTestData()
            {
                Contract = "200546",
                JobNumber = "J 200546",
                CustomerName = "Hunt & Hunt",
                Address = "21-63 Brunker Rd, Broadmeadow NSW 2292",
                CreationDate = new DateTime(2021,09,24),
                IsMyJob = true,
                ProjectCode = PROJECT_VALV01_CODE,
                ProjectDescription = PROJECT_VALV01_DESC,
                Status = STATUS_COMPLETED_CODE,
                StatusDescription = STATUS_COMPLETED_DESC,
                StatusColor = STATUS_COMPLETED_COLOR,
                SupervisorInitials = SUPER_INITIALS_JP1,
                SupervisorName = SUPER_NAME_JP1,
                PercentCmpl = 100
            },
            new JobTestData()
            {
                Contract = "200547",
                JobNumber = "J 200547",
                CustomerName = "Tran,Tran,Tran",
                Address = "7 Sketchley Parade, New Lambton NSW 2305",
                CreationDate = new DateTime(2022,01,05),
                IsMyJob = true,
                Status = STATUS_INPROGRESS_CODE,
                StatusDescription = STATUS_INPROGRESS_DESC,
                StatusColor = STATUS_INPROGRESS_COLOR,
                SupervisorInitials = SUPER_INITIALS_JP1,
                SupervisorName = SUPER_NAME_JP1,
                PercentCmpl = 32
            },
            new JobTestData()
            {
                Contract = "200548",
                JobNumber = "J 200548",
                CustomerName = "Lother & Lother",
                Address = "14-4 Stonecrop Pl, Garden Suburb NSW 2289",
                CreationDate = new DateTime(2022,01,17),
                ProjectCode = PROJECT_GLEN01_CODE,
                ProjectDescription = PROJECT_GLEN01_DESC,
                Status = STATUS_COMPLETED_CODE,
                StatusDescription = STATUS_COMPLETED_DESC,
                StatusColor = STATUS_COMPLETED_COLOR,
                SupervisorInitials = SUPER_INITIALS_BB2,
                SupervisorName = SUPER_NAME_BB2,
                PercentCmpl = 5
            },
            new JobTestData()
            {
                Contract = "999999",
                JobNumber = "J 999999",
                CustomerName = "Avery & Avery",
                Address = "1-13 Providence Ave, Fern Bay NSW 2295",
                CreationDate = new DateTime(2022,02,08),
                ProjectCode = PROJECT_GLEN01_CODE,
                ProjectDescription = PROJECT_GLEN01_DESC,
                Status = STATUS_NEW_CODE,
                StatusDescription = STATUS_NEW_DESC,
                StatusColor = STATUS_NEW_COLOR,
                SupervisorInitials = SUPER_INITIALS_JJF,
                SupervisorName = SUPER_NAME_JJF,
                PercentCmpl = 0
            },
            new JobTestData()
            {
                Contract = "200448",
                JobNumber = "J 200448",
                CustomerName = "Rajani",
                Address = "33 Helen St, Cardiff South NSW 2285",
                CreationDate = new DateTime(2022,01,17),
                IsMyJob = true,
                ProjectCode = PROJECT_GLEN01_CODE,
                ProjectDescription = PROJECT_GLEN01_DESC,
                Status = STATUS_INPROGRESS_CODE,
                StatusDescription = STATUS_INPROGRESS_DESC,
                StatusColor = STATUS_INPROGRESS_COLOR,
                SupervisorInitials = SUPER_INITIALS_JP1,
                SupervisorName = SUPER_NAME_JP1,
                PercentCmpl = 10,
            },
            new JobTestData()
            {
                Contract = "200602",
                JobNumber = "J 200602",
                CustomerName = "Torill, Torill",
                Address = "61 Charles St, Maitland NSW 2320",
                CreationDate = new DateTime(2022,02,07),
                Status = STATUS_INPROGRESS_CODE,
                StatusDescription = STATUS_INPROGRESS_DESC,
                StatusColor = STATUS_INPROGRESS_COLOR,
                SupervisorInitials = SUPER_INITIALS_JJF,
                SupervisorName = SUPER_NAME_JJF,
                PercentCmpl = 76
                
            },
            new JobTestData()
            {
                Contract = "200603",
                JobNumber = "J 200603",
                CustomerName = "Dixon, Dixon",
                Address = "15 Gardenia Dr, Medowie NSW 2318",
                CreationDate = new DateTime(2022,02,10),
                Status = STATUS_NEW_CODE,
                StatusDescription = STATUS_NEW_DESC,
                StatusColor = STATUS_NEW_COLOR,
                SupervisorInitials = SUPER_INITIALS_BB2,
                SupervisorName = SUPER_NAME_BB2,
                PercentCmpl = 15,
            },
            new JobTestData()
            {
                Contract = "200604",
                JobNumber = "J 200604",
                CustomerName = "Jenson & Jenson",
                Address = "420-422 Hunter Street, Newcastle, NSW, 2300, Australia",
                CreationDate = new DateTime(2021,11,03),
                ProjectCode = PROJECT_VALV01_CODE,
                ProjectDescription = PROJECT_VALV01_DESC,
                Status = STATUS_NEW_CODE,
                StatusDescription = STATUS_NEW_DESC,
                StatusColor = STATUS_NEW_COLOR,
                SupervisorInitials = SUPER_INITIALS_BB2,
                SupervisorName = SUPER_NAME_BB2,
                PercentCmpl = 60
            },
            new JobTestData()
            {
                Contract = "201804",
                JobNumber = "J 201804",
                CustomerName = "Kemper & Kemper",
                Address = "23-70 Brunker Rd, Broadmeadow NSW 2292",
                CreationDate = new DateTime(2024,04,08),
                IsMyJob = true,
                ProjectCode = PROJECT_VALV01_CODE,
                ProjectDescription = PROJECT_VALV01_DESC,
                Status = STATUS_COMPLETED_CODE,
                StatusDescription = STATUS_COMPLETED_DESC,
                StatusColor = STATUS_COMPLETED_COLOR,
                SupervisorInitials = SUPER_INITIALS_JP1,
                SupervisorName = SUPER_NAME_JP1,
                PercentCmpl = 0
            },
            new JobTestData()
            {
                Contract = "201805",
                JobNumber = "J 201805",
                CustomerName = "Tan,Tan,Tan",
                Address = "8 Sketchley Parade, New Lambton NSW 2305",
                CreationDate = new DateTime(2024,04,05),
                IsMyJob = true,
                Status = STATUS_INPROGRESS_CODE,
                StatusDescription = STATUS_INPROGRESS_DESC,
                StatusColor = STATUS_INPROGRESS_COLOR,
                SupervisorInitials = SUPER_INITIALS_JP1,
                SupervisorName = SUPER_NAME_JP1,
                PercentCmpl = 100
            },
            new JobTestData()
            {
                Contract = "201806",
                JobNumber = "J 201806",
                CustomerName = "Bother & Bother",
                Address = "15-4 Stonecrop Pl, Garden Suburb NSW 2289",
                CreationDate = new DateTime(2024,04,02),
                ProjectCode = PROJECT_GLEN01_CODE,
                ProjectDescription = PROJECT_GLEN01_DESC,
                Status = STATUS_COMPLETED_CODE,
                StatusDescription = STATUS_COMPLETED_DESC,
                StatusColor = STATUS_COMPLETED_COLOR,
                SupervisorInitials = SUPER_INITIALS_BB2,
                SupervisorName = SUPER_NAME_BB2,
                PercentCmpl = 80
                
            },
            new JobTestData()
            {
                Contract = "201807",
                JobNumber = "J 201807",
                CustomerName = "Avery & Avery",
                Address = "53 Providence Ave, Fern Bay NSW 2295",
                CreationDate = new DateTime(2024,04,08),
                ProjectCode = PROJECT_GLEN01_CODE,
                ProjectDescription = PROJECT_GLEN01_DESC,
                Status = STATUS_NEW_CODE,
                StatusDescription = STATUS_NEW_DESC,
                StatusColor = STATUS_NEW_COLOR,
                SupervisorInitials = SUPER_INITIALS_JJF,
                SupervisorName = SUPER_NAME_JJF,
                PercentCmpl = 89
            },
            new JobTestData()
            {
                Contract = "201808",
                JobNumber = "J 201808",
                CustomerName = "Rami",
                Address = "42 Helen St, Cardiff South NSW 2285",
                CreationDate = new DateTime(2024,04,01),
                IsMyJob = true,
                ProjectCode = PROJECT_GLEN01_CODE,
                ProjectDescription = PROJECT_GLEN01_DESC,
                Status = STATUS_INPROGRESS_CODE,
                StatusDescription = STATUS_INPROGRESS_DESC,
                StatusColor = STATUS_INPROGRESS_COLOR,
                SupervisorInitials = SUPER_INITIALS_JP1,
                SupervisorName = SUPER_NAME_JP1,
                PercentCmpl = 35
            },
            new JobTestData()
            {
                Contract = "300501",
                JobNumber = "J 300501",
                CustomerName = "Cantrill, Cantrill",
                Address = "86 Charles St, Maitland NSW 2320",
                CreationDate = new DateTime(2023,12,23),
                Status = STATUS_INPROGRESS_CODE,
                StatusDescription = STATUS_INPROGRESS_DESC,
                StatusColor = STATUS_INPROGRESS_COLOR,
                SupervisorInitials = SUPER_INITIALS_JJF,
                SupervisorName = SUPER_NAME_JJF,
                PercentCmpl = 55
            },
            new JobTestData()
            {
                Contract = "307602",
                JobNumber = "M 307602",
                CustomerName = "Hickson, Hickson",
                Address = "15 Gardenia Dr, Medowie NSW 2318",
                CreationDate = new DateTime(2024,03,21),
                Status = STATUS_NEW_CODE,
                StatusDescription = STATUS_NEW_DESC,
                StatusColor = STATUS_NEW_COLOR,
                SupervisorInitials = SUPER_INITIALS_BB2,
                SupervisorName = SUPER_NAME_BB2,
                PercentCmpl = 66
            },
            new JobTestData()
            {
                Contract = "410002",
                JobNumber = "J 410002",
                CustomerName = "Stanger & Evens",
                Address = "500 Hunter Street, Newcastle, NSW, 2300, Australia",
                CreationDate = new DateTime(2024,02,15),
                ProjectCode = PROJECT_VALV01_CODE,
                ProjectDescription = PROJECT_VALV01_DESC,
                Status = STATUS_NEW_CODE,
                StatusDescription = STATUS_NEW_DESC,
                StatusColor = STATUS_NEW_COLOR,
                SupervisorInitials = SUPER_INITIALS_BB2,
                SupervisorName = SUPER_NAME_BB2,
                PercentCmpl = 77
            },
            new JobTestData()
            {
                Contract = "410003",
                JobNumber = "J 410003",
                CustomerName = "Juniper & Jefferies",
                Address = "Level 1, Unit 4, 29 Really long Named Road, Super long Named Address NSW 2292",
                CreationDate = new DateTime(2024,02,16),
                IsMyJob = true,
                ProjectCode = PROJECT_VALV01_CODE,
                ProjectDescription = PROJECT_VALV01_DESC,
                Status = STATUS_COMPLETED_CODE,
                StatusDescription = STATUS_COMPLETED_DESC,
                StatusColor = STATUS_COMPLETED_COLOR,
                SupervisorInitials = SUPER_INITIALS_JP1,
                SupervisorName = SUPER_NAME_JP1,
                PercentCmpl = 40
            },
            new JobTestData()
            {
                Contract = "410004",
                JobNumber = "J 410004",
                CustomerName = "Singh,Singh,Singh",
                Address = "41 Sketchley Parade, New Lambton NSW 2305",
                CreationDate = new DateTime(2024,02,18),
                IsMyJob = true,
                Status = STATUS_INPROGRESS_CODE,
                StatusDescription = STATUS_INPROGRESS_DESC,
                StatusColor = STATUS_INPROGRESS_COLOR,
                SupervisorInitials = SUPER_INITIALS_JP1,
                SupervisorName = SUPER_NAME_JP1,
                PercentCmpl = 45
            },
            new JobTestData()
            {
                Contract = "410005",
                JobNumber = "J 410005",
                CustomerName = "Brother & Brother",
                Address = "5 Stonecrop Pl, Garden Suburb NSW 2289",
                CreationDate = new DateTime(2024,02,24),
                ProjectCode = PROJECT_GLEN01_CODE,
                ProjectDescription = PROJECT_GLEN01_DESC,
                Status = STATUS_COMPLETED_CODE,
                StatusDescription = STATUS_COMPLETED_DESC,
                StatusColor = STATUS_COMPLETED_COLOR,
                SupervisorInitials = SUPER_INITIALS_BB2,
                SupervisorName = SUPER_NAME_BB2,
                PercentCmpl = 50
            },
            new JobTestData()
            {
                Contract = "410006",
                JobNumber = "J 410006",
                CustomerName = "Smith & Evenly",
                Address = "90 Providence Ave, Fern Bay NSW 2295",
                CreationDate = new DateTime(2024,04,08),
                ProjectCode = PROJECT_GLEN01_CODE,
                ProjectDescription = PROJECT_GLEN01_DESC,
                Status = STATUS_NEW_CODE,
                StatusDescription = STATUS_NEW_DESC,
                StatusColor = STATUS_NEW_COLOR,
                SupervisorInitials = SUPER_INITIALS_JJF,
                SupervisorName = SUPER_NAME_JJF,
                PercentCmpl = 80
            },
            new JobTestData()
            {
                Contract = "410007",
                JobNumber = "J 410007",
                CustomerName = "Gent",
                Address = "78 Helen St, Cardiff South NSW 2285",
                CreationDate = new DateTime(2024,03,01),
                IsMyJob = true,
                ProjectCode = PROJECT_GLEN01_CODE,
                ProjectDescription = PROJECT_GLEN01_DESC,
                Status = STATUS_INPROGRESS_CODE,
                StatusDescription = STATUS_INPROGRESS_DESC,
                StatusColor = STATUS_INPROGRESS_COLOR,
                SupervisorInitials = SUPER_INITIALS_JP1,
                SupervisorName = SUPER_NAME_JP1,
                PercentCmpl = 85
            },
            new JobTestData()
            {
                Contract = "410008",
                JobNumber = "J 400008",
                CustomerName = "Smith, Smith",
                Address = "55 Charles St, Maitland NSW 2320",
                CreationDate = new DateTime(2024,03,01),
                Status = STATUS_INPROGRESS_CODE,
                StatusDescription = STATUS_INPROGRESS_DESC,
                StatusColor = STATUS_INPROGRESS_COLOR,
                SupervisorInitials = SUPER_INITIALS_JJF,
                SupervisorName = SUPER_NAME_JJF,
                PercentCmpl = 90
            },
            new JobTestData()
            {
                Contract = "410009",
                JobNumber = "J 400009",
                CustomerName = "Hickory, Hickory",
                Address = "16 Gardenia Dr, Medowie NSW 2318",
                CreationDate = new DateTime(2024,04,01),
                Status = STATUS_NEW_CODE,
                StatusDescription = STATUS_NEW_DESC,
                StatusColor = STATUS_NEW_COLOR,
                SupervisorInitials = SUPER_INITIALS_BB2,
                SupervisorName = SUPER_NAME_BB2,
                PercentCmpl = 100
            },
            new JobTestData()
            {
                Contract = "999998",
                JobNumber = "MM999998",
                CustomerName = "Hickory, Hickory",
                Address = "16 Gardenia Dr, Medowie NSW 2318",
                CreationDate = new DateTime(2024,04,01),
                Status = STATUS_NEW_CODE,
                StatusDescription = STATUS_NEW_DESC,
                StatusColor = STATUS_NEW_COLOR,
                SupervisorInitials = SUPER_INITIALS_BB2,
                SupervisorName = SUPER_NAME_BB2,
                PercentCmpl = 0
            },
            new JobTestData()
            {
                Contract = "999997",
                JobNumber = "WW999997",
                CustomerName = "Hickory, Hickory",
                Address = "16 Gardenia Dr, Medowie NSW 2318",
                CreationDate = new DateTime(2024,04,01),
                Status = STATUS_NEW_CODE,
                StatusDescription = STATUS_NEW_DESC,
                StatusColor = STATUS_NEW_COLOR,
                SupervisorInitials = SUPER_INITIALS_BB2,
                SupervisorName = SUPER_NAME_BB2,
                PercentCmpl = 60
            },
        };
        return data;
    }

    public static List<JobTestData> PopulateData2()
    {
        var data = PopulateData();
        foreach (var JobTestData in data)
        {
            JobTestData.JobNumber = "X_" + JobTestData.JobNumber;
        }

        return data;
    }
}