using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace modeloparcial.Models
{
    public enum TypeList
    {
        Quintina,
        Quirina,
        Quiterio,
        Querubin,
        Quodvlud,

    }
    public class Friend
    {
        [Key]
        public int FriendId { get; set; }
        [Required]
        [Display(Name="nombre completo")]
        [StringLength(50,MinimumLength = 5)]
        public string Name { get; set; }
        public TypeList List { get; set; }
        [Required]
        public string Email { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true )]
        public int Birthdate { get; set; }
    }
}