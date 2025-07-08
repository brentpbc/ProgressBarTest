namespace ProgressBarTest;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    async void ProgressBarTestPageButton_OnClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ProgressBarTestPage());
    }
}