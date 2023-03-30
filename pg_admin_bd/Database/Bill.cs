using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg_admin_bd.Database
{
    public class Bill
    {
        [Key]
        public Guid IdBill { get; set; }
        public Account? Account { get; set; }
        public decimal Balance { get; set; }
    }
}
