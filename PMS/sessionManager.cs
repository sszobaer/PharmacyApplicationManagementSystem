﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS
{
    public static class sessionManager
    {
        public static bool IsLoggedIn { get; set; }
        public static string Username { get; set; }
        public static string productID {  get; set; }
    }
}
