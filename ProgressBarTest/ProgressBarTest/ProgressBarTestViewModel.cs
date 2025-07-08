namespace ProgressBarTest;

public class ProgressBarTestViewModel : BaseModel
{
    List<JobTestData> testData = JobTestData.PopulateData();
    public List<JobTestData> TestData
    {
        get { return testData; }
        set { SetProperty(ref testData, value); }
    }
    
    double headerPct = 20;
    public double HeaderPct
    {
        get { return headerPct; }
        set { SetProperty(ref headerPct, value); }
    }
    
    bool AlternateCO = false;
    public ProgressBarTestViewModel()
    {
        //Update();
    }

    void PopulateData(bool alt = false)
    {
        var allData = JobTestData.PopulateData();
        var newData = new List<JobTestData>();
        if (alt)
        {
            newData.Add(allData[1]);    
        }
        else
        {
            newData.Add(allData[0]);
        }

        TestData = newData;
    }


    public void ReloadList()
    {
        TestData = JobTestData.PopulateData();
    }
    
    public void Update()
    {
        PopulateData(AlternateCO);
        AlternateCO = !AlternateCO;
    }
    
    double pct1 = 35;
    double pct2 = 90;
    bool altPct = false;
    public void UpdatePct()
    {
        foreach (var job in TestData)
        {
            if (altPct)
            {
                job.PercentCmpl = pct1;
            }
            else
            {
                job.PercentCmpl = pct2;
            }
            altPct = !altPct;    
        }
        
    }
}