using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Book
    {
        public int BookId { get; set; }


        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string bookTitle { get; set; } = string.Empty;



        [Required]
        [StringLength(200, MinimumLength = 3)]
        public string bookDesc { get; set; } = string.Empty;


        [Required]
        public DateTime bookWritingDate { get; set; }


        [Required]
        public int AuthorId { get; set; }

        public Author Author { get; set; }



    }
}
