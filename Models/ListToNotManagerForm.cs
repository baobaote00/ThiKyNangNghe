using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiKyNangNghe.Models
{
    public class ListToNotManagerForm
    {
        [Browsable(false)]
        public long ID { get; set; }
        [Browsable(false)]
        public long AssetID { get; set; }
        public string AssetSN { get; set; }
        public string AssetName { get; set; }
        public DateTime? RequestDate { get; set; }
        [Browsable(false)]
        public DateTime? EMEndDate { get; set; }
        public string EmployeeFullName { get; set; }
        public string Department { get; set; }

        public ListToNotManagerForm()
        {
        }
    }
}
