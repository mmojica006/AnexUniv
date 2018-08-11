﻿using Common;
using Model.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Domain
{
   public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }

        public Enums.Status Status { get; set; }
        public decimal Vote { get; set; }

        public Category Category { get; set; }
        public int CategoryId { get; set; }


        public ICollection<LessonsPerCourse> Lessons { get; set; } //nuestro curso puede tener varias lecciones
        [ForeignKey("AuthorId")]
        public ApplicationUser Author { get; set; }
        public string AuthorId { get; set; }


    }
}
