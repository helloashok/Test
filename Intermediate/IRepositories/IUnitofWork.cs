using System;
using System.Collections.Generic;
using System.Text;

namespace Intermediate.IRepositories
{
   public interface IUnitofWork:IDisposable
    {
        public int Complete();
    }
}
