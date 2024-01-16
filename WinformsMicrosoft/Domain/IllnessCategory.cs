using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformsMicrosoft.Domain
{
    [Table("illnesscategory")]
    public class IllnessCategory
    {
        [Column("id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Поле CategoryName обязательно для заполнения")]
        [StringLength(255, ErrorMessage = "Длина CategoryName не должна превышать 255 символов")]
        [Column("categoryname")]
        public string CategoryName { get; set; }
        public ICollection<Complaints> Complaints { get; set; }
    }
}
