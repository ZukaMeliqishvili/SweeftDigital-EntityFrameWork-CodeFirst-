using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkApplication.Data
{
    public class PupilTeacherRel
    {
        [Required]
        public int Id { get; set; }
        public int? TeacherId { get; set; }
        [ForeignKey("TeacherId")]
        public Teacher Teacher { get; set; }
        public int PupilId { get; set; }
        [ForeignKey("PupilId")]
        public Pupil Pupil { get; set; }
    }
}
