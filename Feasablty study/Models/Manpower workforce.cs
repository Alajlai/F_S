﻿namespace Feasablty_study.Models
{
    public class Manpower_workforce
    {
        public int ID { get; set; }
        public int Number { get; set; }
        public string JobTitle { get; set; }
        public decimal MonthlySalary { get; set; }
        public int TechnicalStudyId { get; set; }
        public Technical_Study technical_Study { get; set; }



    }
}
