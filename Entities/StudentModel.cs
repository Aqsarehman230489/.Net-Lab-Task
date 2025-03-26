using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public class StudentModel
	{
		[Required]
		public string? Id { get; set; }
        [Required]
        public string? FullName { get; set; }
        [Required]
        public string? Description { get; set; }
	}
}
