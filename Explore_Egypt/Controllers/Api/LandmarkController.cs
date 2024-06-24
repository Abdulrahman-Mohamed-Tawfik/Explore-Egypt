using Explore_Egypt.DataAccess.Data;
using Explore_Egypt.DataAccess.Dto;
using Explore_Egypt.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace Explore_Egypt.Controllers.Api
{
	[Route("api/[controller]")]
	[ApiController]
	public class LandmarkController : ControllerBase
	{
		private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public LandmarkController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        [HttpGet]
		[ProducesResponseType(StatusCodes.Status200OK)]
		public ActionResult<IEnumerable<Landmark>> GetLandmarks()
		{
			List<Landmark> objLandmarkList = _context.Landmarks
				.Include(x => x.Images)
				.ToList();
			return Ok(new { data = objLandmarkList });
		}

		//https://localhost:44316/api/landmark/name/{landmarkName}
		//e.g. https://localhost:44316/api/landmark/name/cairotower
		[HttpGet("name/{landmarkName}", Name = "GetLandmarkByName")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<LandmarkDto> GetLandmark([FromRoute] string landmarkName)
        {
            if (string.IsNullOrEmpty(landmarkName))
                return BadRequest("Landmark name cannot be null or empty");

            var landmark = _context.Landmarks.FirstOrDefault(x => x.Name.Contains(landmarkName));
            if (landmark == null)
                return NotFound("Landmark not found");

            var landmarkDto = new LandmarkDto
            {
                Id = landmark.Id,
                Name = landmark.Name,
                Description = landmark.Description,
                EgyptianStudentTicketPrice = landmark.EgyptianStudentTicketPrice,
                EgyptianTicketPrice = landmark.EgyptianTicketPrice,
                ForeignStudentTicketPrice = landmark.ForeignStudentTicketPrice,
                ForeignTicketPrice = landmark.ForeignTicketPrice,
                OpenTime = landmark.OpenTime,
                CloseTime = landmark.CloseTime,
                Latitude = landmark.Latitude,
                Longitude = landmark.Longitude,
                ImagesUrl = _context.LandmarkImages.Where(x => x.LandmarkId == landmark.Id).Select(x => x.Url).ToList()
            };

            return Ok(new { data = landmarkDto });
        }
        

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Delete(int? id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }

            var LandmarkToBeDeleted = _context.Landmarks.Find(id);
            if (LandmarkToBeDeleted == null)
            {
                return NotFound(new { success = false, message = "Error while deleting" });
            }
            string landmarkPath = @"landmarkImages\" + LandmarkToBeDeleted.Name.Replace(' ', '-');
            string finalPath = Path.Combine(_webHostEnvironment.WebRootPath, landmarkPath);

            if (Directory.Exists(finalPath))
            {
                string[] filePaths = Directory.GetFiles(finalPath);
                foreach (string filePath in filePaths)
                {
                    System.IO.File.Delete(filePath);
                }

                Directory.Delete(finalPath);
            }

            _context.Landmarks.Remove(LandmarkToBeDeleted);
            _context.SaveChanges();

            return Ok(new { success = true, message = "Deleted Successfully" });
        }
        // POST: api/landmark/add-history/{userId}/{landmarkId}
        [HttpPost("add-history/{userId}/{landmarkId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddSearchHistory([FromRoute] string userId, [FromRoute] int landmarkId)
        {
            // Validate userId and landmarkId
            if (string.IsNullOrEmpty(userId))
                return BadRequest("Invalid request: UserId and LandmarkId are required.");
            var userExists = _context.Users.Any(x => x.Id == userId);
            if (!userExists)
                return BadRequest("User not found");

            var landmarkExists = _context.Landmarks.Any(x => x.Id == landmarkId);
            if (!landmarkExists)
                return BadRequest("Landmark not found");
            var searchHistory = new SearchHistory
            {
                LandmarkID = landmarkId,
                UserId = userId,
                Date = DateTime.Now
            };
            _context.SearchHistory.Add(searchHistory);
            _context.SaveChanges();

            return Ok(new { message = "Search history added successfully" });
        }
        // POST: api/landmark/add-history/{userId}/{landmarkId}
        [HttpPost("toggleFavourite/{userId}/{landmarkId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ToggleFavourite([FromRoute] string userId, [FromRoute] int landmarkId)
        {

            if (string.IsNullOrEmpty(userId))
                return BadRequest("Invalid request: UserId and LandmarkId are required.");

            var userExists = _context.Users.Any(x => x.Id == userId);
            if (!userExists)
                return BadRequest("User not found");

            var landmarkExists = _context.Landmarks.Any(x => x.Id == landmarkId);
            if (!landmarkExists)
                return BadRequest("Landmark not found");

            var favouriteEntry = _context.Favours.FirstOrDefault(f => f.UserId == userId && f.LandmarkID == landmarkId);
            if (favouriteEntry != null)
            {
                _context.Favours.Remove(favouriteEntry);
                _context.SaveChanges();
                return Ok(new { message = "Favourite removed successfully" });
            }
            else
            {
                var favour = new Favour
                {
                    LandmarkID = landmarkId,
                    UserId = userId
                };
                _context.Favours.Add(favour);
                _context.SaveChanges();
                return Ok(new { message = "Favourite added successfully" });
            }
        }
        [HttpGet("getHistory/{userId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<IEnumerable<Landmark>> getHistory(string userId)
        {
            if (string.IsNullOrEmpty(userId))
                return BadRequest("UserId is required.");

            var landmarks = _context.SearchHistory
                .Include(sh => sh.Landmark) 
                .Where(sh => sh.UserId == userId)
                .Select(sh => sh.Landmark)
                .ToList();

            return Ok(new { data = landmarks });
        }
        [HttpGet("getFavourites/{userId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<IEnumerable<Landmark>> getFavourites([FromRoute]string userId)
        {
            if (string.IsNullOrEmpty(userId))
                return BadRequest("UserId is required.");

            var favouriteLandmarkIds = _context.Favours
        .Where(f => f.UserId == userId)
        .Select(f => f.LandmarkID)
        .ToList();

            // Filter all landmarks to include only the favourites
            var favouriteLandmarks = _context.Landmarks
                .Include(l => l.Images)
                .Where(l => favouriteLandmarkIds.Contains(l.Id))
                .ToList();

            return Ok(new { data = favouriteLandmarks });
        }
        [HttpGet("getNearestLandmarks/{longi}/{lat}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<IEnumerable<Landmark>> getNearestLandmarks([FromRoute] double longi, [FromRoute] double lat)
        {
            Console.WriteLine(longi);
            Console.WriteLine(lat);
            List<Landmark> allLandmarks = _context.Landmarks
                .Include(x => x.Images) 
                .ToList();

            List<Landmark> nearestLandmarks = new List<Landmark>();
            foreach (var landmark in allLandmarks)
            {
                double landmarkLat = landmark.Latitude;
                double landmarkLong = landmark.Longitude;
                double distance = CalculateDistance(lat, longi, landmarkLat, landmarkLong);
                
                    landmark.DistanceFromUser = distance; 
                    nearestLandmarks.Add(landmark);
               
            }

            nearestLandmarks.Sort((x, y) => x.DistanceFromUser.CompareTo(y.DistanceFromUser));
            return Ok(new { data = nearestLandmarks });
            
        }

        [HttpGet("isFavourite/{userId}/{landmarkId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult isFavourite([FromRoute] string userId, [FromRoute] int landmarkId)
        {

            if (string.IsNullOrEmpty(userId))
                return BadRequest("Invalid request: UserId and LandmarkId are required.");

            var userExists = _context.Users.Any(x => x.Id == userId);
            if (!userExists)
                return BadRequest("User not found");

            var landmarkExists = _context.Landmarks.Any(x => x.Id == landmarkId);
            if (!landmarkExists)
                return BadRequest("Landmark not found");

            var favouriteEntry = _context.Favours.FirstOrDefault(f => f.UserId == userId && f.LandmarkID == landmarkId);
            if (favouriteEntry != null)
            {
                return Ok();
            }
            else
            {
                return NotFound();  
            }
        }

        /*
         SQL Code to get the Top10SearchLandmarks:
            SELECT COUNT(*) AS 'Count', LandmarkID
            FROM SearchHistory
            GROUP BY LandmarkID
            ORDER BY Count DESC
         */
        //https://localhost:44316/api/landmark/Top10SearchLandmarks
        [HttpGet("Top10SearchLandmarks")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<IEnumerable<Landmark>> GetTop10SearchLandmarks()
        {
            if (_context.SearchHistory == null || _context.SearchHistory == null)
                return BadRequest(new { msg = "no enough data" });

            var landmarks = _context.SearchHistory.GroupBy(sh => sh.LandmarkID)
                                                .Select(g => new { LandmarkID = g.Key, Count = g.Count() })
                                                .OrderByDescending(g => g.Count)
                                                .Select(x => _context.Landmarks.FirstOrDefault(l => l.Id == x.LandmarkID))
                                                .ToList();
            return Ok(new { data = landmarks });

        }

        //https://localhost:44316/api/landmark/Top10FavoriteLandmarks
        [HttpGet("Top10FavoriteLandmarks")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<IEnumerable<Landmark>> GetTop10FavoriteLandmarks()
        {
            if (_context.Favours == null || _context.SearchHistory == null)
                return BadRequest(new { msg = "no enough data" });

            var landmarks = _context.Favours.GroupBy(sh => sh.LandmarkID)
                                          .Select(g => new { LandmarkID = g.Key, Count = g.Count() })
                                          .OrderByDescending(g => g.Count)
                                          .Select(x => _context.Landmarks.FirstOrDefault(l => l.Id == x.LandmarkID))
                                          .ToList();
            return Ok(new { data = landmarks });

        }

        [HttpPost("predict", Name = "PreicateLandmarkNameFromImage")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<string>> Predict([FromBody] ImageData imageData)
		{
			try
			{
				byte[] imageBytes = Convert.FromBase64String(imageData.Image);

				// Call Python API for prediction
				string prediction = await CallPythonApi(imageBytes);

				return Ok(prediction);
			}
			catch (Exception ex)
			{
				return BadRequest($"Error: {ex.Message}");
			}
		}

		private async Task<string> CallPythonApi(byte[] imageBytes)
		{
			try
			{
				string pythonApiUrl = "http://localhost:5000/predict"; // Replace with the actual URL of your Python API

				using (HttpClient client = new HttpClient())
				{

					var requestData = new { image = Convert.ToBase64String(imageBytes) };
					var content = new StringContent(System.Text.Json.JsonSerializer.Serialize(requestData), Encoding.UTF8, "application/json");


					HttpResponseMessage response = await client.PostAsync(pythonApiUrl, content);

					if (response.IsSuccessStatusCode)
					{

						string result = await response.Content.ReadAsStringAsync();
						return result;
					}
					else
					{

						return $"Error: {response.StatusCode}";
					}
				}
			}
			catch (Exception ex)
			{
				throw new Exception($"Failed to call Python API: {ex.Message}");
			}
		}
		public class ImageData
		{
			public string Image { get; set; }
		}

        private double CalculateDistance(double lat1, double lon1, double lat2, double lon2)
        {
            const double radius = 6371; // Earth's radius in kilometers

            // Convert latitude and longitude from degrees to radians
            double dLat = ToRadians(lat2 - lat1);
            double dLon = ToRadians(lon2 - lon1);

            // Haversine formula
            double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                       Math.Cos(ToRadians(lat1)) * Math.Cos(ToRadians(lat2)) *
                       Math.Sin(dLon / 2) * Math.Sin(dLon / 2);

            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            // Distance in kilometers
            double distance = radius * c;

            return distance;
        }

        // Helper method to convert degrees to radians
        private double ToRadians(double angle)
        {
            return angle * (Math.PI / 180);
        }

    }
}
