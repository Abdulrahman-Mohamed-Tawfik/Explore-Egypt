using Explore_Egypt.DataAccess.Data;
using Explore_Egypt.Models;
using Explore_Egypt.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Explore_Egypt.Controllers
{
    [Authorize(Roles = Constants.Admin)]
    public class LandmarkController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public LandmarkController(ApplicationDbContext db, IWebHostEnvironment webHostEnvironment)
        {
            _db = db;
            _webHostEnvironment = webHostEnvironment;
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
        public IActionResult Create(Landmark obj, List<IFormFile> files)
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

				string wwwRootPath = _webHostEnvironment.WebRootPath;
                if (files != null)
                {

                    foreach (IFormFile file in files)
                    {
                        string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                        string landmarkPath = @"landmarkImages\" + obj.Name.Replace(' ', '-');
                        string finalPath = Path.Combine(wwwRootPath, landmarkPath);

                        if (!Directory.Exists(finalPath))
                            Directory.CreateDirectory(finalPath);

                        using (var fileStream = new FileStream(Path.Combine(finalPath, fileName), FileMode.Create))
                        {
                            file.CopyTo(fileStream);
                        }

                        int landmarkId = _db.Landmarks.OrderBy(x => x.Id).Last().Id;
                        LandmarkImage landmarkImage = new()
                        {
                            Url = @"\" + landmarkPath + @"\" + fileName,
                            LandmarkId = landmarkId,
                        };
                        _db.LandmarkImages.Add(landmarkImage);
                        
                    }
                }

                
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
			Landmark? LandmarksFromDb = _db.Landmarks.Include(x => x.Images)
                    .FirstOrDefault(x => x.Id == id);
			//Landmarks? LandmarksFromDb1 = _db.Categories.FirstOrDefault(u=>u.Id==id);
			//Landmarks? LandmarksFromDb2 = _db.Categories.Where(u=>u.Id==id).FirstOrDefault();

			if (LandmarksFromDb == null)
			{
				return NotFound();
			}
			return View(LandmarksFromDb);
		}
		[HttpPost]
		public IActionResult Edit(Landmark obj, List<IFormFile> files)
		{
			if (ModelState.IsValid)
			{
				_db.Landmarks.Update(obj);
				_db.SaveChanges();

                string wwwRootPath = _webHostEnvironment.WebRootPath;
                if (files != null)
                {

                    foreach (IFormFile file in files)
                    {
                        string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                        string landmarkPath = @"landmarkImages\" + obj.Name.Replace(' ', '-');
                        string finalPath = Path.Combine(wwwRootPath, landmarkPath);

                        if (!Directory.Exists(finalPath))
                            Directory.CreateDirectory(finalPath);

                        using (var fileStream = new FileStream(Path.Combine(finalPath, fileName), FileMode.Create))
                        {
                            file.CopyTo(fileStream);
                        }

                        int landmarkId = _db.Landmarks.OrderBy(x => x.Id).Last().Id;
                        LandmarkImage landmarkImage = new()
                        {
                            Url = @"\" + landmarkPath + @"\" + fileName,
                            LandmarkId = landmarkId,
                        };
                        _db.LandmarkImages.Add(landmarkImage);

                    }
                }

                _db.SaveChanges();
                TempData["success"] = "Landmarks updated successfully";
				return RedirectToAction("Index");
			}
			return View();


            if (LandmarksFromDb == null)
            {
                return NotFound();
            }
            return View(LandmarksFromDb);
        }
        [HttpPost]
        public IActionResult Edit(Landmark obj, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                /*
                if (file != null && file.Length > 0)
                {
                    // Save the file to a location on the server
                    var filePath = Path.Combine(_hostingEnvironment.WebRootPath, "uploads", file.FileName);
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }

                    // Generate URL for the uploaded file
                    var url = Url.Content("~/uploads/" + file.FileName);

                    // Update the Landmark object with the URL
                    obj.Images = url;
                }
                */
                _db.Landmarks.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Landmarks updated successfully";
                return RedirectToAction("Index");
            }
            return View();

        }



        public IActionResult DeleteImage(int imageId)
        {
            var imageToBeDeleted = _db.LandmarkImages.FirstOrDefault(u => u.Id == imageId);
            int landmarkId = imageToBeDeleted.LandmarkId;
            if (imageToBeDeleted != null)
            {
                if (!string.IsNullOrEmpty(imageToBeDeleted.Url))
                {
                    var oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath,
                                   imageToBeDeleted.Url.TrimStart('\\'));

                    if (System.IO.File.Exists(oldImagePath))
                    {
                        System.IO.File.Delete(oldImagePath);
                    }
                }

                _db.LandmarkImages.Remove(imageToBeDeleted);
                _db.SaveChanges();

                TempData["success"] = "Deleted successfully";
            }

            return RedirectToAction("Edit", new { id = landmarkId });

        }



    }
}
