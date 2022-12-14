using e_ticaret.model;
using System.ComponentModel.DataAnnotations.Schema;

namespace e_ticaret.Models
{
    public class Tv : Electronic
    {
        public Tv() 
        {
            Electronic_Type = ElectronicType.Tv;
        }

        [NotMapped]
        private class Electronic : Product
        {
           public new bool Product_Type { get; set; }
        }
    }
}
