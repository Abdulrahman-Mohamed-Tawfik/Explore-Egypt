using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explore_Egypt.DataAccess.Dto
{
    public class LandmarkDto
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public decimal EgyptianTicketPrice { get; set; }
        public decimal EgyptianStudentTicketPrice { get; set; }
        public decimal ForeignTicketPrice { get; set; }
        public decimal ForeignStudentTicketPrice { get; set; }
        public string? Description { get; set; }
        public TimeOnly? OpenTime { get; set; }
        public TimeOnly? CloseTime { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public IEnumerable<string>? ImagesUrl { get; set; }
    }
}
