using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using Zachary_Renyhart_MSSA_Project.NewFolder2;

namespace Zachary_Renyhart_MSSA_Project.Models
{
    [ObservableObject]
    public partial class AllStats
    {
        [ObservableProperty]
        public int hit;
        [ObservableProperty]
        public int single;
        [ObservableProperty]
        public int doubles;
        [ObservableProperty]
        public int triple;
        [ObservableProperty]
        public int homerun;
        [ObservableProperty]
        public int walk;
        [ObservableProperty]
        public int hitbypitch;
        [ObservableProperty]
        public int strikeout;
        [ObservableProperty]
        public string name;
        [ObservableProperty]
        public double average;
        [ObservableProperty]
        public int atbats;
        [ObservableProperty]
        public int outs;
        [ObservableProperty]
        public double onbasepercentage;






    }
}
