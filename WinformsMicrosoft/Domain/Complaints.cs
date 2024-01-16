using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformsMicrosoft.Domain
{
    [Table("complaints")]
    public class Complaints
    {
        [Column("id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Поле ComplaintName обязательно для заполнения")]
        [StringLength(255, ErrorMessage = "Длина ComplaintName не должна превышать 255 символов")]
        [Column("complaintname")]
        public string ComplaintName { get; set; }
        [Column("illnesscategoryid")]
        public int IllnessCategoryId { get; set; }

        public IllnessCategory illnessCategory { get; set; }
    }

}
