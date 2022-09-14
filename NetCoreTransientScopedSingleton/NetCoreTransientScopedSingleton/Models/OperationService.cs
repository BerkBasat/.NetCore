using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreTransientScopedSingleton.Models
{
    public class OperationService : ITransient,IScoped,ISingleton
    {
        private Guid _id;
        public OperationService()
        {
            _id = Guid.NewGuid();
        }

        public Guid GetOperation()
        {
            return _id;
        }
    }
}
