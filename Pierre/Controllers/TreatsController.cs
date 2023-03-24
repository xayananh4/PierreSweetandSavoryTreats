using Pierre.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Pierre.Controllers
{
  public class TreatsController : Controller
  {
    private readonly TreatContext _db;

    public TreatsController(TreatContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      return View(_db.Treats.ToList());
    }
  }
}