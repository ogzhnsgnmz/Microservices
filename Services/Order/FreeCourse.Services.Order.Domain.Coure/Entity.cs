using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeCourse.Services.Order.Domain.Core
{
    public abstract class Entity
    {
        private int? _RequestedHashCode;
        private int _Id;
        public virtual int Id()
        {
            return 1;
        }
        public bool IsTransient()
        {
            return true;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public static bool operator ==(Entity left, Entity right)
        {
            return true;
        }
        public static bool operator !=(Entity left, Entity right)
        {
            return true;
        }
    }
}
