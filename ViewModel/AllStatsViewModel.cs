using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Zachary_Renyhart_MSSA_Project.Models;
//using Zachary_Renyhart_MSSA_Project.Models;
using Zachary_Renyhart_MSSA_Project.NewFolder2;
using Zachary_Renyhart_MSSA_Project.View;

namespace Zachary_Renyhart_MSSA_Project.ViewModel
{
    [ObservableObject]
    public partial class AllStatsViewModel
    {
        
        public AllStatsViewModel()
        {

            PlayerCollection.Add(new AllStats
            {   //I can add average to the Models class after everything is set up and do AVG = Hit / At bats
                Hit = 0,
                Single = 0,
                Doubles = 0,
                Triple = 0,
                Homerun = 0,
                Walk = 0,
                Hitbypitch = 0,
                Strikeout = 0,
                Name = "Zachary Renyhart",
                Average = 1,
                Atbats = 0,
                Outs = 0,
                Onbasepercentage = 1

            });

            PlayerCollection.Add(new AllStats
            {   //I can add average to the Models class after everything is set up and do AVG = Hit / At bats
                Hit = 0,
                Single = 0,
                Doubles = 0,
                Triple = 0,
                Homerun = 0,
                Walk = 0,
                Hitbypitch = 0,
                Strikeout = 0,
                Name = "Jonathan Renyhart",
                Average = 1,
                Atbats = 0,
                Outs = 0,
                Onbasepercentage = 1
                
            });

            PlayerCollection.Add(new AllStats
            {   //I can add average to the Models class after everything is set up and do AVG = Hit / At bats
                Hit = 0,
                Single = 0,
                Doubles = 0,
                Triple = 0,
                Homerun = 0,
                Walk = 0,
                Hitbypitch = 0,
                Strikeout = 0,
                Name = "Jongdo Yoo",
                Average = 1,
                Atbats = 0,
                Outs = 0,
                Onbasepercentage = 1
                



            });

        }


        public ObservableCollection<AllStats> PlayerCollection { get; set; } = new();

        [ObservableProperty]
        private string hit;


        [RelayCommand]
        private void ToggleHitAdd()
        {
            int counter = 0;
            counter++;
            Hit = counter.ToString();
        }



       

    }

    
}

//// AllStatsCollection.Add(new AllStats 
//{   //I can add average to the Models class after everything is set up and do AVG = Hit / At bats
//    Hit = 0,
//                Single = 0,
//                Doubles = 0,
//                Triple = 0,
//                Homerun = 0,
//                Walk = 0,
//                HitByPitch = 0,
//                Strikeout = 0,
//                Name = "Zachary Renyhart"

//            });
