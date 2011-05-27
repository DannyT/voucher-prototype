using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using MvcTurbine.ComponentModel;
using VoucherPrototype.Data;
using VoucherPrototype.Data.Impl;

namespace VoucherPrototype.Registration
{
    public class DefaultRegistration : IServiceRegistration
    {
        public void Register(IServiceLocator locator)
        {
            locator.Register<IVoucherRepository, VoucherRepository>();
        }
    }
}