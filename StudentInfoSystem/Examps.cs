﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    class Examps
    {
        public int ExamId { get; set; }
        [ ForeignKey(nameof(Student))]
        public int StudentId { get; set; }
        public Student Student {get; set; } 
           






    }
}
