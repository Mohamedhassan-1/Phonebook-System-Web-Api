using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Models
{
    public class Contact:BaseEntity
    {
        [Required(ErrorMessage = "Contact's name cannot be empty.")]
        public string name { set; get; }
        [Required(ErrorMessage = "Contact's phoneNumber cannot be empty.")]
        public string phoneNumber { set; get; }
        [Required(ErrorMessage = "Contact's email cannot be empty.")]
        public string email { set; get; }

    }
}
