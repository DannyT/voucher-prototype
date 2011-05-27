using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using MvcTurbine.Web;
using MvcTurbine.ComponentModel;
using MvcTurbine.StructureMap;

namespace VoucherPrototype
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : TurbineApplication
    {
        public MvcApplication()
        {
             ServiceLocatorManager.SetLocatorProvider(() => new StructureMapServiceLocator());
        }
    }
}