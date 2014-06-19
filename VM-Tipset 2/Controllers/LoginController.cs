using System.Web.Mvc;
using DomainClasses;
using ServiceContracts.UoW;

namespace VM_Tipset_2.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public LoginController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        // GET: /Login/
        public ActionResult Index()
        {
            return View();
        }

        // GET: /Login/
        [HttpPost]
        public ActionResult SignIn(User user)
        {
            if (ModelState.IsValid)
            {
                var userFromDb = _unitOfWork.Users.GetById(user.UserId);

                if ((userFromDb.Username == user.Username) && (userFromDb.Password == user.Password))
                {
                    return RedirectToAction("Index", "Account");    
                }

                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Index", "Home");
        }

    }
}
