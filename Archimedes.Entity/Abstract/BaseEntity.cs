using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archimedes.Entity.Abstract
{
    public abstract class BaseEntity<T> where T : IEquatable<T>
    {
        public T Id { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;
    }
}
