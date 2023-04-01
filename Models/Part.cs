namespace ThiKyNangNghe.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Part
    {
        [Browsable(false)]
        public long ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public int Amount { get; set; }
        [Browsable(false)]
        public long? EffectiveLife { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            if (obj is Part)
            {
                return this.ID == ((Part)obj).ID;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
