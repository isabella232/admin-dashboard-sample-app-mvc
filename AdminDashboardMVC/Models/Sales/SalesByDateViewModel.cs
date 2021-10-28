﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminDashboardMVC.Models.Sales
{
    public class SalesByDateViewModel
    {
        public string Region { get; set; }
        public DateTime Date { get; set; }
        public double Sum { get; set; }
    }
}