using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CarDealership.Models;

namespace CarDealership.Controllers
{
  public class CarsController : Controller
  {

    [HttpGet("/cars")]
    public ActionResult Index()
    {
      List<Car> allCars = Car.GetAll();
      return View(allCars);
    }

    [HttpGet("/cars/new")]
    public ActionResult CreateCar()
    {
      return View();
    }

    [HttpPost("/cars")]
    public ActionResult Create(string makeModel, int price, int miles)
    {
      Car newCar = new Car(makeModel, price, miles);
      return RedirectToAction("Index");
    }
  }
}
// using Microsoft.AspNetCore.Mvc;

// namespace CarDealership.Controllers
// {
//   public class DealershipController : Controller
//   {
//     [HttpGet("/dealership")]
//     public ActionResult Index()
//     {
//       List<Category> allCategories = Category.GetAll();
//       return View(allCategories);
//     }    

//   }
// }