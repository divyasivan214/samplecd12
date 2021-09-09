using System;
using System.Collections.Generic;

#nullable disable

namespace apiForAzure.CTSModel
{
    public partial class Student
    {
        public int StudId { get; set; }
        public string StudName { get; set; }
        public string StudAddr { get; set; }
        public double? Marks { get; set; }
    }
}
