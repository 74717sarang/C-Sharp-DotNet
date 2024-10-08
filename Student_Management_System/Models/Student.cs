﻿using System.ComponentModel.DataAnnotations;

namespace Para.Models
{
    public class Student
    {
        [Key]
        public int SID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
        public string Address { get; set; }
        public DateTime AdmissionDate { get; set; }
        public double Fees { get; set; }
        public string Status { get; set; }

        public Student() { }

        public Student(int id)
        {
            this.SID = id;
        }

        public Student(int sID, string name, string email, string mobileNo, string address, DateTime admissionDate, double fees, string status)
        {
            SID = sID;
            Name = name;
            Email = email;
            MobileNo = mobileNo;
            Address = address;
            AdmissionDate = admissionDate;
            Fees = fees;
            Status = status;
        }
    }
}
