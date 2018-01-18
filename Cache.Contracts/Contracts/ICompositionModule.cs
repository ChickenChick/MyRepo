using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cache.Contracts.Contracts
{
    public interface ICompositionModule
    {
        void RegisterTypes(Container container);
    }
}
