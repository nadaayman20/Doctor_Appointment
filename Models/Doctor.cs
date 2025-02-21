﻿using System.ComponentModel.DataAnnotations;

namespace Doctor_Appointment.Models
{
    public enum Gender
    {
        Female,
        Male
    }

    public enum Spectialist
    {
        Dentists,
        Neurology,
        Ophthalmology,
        Orthopedics,
        Cancer_Department,
        Internal_medicine,
        ENT

    }

    public enum MedicalDegree
    {
        specialist,

        Advisor,

        professor
    }

    public class Doctor
    {
        [Key]
        public int DoctorID { get; set; }

        [Required]
        [MinLength(10)]
        public String FullName { get; set; }

        [Required]
        [EnumDataType(typeof(Gender))]
        public Gender gender { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [EnumDataType(typeof(Spectialist))]
        public Spectialist specialist { get; set; }

        [Required]
        [EnumDataType(typeof(MedicalDegree))]
        public MedicalDegree Degree { get; set; }

        public string Description { get; set; }

        [Required]
        public string Clinic_Location { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public int Clinic_PhonNum { get; set; }

        public ICollection<DailyAvailbility> availableDays { get; set; } = new HashSet<DailyAvailbility>();

        public bool HomeExamination { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        [Range(1, 60)]
        public int WatingTime { get; set; }
    }
}
