using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Lab3.Models

//W każdym modelu należy zadeklarować jedną wspólną właściwość Id typu int.
//Post - zawartość, autor, data publikacji, tagi, komentarz
{
    public class Post
    {
        [HiddenInput]
        public int Id { get; set; }

        [Required(ErrorMessage = "Proszę podać zawartość")]
        [StringLength(maximumLength: 5000, ErrorMessage = "Zbyt dlugie imie, podaj mniejsze")]
        public string Content { get; set; }

        [Required(ErrorMessage = "Proszę podać imię")]
        [StringLength(maximumLength: 50, ErrorMessage = "Zbyt dlugie imie, podaj mniejsze")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Proszę podać datę publikacji")]
        [DataType(DataType.Date)]
        public DateTime? PublicationDate { get; set; }

        [RegularExpression("^#\\w+$")]
        [Required(ErrorMessage = "Proszę podać tag na początku ze znakiem #...")]
        public string? Tags { get; set; }
        public string? Comment { get; set;}
    }
}
