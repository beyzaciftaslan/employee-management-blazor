using System.ComponentModel.DataAnnotations;

namespace demo.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ünvan zorunludur")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Ad zorunludur")]
        [StringLength(50)]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Soyad zorunludur")]
        [StringLength(50)]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Doğum tarihi zorunludur")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Pozisyon zorunludur")]
        public string Position { get; set; } = string.Empty;

        [Required(ErrorMessage = "İşe giriş tarihi zorunludur")]
        public DateTime HireDate { get; set; }

        [Required(ErrorMessage = "Eyalet zorunludur")]
        public string State { get; set; } = string.Empty;
        public string? Notes { get; set; }
        public string? HomeAddress { get; set; }

    }
}
