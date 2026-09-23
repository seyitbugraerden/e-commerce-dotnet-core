using Microsoft.AspNetCore.Mvc;

namespace dotnet_store.Controllers;

public class AdminController : Controller
{
    public ActionResult Index()
    {
        return View();
    }
}