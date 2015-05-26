using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FlooringCalculator.Models
{
    public class Flooring
    {
        [Required]
        [Range(0.00, Double.MaxValue)]
        public virtual double Width { get; set; }

        [Required]
        [Range(0.00, Double.MaxValue)]
        public virtual double Length { get; set; }

        [Required]
        [Range(typeof(decimal), "0", "79228162514264337593543950335")]
        [Display(Name = "Cost Per Unit Of Flooring")]
        public virtual decimal CostPerUnitOfFlooring { get; set; }

        [DisplayFormat(ApplyFormatInEditMode=true, DataFormatString="{0:c}")]
        public virtual decimal TotalCost { get; set; }

        public Flooring()
        {
            Width = 0;
            Length = 0;
            CostPerUnitOfFlooring = 0;
            TotalCost = 0;
        }
    }
}