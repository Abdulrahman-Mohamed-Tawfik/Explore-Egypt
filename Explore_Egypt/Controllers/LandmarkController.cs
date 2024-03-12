using Explore_Egypt.DataAccess.Data;
using Explore_Egypt.Models;
using Explore_Egypt.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace Explore_Egypt.Controllers
{
    //[Authorize(Roles = Constants.Admin)]
    public class LandmarkController : Controller
    {
        private readonly ApplicationDbContext _db;
        public LandmarkController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Landmark> objLandmarkList = _db.Landmarks.ToList();
            return View(objLandmarkList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Landmark obj)
        {
            //if (obj.Name == obj.Id.ToString())
            //{
            //    ModelState.AddModelError("name", "The DisplayOrder cannot exactly match the Name.");
            //}
            //if (obj.Name == null)
            //{
            //    ModelState.AddModelError("Name", "Name cannot be empty.");
            //}
            //if (obj.Description == null)
            //{
            //    ModelState.AddModelError("Description", "Description cannot be empty.");
            //}
            if (ModelState.IsValid)
            {
                _db.Landmarks.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Landmarks created successfully";
                return RedirectToAction("Index");
            }
            return View();
        }


		public IActionResult Edit(int? id)
		{
			if (id == null || id == 0)
			{
				return NotFound();
			}
			//Landmark? LandmarksFromDb = _db.Landmarks.Get(u => u.Id == id);
			Landmark? LandmarksFromDb = _db.Landmarks.Find(id);
			//Landmarks? LandmarksFromDb1 = _db.Categories.FirstOrDefault(u=>u.Id==id);
			//Landmarks? LandmarksFromDb2 = _db.Categories.Where(u=>u.Id==id).FirstOrDefault();

			if (LandmarksFromDb == null)
			{
				return NotFound();
			}
			return View(LandmarksFromDb);
		}
		[HttpPost]
		public IActionResult Edit(Landmark obj)
		{
			if (ModelState.IsValid)
			{
				_db.Landmarks.Update(obj);
				_db.SaveChanges();
				TempData["success"] = "Landmarks updated successfully";
				return RedirectToAction("Index");
			}
			return View();

		}

		
	}
}
