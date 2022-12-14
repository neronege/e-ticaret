using e_ticaret.model;

namespace e_ticaret.Models
{
    public class Electronic : Product
    {
        public enum ElectronicType
        {
           Fridge,
           Tv,
           Phone,
           Computer
        }
        public Electronic() 
        {
            Product_Type = ProductType.Electronic;
        }

        public ElectronicType Electronic_Type { get; set; }
    }
}
