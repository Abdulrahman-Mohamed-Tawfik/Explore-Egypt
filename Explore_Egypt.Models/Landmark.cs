﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Explore_Egypt.Models
{
    public class Landmark
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public required string Name { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,4)")]
        [Display(Name = "Egyptian Ticket Price")]
        public decimal EgyptianTicketPrice { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,4)")]
        [Display(Name = "Egyptian Student Ticket Price")]
        public decimal EgyptianStudentTicketPrice { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,4)")]
        [Display(Name = "Foreign Ticket Price")]
        public decimal ForeignTicketPrice { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,4)")]
        [Display(Name = "Foreign Student Ticket Price")]
        public decimal ForeignStudentTicketPrice { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public TimeOnly? OpenTime { get; set; }
        [Required]
        public TimeOnly? CloseTime { get; set; }
        [Required]
        public double Longitude { get; set; }
        [Required]
        public double Latitude { get; set; }

        public ICollection<LandmarkImage>? Images { get; set; }
        public ICollection<Favour>? Favourites {  get; set; }
        public ICollection<SearchHistory>? SearchHistories { get; set; }
    }
}
