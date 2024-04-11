using System;
using System.Collections.Generic;

namespace CarAccouting
{
    public partial class Финансы
    {
        public int Id { get; set; }
        public int? IdСобственника { get; set; }
        public DateTime? Дата { get; set; }
        public int? IdУслуги { get; set; }

        public virtual Собственники IdСобственникаNavigation { get; set; }
        public virtual Услуги IdУслугиNavigation { get; set; }
    }
}
