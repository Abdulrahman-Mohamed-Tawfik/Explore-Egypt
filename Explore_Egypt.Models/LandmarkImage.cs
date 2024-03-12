namespace Explore_Egypt.Models
{
	public class LandmarkImage
	{
        public int Id { get; set; }
        public string Url { get; set; }

        public int LandmarkId { get; set; }
        public Landmark Landmark { get; set; }
    }
}
