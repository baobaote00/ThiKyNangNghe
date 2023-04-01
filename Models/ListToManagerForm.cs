using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiKyNangNghe.Models
{
    [Serializable]
    class ListToManagerForm
    {
        [Browsable(false)]
        public long ID { get; set; }
        public String AssetSN { get; set; }
        public string AssetName { get; set; }
        public DateTime? LastClosedEM { get; set; }
        public int NumberOfEMs { get; set; }

        public ListToManagerForm()
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
