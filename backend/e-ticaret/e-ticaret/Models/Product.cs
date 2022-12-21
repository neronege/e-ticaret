using e_ticaret.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace e_ticaret.model
{
    public enum ProductType
    {
        Electronic = 1,
        Outdoor,
        Toy,
        Dress
    }
    public enum ElectronicType
    {
        Fridge = 1,
        Tv,
        Phone,
        Computer
    }
    public enum OutdoorType
    {
        Bicycle = 1,
        Scooter,
        Skateboard,
        Rollerblade
    }
    public enum ToyType
    {
        Doll = 1,
        Car,
        Puzzle,
        Game
    }
    public enum DressType
    {
        Shirt,
        Pant,
        Dress,
        Suit
    }
    public class Product: EntityBase, IEntity
    {

        public string TradeMark { get; set; }   
        public string Category { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public ProductType ProductType { get; set; }
        public int SubType { get; set; }

    }
}
