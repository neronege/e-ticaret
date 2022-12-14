using e_ticaret.model;
using System.ComponentModel.DataAnnotations.Schema;

namespace e_ticaret.Models
{
    public class Phone: Electronic
    {
        public Phone() 
        {
            Electronic_Type = ElectronicType.Phone;        

        }
        [NotMapped]
        private class Electronic : Product
        {
          public new bool Product_Type { get; set; }
        }
    }

    
}
