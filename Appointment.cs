using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969
{
    internal class Appointment
    {
		public int AppointmentId { get; set; }
		public int UserId { get; set; }
		public string Type { get; set; }
		public DateTime Start { get; set; }
	}
}
