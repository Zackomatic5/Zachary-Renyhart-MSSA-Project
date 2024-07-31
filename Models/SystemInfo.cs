﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Zachary_Renyhart_MSSA_Project.NewFolder2
{
    [ObservableObject]
    public partial class SystemInfo
    {
        public string FirstName {  get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
        

    }
}
