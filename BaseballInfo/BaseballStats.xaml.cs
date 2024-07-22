using Zachary_Renyhart_MSSA_Project.BaseballInfo;

namespace Zachary_Renyhart_MSSA_Project.NewFolder;

public partial class BaseballStats : ContentPage
{
	public BaseballStats()
	{
		InitializeComponent();
	}

    private async void HitClicked(object sender, EventArgs e)
	{
      await Navigation.PushAsync(new HitPage());
    }
    
    private async void SingleClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SinglePage());
    }
    private async void DoubleClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DoublePage());
    }
    private async void TripleClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TriplePage());
    }
    private async void HomerunClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HomerunPage());
    }
    private async void WalkClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new WalkPage());
    }
    private async void HitByPitchClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HitByPitchPage());
    }
    private async void StrikeoutClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new StrikeoutPage());
    }
    private async void AllStatsClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AllStatsPage());
    }

}