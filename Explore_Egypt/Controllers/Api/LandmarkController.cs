using Explore_Egypt.DataAccess.Data;
using Explore_Egypt.DataAccess.Dto;
using Explore_Egypt.Models;
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
		public LandmarkController(ApplicationDbContext context)
		{
			_context = context;
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
		//e.g. https://localhost:44316/api/landmark/name/cairo-tower
		[HttpGet("name/{landmarkName}", Name = "GetLandmarkByName")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public ActionResult<IEnumerable<Landmark>> GetLandmark([FromRoute(Name = "landmarkName")] string name)
		{
			if (name == null)
				return BadRequest();

			var landmark = _context.Landmarks.FirstOrDefault(x => x.Name == name);
			if (landmark == null)
				return NotFound();

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
            //var oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath,LandmarkToBeDeleted.ImageUrl.TrimStart('\\'));

            //if (System.IO.File.Exists(oldImagePath))
            //{
            //	System.IO.File.Delete(oldImagePath);
            //}

            _context.Landmarks.Remove(LandmarkToBeDeleted);
            _context.SaveChanges();

            return Ok(new { success = true, message = "Deleted Successfully" });
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


	}
}
