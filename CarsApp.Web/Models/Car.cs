﻿using System.ComponentModel.DataAnnotations;

namespace CarsApp.Web.Models
{
    public class Car
    {
        public int Id { get; set; }

        public string Make { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public int Year { get; set; }
        public string Color { get; set; } = string.Empty;
    }
}