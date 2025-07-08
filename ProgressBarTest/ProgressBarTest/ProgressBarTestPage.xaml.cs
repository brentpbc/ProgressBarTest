using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressBarTest;

public partial class ProgressBarTestPage : ContentPage
{
    public ProgressBarTestViewModel ViewModel { get; set; }
    public ProgressBarTestPage()
    {
        InitializeComponent();
        BindingContext = ViewModel = new ProgressBarTestViewModel();
    }

    void UpdatePctButton_OnClicked(object sender, EventArgs e)
    {
        ViewModel.UpdatePct();
    }

    void ReloadButton_OnClicked(object sender, EventArgs e)
    { 
        ViewModel.ReloadList();
    }
}