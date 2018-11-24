﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Phonebook.Data;
using Phonebook.Data.Models;

namespace Phonebook.Controllers
{
    public class ContactController : Controller
    {
        [HttpPost]
        public IActionResult Create (Contact contact)
        {
            if (!ModelState.IsValid)
            {
                TempData["ErrorMessage"] = "Name and numbera are required";
            }
            else
            {
                DataAccess.Contacts.Add(contact);
            }
            
            
            return RedirectToAction("Index", "Home");
        }
    }
}