using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformsMicrosoft.Domain
{
    [Table("pains")]
    public class Pains
    {
        [Column("id`")]
        public int Id { get; set; }
        
        [Column("typeofpain")]
        public string TypeOfPain { get; set; }
    }
}
