﻿using System;
using System.ComponentModel.DataAnnotations;
using Swashbuckle.AspNetCore.Annotations;



namespace Lab6.Models
{
    public class Student
    {
        // ID field with Guid type, autogenerated by the database
        [Key]
        [SwaggerSchema(ReadOnly = true)]
        public Guid ID { get; set; }

        // FirstName field
        [Required]
        public string FirstName { get; set; }

        // LastName field
        [Required]
        public string LastName { get; set; }

        // Program field
        [Required]
        public string Program { get; set; }


    }
}
