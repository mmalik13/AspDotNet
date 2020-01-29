using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentsMVC.Models {

    public class Student {

        //Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Classroom StudentClassroom { get; set; }
        public Address StudentAddress { get; set; }
    }
}