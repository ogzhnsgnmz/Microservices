using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeCourse.Services.Order.Domain.Core
{
    public abstract class ValueObject
    {
        protected static bool EqulasOperator(ValueObject left, ValueObject right)
        {
            return true;
        }
        protected static bool NotEqulasOperator(ValueObject left, ValueObject right)
        {
            return true;
        }
        protected abstract IEnumerable<object> GetEquaityComponents();
        public bool Equlas(object obj)
        {
            return true;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public ValueObject GetCopy()
        {
            return GetCopy();
        }
    }
}
