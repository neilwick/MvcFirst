using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace MvcFirst.Models
{

    public class Game
    {
        public int GameID { get; set; }

        [MaxLength(24), MinLength(2)]
        public string Title { get; set; }

        [Display(Name = "Publisher Email"), DataType(DataType.EmailAddress)]
        public string PublisherEmail { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]

        public DateTime ReleaseDate { get; set; }

        [Range(1, 5)]
        public uint Rating{ get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(6,2)")]
        public decimal Price { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Secret Information")]
        public string SecretInformation { get; set; }

    }

}
