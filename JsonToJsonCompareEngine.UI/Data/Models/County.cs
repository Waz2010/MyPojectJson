using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JsonToJsonCompareEngine.UI.Data.Models
{
    public class County
    {
        [Key]
        public int Id { get; set; }
        public int StateId { get; set; }
        public string CountyName { get; set; }
        public string PreviousFileName { get; set; }
        public string CurrentFileName { get; set; }
        public virtual State State { get; set; }
    }
}
