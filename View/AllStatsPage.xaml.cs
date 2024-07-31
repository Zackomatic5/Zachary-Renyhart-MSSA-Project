//using Android.Provider;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Maui.Platform;

//using LocalAuthentication;
using Microsoft.VisualBasic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

//using Windows.Security.EnterpriseData;
using Zachary_Renyhart_MSSA_Project.Models;
using Zachary_Renyhart_MSSA_Project.NewFolder;
using Zachary_Renyhart_MSSA_Project.ViewModel;

namespace Zachary_Renyhart_MSSA_Project.View;

public partial class AllStatsPage : ContentPage
{

   private AllStatsViewModel vm = new AllStatsViewModel();
   
    public AllStatsPage()
	{
		InitializeComponent();
		BindingContext = vm;
        

    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
              

    }

    


    private void AddSingleClicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        var stats = button?.CommandParameter as AllStats;
        if (stats != null)
        {
            stats.Single++;
            stats.Hit++;
            stats.Atbats++;
            if (stats.Hit >= 0)
            {
                double hitCount = stats.Hit;
                
                if (stats.Atbats > 0)
                {
                    double hittingStats = stats.Hit + (stats.Walk + stats.Hitbypitch);
                    stats.Onbasepercentage = (hittingStats / stats.Atbats);

                    double walkHit = (stats.Walk + stats.Hitbypitch);
                    double atbatCount = (stats.Atbats - walkHit);
                    stats.Average = (hitCount / atbatCount);

                    
                }
            }

        }
        OnPropertyChanged(nameof(stats.Onbasepercentage));
        OnPropertyChanged(nameof(stats.Average));
        OnPropertyChanged(nameof(stats.Single));
        OnPropertyChanged(nameof(stats.Hit));
        OnPropertyChanged(nameof(stats.Atbats));
        
    }

    private void DeleteSingleClicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        var stats = button?.CommandParameter as AllStats;
        if (stats.Single >= 1)
        {
            stats.Single--;
            stats.Hit--;
            stats.Atbats--;
            if (stats.Hit > 0)
            {
                double hitCount = stats.Hit;
                if (stats.Atbats > 0)
                {
                    double hittingStats = stats.Hit + (stats.Walk + stats.Hitbypitch);
                    stats.Onbasepercentage = (hittingStats / stats.Atbats);

                    double walkHit = (stats.Walk + stats.Hitbypitch);
                    double atbatCount = (stats.Atbats - walkHit);
                    stats.Average = (hitCount / atbatCount);
                }
            }
        }
        OnPropertyChanged(nameof(stats.Onbasepercentage));
        OnPropertyChanged(nameof(stats.Average));
        OnPropertyChanged(nameof(stats.Single));
        OnPropertyChanged(nameof(stats.Hit));
        OnPropertyChanged(nameof(stats.Atbats));
    }

    private void AddDoubleClicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        var stats = button?.CommandParameter as AllStats;
        if (stats != null)
        {
            stats.Doubles++;
            stats.Hit++;
            stats.Atbats++;
            if (stats.Hit >= 0)
            {
                double hitCount = stats.Hit;
                if (stats.Atbats > 0)
                {
                    double hittingStats = stats.Hit + (stats.Walk + stats.Hitbypitch);
                    stats.Onbasepercentage = (hittingStats / stats.Atbats);

                    double walkHit = (stats.Walk + stats.Hitbypitch);
                    double atbatCount = (stats.Atbats - walkHit);
                    stats.Average = (hitCount / atbatCount);
                }
            }
        }
        OnPropertyChanged(nameof(stats.Onbasepercentage));
        OnPropertyChanged(nameof(stats.Average));
        OnPropertyChanged(nameof(stats.Doubles));
        OnPropertyChanged(nameof(stats.Hit));
        OnPropertyChanged(nameof(stats.Atbats));
    }

    private void DeleteDoubleClicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        var stats = button?.CommandParameter as AllStats;
        if (stats.Doubles >= 1)
        {
            stats.Doubles--;
            stats.Hit--;
            stats.Atbats--;
            if (stats.Hit >= 0)
            {
                double hitCount = stats.Hit;
                if (stats.Atbats > 0)
                {
                    double hittingStats = stats.Hit + (stats.Walk + stats.Hitbypitch);
                    stats.Onbasepercentage = (hittingStats / stats.Atbats);

                    double walkHit = (stats.Walk + stats.Hitbypitch);
                    double atbatCount = (stats.Atbats - walkHit);
                    stats.Average = (hitCount / atbatCount);
                }
            }
        }
        OnPropertyChanged(nameof(stats.Onbasepercentage));
        OnPropertyChanged(nameof(stats.Average));
        OnPropertyChanged(nameof(stats.Doubles));
        OnPropertyChanged(nameof(stats.Hit));
        OnPropertyChanged(nameof(stats.Atbats));
    }

    private void AddTripleClicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        var stats = button?.CommandParameter as AllStats;
        if (stats != null)
        {
            stats.Triple++;
            stats.Hit++;
            stats.Atbats++;
            if (stats.Hit >= 0)
            {
                double hitCount = stats.Hit;
                if (stats.Atbats > 0)
                {
                    double hittingStats = stats.Hit + (stats.Walk + stats.Hitbypitch);
                    stats.Onbasepercentage = (hittingStats / stats.Atbats);

                    double walkHit = (stats.Walk + stats.Hitbypitch);
                    double atbatCount = (stats.Atbats - walkHit);
                    stats.Average = (hitCount / atbatCount);
                }
            }
        }
        OnPropertyChanged(nameof(stats.Onbasepercentage));
        OnPropertyChanged(nameof(stats.Average));
        OnPropertyChanged(nameof(stats.Triple));
        OnPropertyChanged(nameof(stats.Hit));
        OnPropertyChanged(nameof(stats.Atbats));
    }

    private void DeleteTripleClicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        var stats = button?.CommandParameter as AllStats;
        if (stats.Triple >= 1)
        {
            stats.Triple--;
            stats.Hit--;
            stats.Atbats--;
            if (stats.Hit >= 0)
            {
                double hitCount = stats.Hit;
                if (stats.Atbats > 0)
                {
                    double hittingStats = stats.Hit + (stats.Walk + stats.Hitbypitch);
                    stats.Onbasepercentage = (hittingStats / stats.Atbats);

                    double walkHit = (stats.Walk + stats.Hitbypitch);
                    double atbatCount = (stats.Atbats - walkHit);
                    stats.Average = (hitCount / atbatCount);
                }
            }
        }
        OnPropertyChanged(nameof(stats.Onbasepercentage));
        OnPropertyChanged(nameof(stats.Average));
        OnPropertyChanged(nameof(stats.Triple));
        OnPropertyChanged(nameof(stats.Hit));
        OnPropertyChanged(nameof(stats.Atbats));
    }

    private void AddHomerunClicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        var stats = button?.CommandParameter as AllStats;
        if (stats != null)
        {
            stats.Homerun++;
            stats.Hit++;
            stats.Atbats++;
            if (stats.Hit >= 0)
            {
                double hitCount = stats.Hit;
                if (stats.Atbats > 0)
                {
                    double hittingStats = stats.Hit + (stats.Walk + stats.Hitbypitch);
                    stats.Onbasepercentage = (hittingStats / stats.Atbats);

                    double walkHit = (stats.Walk + stats.Hitbypitch);
                    double atbatCount = (stats.Atbats - walkHit);
                    stats.Average = (hitCount / atbatCount);
                }
            }
        }
        OnPropertyChanged(nameof(stats.Onbasepercentage));
        OnPropertyChanged(nameof(stats.Average));
        OnPropertyChanged(nameof(stats.Homerun));
        OnPropertyChanged(nameof(stats.Hit));
        OnPropertyChanged(nameof(stats.Atbats));
    }

    private void DeleteHomerunClicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        var stats = button?.CommandParameter as AllStats;
        if (stats.Homerun >= 1)
        {
            stats.Homerun--;
            stats.Hit--;
            stats.Atbats--;
            if (stats.Hit >= 0)
            {
                double hitCount = stats.Hit;
                if (stats.Atbats > 0)
                {
                    double hittingStats = stats.Hit + (stats.Walk + stats.Hitbypitch);
                    stats.Onbasepercentage = (hittingStats / stats.Atbats);

                    double walkHit = (stats.Walk + stats.Hitbypitch);
                    double atbatCount = (stats.Atbats - walkHit);
                    stats.Average = (hitCount / atbatCount);
                }
            }
        }
        OnPropertyChanged(nameof(stats.Onbasepercentage));
        OnPropertyChanged(nameof(stats.Average));
        OnPropertyChanged(nameof(stats.Homerun));
        OnPropertyChanged(nameof(stats.Hit));
        OnPropertyChanged(nameof(stats.Atbats));
    }

    private void AddWalkClicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        var stats = button?.CommandParameter as AllStats;
        if (stats != null)
        {
            stats.Walk++;
            stats.Atbats++;
            double hitwithWalk = stats.Hit + (stats.Hitbypitch + stats.Walk);
            stats.Onbasepercentage = hitwithWalk / stats.Atbats;
        }
        OnPropertyChanged(nameof(stats.Onbasepercentage));
        OnPropertyChanged(nameof(stats.Walk));
        OnPropertyChanged(nameof(stats.Hitbypitch));
        OnPropertyChanged(nameof(stats.Atbats));
    }

    private void DeleteWalkClicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        var stats = button?.CommandParameter as AllStats;
        if (stats.Walk >= 1)
        {
            stats.Walk--;
            stats.Atbats--;
            if (stats.Hit >= 0)
            {
                double hitwithWalk = stats.Hit + (stats.Hitbypitch + stats.Walk);
                stats.Onbasepercentage = hitwithWalk / stats.Atbats;
            }
        }
        OnPropertyChanged(nameof(stats.Onbasepercentage));
        OnPropertyChanged(nameof(stats.Hitbypitch));
        OnPropertyChanged(nameof(stats.Walk));
        OnPropertyChanged(nameof(stats.Atbats));
    }

    private void AddHBPClicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        var stats = button?.CommandParameter as AllStats;
        if (stats != null)
        {
            stats.Hitbypitch++;
            stats.Atbats++;
            double hitwithWalk = stats.Hit + (stats.Hitbypitch + stats.Walk);
            stats.Onbasepercentage = hitwithWalk / stats.Atbats;
        }
        OnPropertyChanged(nameof(stats.Walk));
        OnPropertyChanged(nameof(stats.Onbasepercentage));
        OnPropertyChanged(nameof(stats.Hitbypitch));
        OnPropertyChanged(nameof(stats.Atbats));
    }

    private void DeleteHBPClicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        var stats = button?.CommandParameter as AllStats;
        if (stats.Hitbypitch >= 1)
        {
            stats.Hitbypitch--;
            stats.Atbats--;
            double hitwithWalk = stats.Hit + (stats.Hitbypitch + stats.Walk);
            stats.Onbasepercentage = hitwithWalk / stats.Atbats;
        }
        OnPropertyChanged(nameof(stats.Onbasepercentage));
        OnPropertyChanged(nameof(stats.Hitbypitch));
        OnPropertyChanged(nameof(stats.Walk));
        OnPropertyChanged(nameof(stats.Atbats));
    }

    private void AddStrikeoutClicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        var stats = button?.CommandParameter as AllStats;
        if (stats != null)
        {
            stats.Strikeout++;
            stats.Atbats++;
            if (stats.Hit >= 0)
            {
                double hitCount = stats.Hit;
                if (stats.Atbats > 0)
                {
                    double hittingStats = stats.Hit + (stats.Walk + stats.Hitbypitch);
                    stats.Onbasepercentage = (hittingStats / stats.Atbats);

                    double walkHit = (stats.Walk + stats.Hitbypitch);
                    double atbatCount = (stats.Atbats - walkHit);
                    stats.Average = (hitCount / atbatCount);
                }
            }

        }
        OnPropertyChanged(nameof(stats.Onbasepercentage));
        OnPropertyChanged(nameof(stats.Average));
        OnPropertyChanged(nameof(stats.Strikeout));
        OnPropertyChanged(nameof(stats.Hit));
        OnPropertyChanged(nameof(stats.Atbats));
        
    }

    private void DeleteStrikeoutClicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        var stats = button?.CommandParameter as AllStats;
        if (stats.Strikeout >= 1)
        {
            stats.Strikeout--;
            stats.Atbats--;
            if (stats.Hit >= 0)
            {
                double hitCount = stats.Hit;
                if (stats.Atbats > 0)
                {
                    double hittingStats = stats.Hit + (stats.Walk + stats.Hitbypitch);
                    stats.Onbasepercentage = (hittingStats / stats.Atbats);

                    double walkHit = (stats.Walk + stats.Hitbypitch);
                    double atbatCount = (stats.Atbats - walkHit);
                    stats.Average = (hitCount / atbatCount);
                }
            }
        }
        OnPropertyChanged(nameof(stats.Onbasepercentage));
        OnPropertyChanged(nameof(stats.Average));
        OnPropertyChanged(nameof(stats.Strikeout));
        OnPropertyChanged(nameof(stats.Hit));
        OnPropertyChanged(nameof(stats.Atbats));
    }



    private void AddOutClicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        var stats = button?.CommandParameter as AllStats;
        if (stats != null)
        {
            stats.Outs++;
            stats.Atbats++;
            if (stats.Hit >= 0)
            {
                double hitCount = stats.Hit;
                if (stats.Atbats > 0)
                {
                    double hittingStats = stats.Hit + (stats.Walk + stats.Hitbypitch);
                    stats.Onbasepercentage = (hittingStats / stats.Atbats);

                    double walkHit = (stats.Walk + stats.Hitbypitch);
                    double atbatCount = (stats.Atbats - walkHit);
                    stats.Average = (hitCount / atbatCount);
                }
            }
        }
        OnPropertyChanged(nameof(stats.Onbasepercentage));
        OnPropertyChanged(nameof(stats.Average));
        OnPropertyChanged(nameof(stats.Outs));
        OnPropertyChanged(nameof(stats.Hit));
        OnPropertyChanged(nameof(stats.Atbats));

    }

    private void DeleteOutClicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        var stats = button?.CommandParameter as AllStats;
        if (stats.Outs >= 1)
        {
            stats.Outs--;
            stats.Atbats--;
            if (stats.Hit > 0)
            {
                double hitCount = stats.Hit;
                if (stats.Atbats > 0)
                {
                    double hittingStats = stats.Hit + (stats.Walk + stats.Hitbypitch);
                    stats.Onbasepercentage = (hittingStats / stats.Atbats);

                    double walkHit = (stats.Walk + stats.Hitbypitch);
                    double atbatCount = (stats.Atbats - walkHit);
                    stats.Average = (hitCount / atbatCount);
                   
                }
            }
        }
        OnPropertyChanged(nameof(stats.Onbasepercentage));
        OnPropertyChanged(nameof(stats.Average));
        OnPropertyChanged(nameof(stats.Outs));
        OnPropertyChanged(nameof(stats.Hit));
        OnPropertyChanged(nameof(stats.Atbats));
    }



    async void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        string currentPlayer = (e.CurrentSelection.FirstOrDefault() as AllStats)?.Name;

        await Navigation.PushAsync(new PlayerDetailPage());
    }


 


    


}