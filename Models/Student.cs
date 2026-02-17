using System.ComponentModel.DataAnnotations;

namespace StudentApi.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string StudentName { get; set; }

        [Required]
        public string StudentGender { get; set; }

        [Range(5, 100)]
        public int Age { get; set; }

        [Required]
        public string Standard { get; set; }

        public string FatherName { get; set; }

        public int RollNumber {  get; set; }
    }
}