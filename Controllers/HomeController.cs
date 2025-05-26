using Microsoft.AspNetCore.Mvc;

using TPLOCAL1.Models;

//Subject is find at the root of the project and the logo in the wwwroot/ressources folders of the solution
//--------------------------------------------------------------------------------------
//Careful, the MVC model is a so-called convention model instead of configuration,
//The controller must imperatively be name with "Controller" at the end !!!
namespace TPLOCAL1.Controllers
{
    public class HomeController : Controller
    {
        //methode "naturally" call by router
        public ActionResult Index(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                //retourn to the Index view (see routing in Program.cs)
                return View();
            else
            {
                //Call different pages, according to the id pass as parameter
                switch (id)
                {
                    case "ListeAvis":
                        var opinionList = new OpinionList().GetAvis("XlmFile\\DataAvis.xml");
                        return View("ListeAvis", opinionList); 
                    case "Form":
                        //TODO : call the Form view with data model empty
                        return View(id);
                    default:
                        //retourn to the Index view (see routing in Program.cs)
                        return View();
                }
            }
        }




        [HttpGet]
        public IActionResult Form()
        {
            return View(new AvisFormationModel());
        }

        [HttpPost]
        public IActionResult Form(AvisFormationModel formation_avis)
        {
            if (!ModelState.IsValid)
            {
                return View(formation_avis);
            }

            return View("Validation", formation_avis);
        }

    

   

    }
}

    