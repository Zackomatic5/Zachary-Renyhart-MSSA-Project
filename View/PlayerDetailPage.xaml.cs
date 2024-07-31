using Zachary_Renyhart_MSSA_Project.ViewModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Zachary_Renyhart_MSSA_Project.View;

public partial class PlayerDetailPage : ContentPage
{

	private PlayerDetailViewModel vm = new PlayerDetailViewModel();
	public PlayerDetailPage()
	{
		InitializeComponent();
		BindingContext = vm;
		
        

        

}



}