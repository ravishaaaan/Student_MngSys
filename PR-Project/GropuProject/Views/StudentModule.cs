using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GropuProject.Views
{
    public class StudentModule
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int ModuleId { get; set; }
        public int Score { get; set; }

        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        //public byte[] Version { get; set; }

        public StudentModule(int studentId, int moduleId)
        {
            StudentId = studentId;
            ModuleId = moduleId;
        }

        public StudentModule()
        {

        }
    }
}
