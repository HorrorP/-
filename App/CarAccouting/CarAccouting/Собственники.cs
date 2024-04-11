using System;
using System.Collections.Generic;

namespace CarAccouting
{
    public partial class Собственники
    {
        public Собственники()
        {
            Финансы = new HashSet<Финансы>();
        }

        public int Id { get; set; }
        public string Имя { get; set; }
        public string Фамилия { get; set; }
        public int? Квартира { get; set; }
        public string Телефон { get; set; }

        public virtual ICollection<Финансы> Финансы { get; set; }
    }
}
