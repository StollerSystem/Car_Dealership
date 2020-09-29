using System;
using System.Collections.Generic;

namespace CarDealership.Models
{
  public class Car
  {
    // Public properties
    public string MakeModel { get; set; }
    public int Price { get; set; }
    public int Miles { get; set; }
    private static List<Car> _cars = new List<Car>();

    // Constructor

    public Car(string makeModel, int price, int miles)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      _cars.Add(this);
    }

    public void SetPrice(int newPrice)
    {
      Price = newPrice;
    }

    public bool WorthBuying(int maxPrice)
    {
      return (Price <= maxPrice);
    }

    // public static string MakeSound(string sound)
    // {
    //   return "Our cars sound like " + sound;
    // }
    public static List<Car> GetAll()
    {
      return _cars;
    }
  }
}

// public void PopulateList()
// {
//   Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792);
//   Car yugo = new Car("1980 Yugo Koral", 700, 56000);
//   Car ford = new Car("1988 Ford Country Squire", 1400, 239001);
//   Car amc = new Car("1976 AMC Pacer", 400, 198000);

//   Cars.Add(volkswagen);
//   Cars.Add(yugo);
//   Cars.Add(ford);
//   Cars.Add(amc);
// }