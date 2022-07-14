using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelPortfolio.Models
{
    public class HotelModel
    {
        [Key]
        public int hotelID { get; set; }

        [Column(TypeName = "varchar(100)")]
        [Required(ErrorMessage = "Please Enter Name...")]
        public string hotelName { get; set; }

        [Column(TypeName = "varchar(25)")]
        [Required(ErrorMessage = "Please Enter Category...")]
        public string hotelCategory { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "Please Enter Branch...")]
        public string hotelBranch { get; set; }

        [Required(ErrorMessage = "Please Enter Rating...")]
        public int hotelRating { get; set; }

    }
}
