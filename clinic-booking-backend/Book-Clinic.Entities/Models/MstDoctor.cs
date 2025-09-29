using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Clinic.Entities.Models
{
    public class MstDoctor
    {
        public int DoctorId { get; set; }
        public string? DoctorName { get; set; }
        public int? CityId { get; set; }
        public string? CareSpecialization { get; set; }
        public string? Status { get; set; }
        // Foreign key for Clinic
        public int ClinicId { get; set; }
        public MstClinic? Clinic { get; set; }
        public ICollection<MstAppointment>? Appointments { get; set; }
    }
}
