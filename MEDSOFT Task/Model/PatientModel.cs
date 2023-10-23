using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDSOFT_Task.Model
{
    public class PatientModel
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string personalId { get; set; }
        public string Email { get; set; }
        public string GenderName { get; set; }
        public int GenderId { get; set; }
        public DateTime BirthDate { get; set; }

        public PatientModel()
        {

        }
    }
}
