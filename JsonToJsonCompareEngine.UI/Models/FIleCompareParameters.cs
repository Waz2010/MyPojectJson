using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using JsonToJsonCompareEngine.UI.Data.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace JsonToJsonCompareEngine.UI.Models
{
    public class ViewModel
    {
        public ViewModel()
        {
            Exclusions = new List<string>();
        }
        //public List<StateViewModel> States { get; set; }
        public List<string> Exclusions { get; set; }
        public List<State> States { get; set; }
        public SelectList FilteredCounty { get; set; }
        public string SelectedPreviousFile { get; set; }
        public string SelectedCurrentFile { get; set; }
    }
    public class StateViewModel
    {
        public int Id { get; set; }
        public string StateName { get; set; }
    }

    public class CountyViewModel
    {
        public int Id { get; set; }
        public string CountyName { get; set; }
        public int StateId { get; set; }
        public List<string> Files { get; set; }
    }
}
