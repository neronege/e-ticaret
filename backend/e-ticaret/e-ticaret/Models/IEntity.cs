using System;

namespace e_ticaret.Models
{
    public interface IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
