﻿using System.ComponentModel.DataAnnotations;

namespace FestPay.Web.Models.AccountViewModels
{
    public class UserViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}
