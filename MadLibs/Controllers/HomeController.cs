using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Form() { return View(); }

    [Route("/response")]
    public ActionResult Response(string adjective01, string adjective02, string adjective03, string noun01, string noun02, string noun03, string noun04, string verb01, string verb02, string timeOfDay)
    {
      MadLib newMadLib = new MadLib();
      newMadLib.Adjective01 = adjective01;
      newMadLib.Adjective02 = adjective02;
      newMadLib.Adjective03 = adjective03;
      newMadLib.Noun01 = noun01;
      newMadLib.Noun02 = noun02;
      newMadLib.Noun03 = noun03;
      newMadLib.Noun04 = noun04;
      newMadLib.Verb01 = verb01;
      newMadLib.Verb02 = verb02;
      newMadLib.TimeOfDay = timeOfDay;
      return View(newMadLib);
    }
  }
}