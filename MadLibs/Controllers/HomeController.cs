using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public ActionResult Home() { return View(); }

        [Route("/form")]
        public ActionResult Form() { return View(); }

        [Route("/form2")]
        public ActionResult Form2() { return View(); }

        [Route("/story")]
        public ActionResult Story(string person1, string person2, string animal, string excercise, string exclamation, string verb, string noun)
        {
        MadLibsVariable newMadLibsVariable = new MadLibsVariable();
        newMadLibsVariable.Person1 = person1;
        newMadLibsVariable.Person2 = person2;
        newMadLibsVariable.Animal = animal;
        newMadLibsVariable.Excercise = excercise;
        newMadLibsVariable.Verb = verb;
        newMadLibsVariable.Noun = noun;
        newMadLibsVariable.Exclamation = exclamation;
        return View(newMadLibsVariable);
        }

        [Route("/story2")]
        public ActionResult Story2(string person1, string person2, string animal, string excercise, string exclamation, string verb, string noun)
        {
        MadLibsVariable newMadLibsVariable = new MadLibsVariable();
        newMadLibsVariable.Person1 = person1;
        newMadLibsVariable.Person2 = person2;
        newMadLibsVariable.Animal = animal;
        newMadLibsVariable.Excercise = excercise;
        newMadLibsVariable.Verb = verb;
        newMadLibsVariable.Noun = noun;
        newMadLibsVariable.Exclamation = exclamation;
        return View(newMadLibsVariable);
        }
      
    }
}