using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Runtime.ExceptionServices;
using e_ticaret.model;

namespace e_ticaret.Models
{
    
    public class Fridge : Electronic
    {
       public Fridge()
        {
            Electronic_Type = ElectronicType.Fridge;
        }

        [NotMapped]
        class Electronic : Product 
        {
            public new bool Product_Type { get; set; }
        }
    }
}
