﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vegan.Entities.FoodHerb
{
    public class SproutingSeed : FoodHerb
    {
        public string SubCategory { get; set; } = "SproutingSeed";
    }
}
