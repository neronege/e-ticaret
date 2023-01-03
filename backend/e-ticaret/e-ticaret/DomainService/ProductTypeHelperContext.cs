using e_ticaret.Models;
using System.Collections.Generic;

namespace e_ticaret.DomainService
{
    public static class ProductTypeHelperContext
    {
        /*
         
              if (productType == ProductType.Electronic)
            {
                list.Add(((int)ElectronicType.Phone, ElectronicType.Phone.ToString()));
                list.Add(((int)ElectronicType.Computer, ElectronicType.Computer.ToString()));
                list.Add(((int)ElectronicType.Fridge, ElectronicType.Fridge.ToString()));
                list.Add(((int)ElectronicType.Tv, ElectronicType.Tv.ToString()));

            }
            if (productType == ProductType.Dress)
            {
                list.Add(((int)DressType.Dress, DressType.Dress.ToString()));
                list.Add(((int)DressType.Pant, DressType.Pant.ToString()));
                list.Add(((int)DressType.Suit, DressType.Suit.ToString()));
                list.Add(((int)DressType.Shirt, DressType.Shirt.ToString()));
            }
            if (productType == ProductType.Outdoor)
            {
                list.Add(((int)OutdoorType.Rollerblade, OutdoorType.Rollerblade.ToString()));
                list.Add(((int)OutdoorType.Skateboard, OutdoorType.Skateboard.ToString()));
                list.Add(((int)OutdoorType.Bicycle, OutdoorType.Bicycle.ToString()));
                list.Add(((int)OutdoorType.Scooter, OutdoorType.Scooter.ToString()));
            }
            if (productType == ProductType.Toy)
            {
                list.Add(((int)ToyType.Game, ToyType.Game.ToString()));
                list.Add(((int)ToyType.Puzzle, ToyType.Puzzle.ToString()));
                list.Add(((int)ToyType.Doll, ToyType.Doll.ToString()));
                list.Add(((int)ToyType.Car, ToyType.Car.ToString()));
            }
         */
        private static List<ProductType> _productTypes = new();
        public static void seed()
        {
            if (_productTypes.Count > 0)
                return;

            ProductType t = new ProductType(1, "Electronics");
            t.SubTypes.Add(new ProductType(101, "Tv"));
            t.SubTypes.Add(new ProductType(102, "Computer"));
            _productTypes.Add(t);

            t = new ProductType(2, "Dress");
            t.SubTypes.Add(new(201, "Dress"));
            t.SubTypes.Add(new(202, "Pant"));
            _productTypes.Add(t);

        }
        public static List<ProductType> GetArray()
        {
            if (_productTypes.Count == 0)
            {
                seed();
            }
            return _productTypes;
        }

 
    }
}
