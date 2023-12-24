using System.Collections.ObjectModel;

using RuckIt.Models;

namespace RuckIt;

public partial class MainPage : ContentPage
{
    public ObservableCollection<Ruck> Rucks { get; set; }
    public Ruck? SelectedRuck { get; set; }
    public bool IsRefreshing { get; set; }
    public bool PaginationEnabled { get; set; }

    public MainPage()
    {
        InitializeComponent();

        Rucks = new ObservableCollection<Ruck>
        {
            new(DateTime.Now.AddMinutes(-30), DateTime.Now, 5.0, 20.0, 1000),
            new(DateTime.Now.AddDays(-1), DateTime.Now.AddDays(-1).AddMinutes(30), 3.8, 20.0, 790)
        };

        this.BindingContext = this;
    }

    private async void OnRecordRuckClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RecordRuckForm());
    }

    private void RefreshCommand(object sender, EventArgs e)
    {

    }
}
