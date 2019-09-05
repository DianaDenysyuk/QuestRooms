﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuestRooms.UI.Models
{
    public class UserRegisterVM
    {
        [Required(ErrorMessage = "Field is required")]
        [EmailAddress(ErrorMessage = "Wrong format")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Field is required")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Field is required")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "Password must match")]
        public string ConfirmPassword { get; set; }

    }
}