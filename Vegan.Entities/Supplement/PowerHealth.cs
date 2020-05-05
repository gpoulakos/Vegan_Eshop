﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vegan.Entities.Supplement
{
    public class PowerHealth : Supplement
    {
        //public Dictionary<string, string> Ingredient { get; set; }  // e.g. "Melatonin"(string 1)	"1 mg"(string 2)
        [Display(Name = "Incredients")]
        public string NameOfIngredient { get; set; }
        [Display(Name = "Incredients' values")]
        public string ValueOfIngredient { get; set; }
        [Display(Name = "Instructions")]
        public string UseInstruction { get; set; }

        //https://www.powerhealth.gr/proionta/apotoxinosi/
    }
}
