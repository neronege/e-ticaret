using e_ticaret.model;
using System.ComponentModel.DataAnnotations.Schema;

namespace e_ticaret.Models
{
    public class Computer : Electronic
    {
        public Computer()
        {
            Electronic_Type = ElectronicType.Computer;
        }

        [NotMapped]
        public class Electronic : Product 
        {
            public new bool Product_Type { get; set; }
        }
       
    }
}
