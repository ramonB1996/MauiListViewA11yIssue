namespace MauiListViewA11yIssue;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        List.ItemsSource = new List<object>() { new { }, new { }, new { } };
    }
}