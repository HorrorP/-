using System;
using System.Collections.Generic;

namespace CarAccouting
{
    public partial class Услуги
    {
        public Услуги()
        {
            Финансы = new HashSet<Финансы>();
        }

        public int Id { get; set; }
        public string Название { get; set; }
        public decimal? Стоимость { get; set; }

        public virtual ICollection<Финансы> Финансы { get; set; }
    }
}
