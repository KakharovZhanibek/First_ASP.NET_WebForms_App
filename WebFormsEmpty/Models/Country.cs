﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFormsEmpty.Models
{
    [Serializable]
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Capital { get; set; }
    }
}