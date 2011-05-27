using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VoucherPrototype.Data;

namespace VoucherPrototype.Controllers
{
    public class VouchersController : Controller
    {
        private IVoucherRepository _voucherRepository;

        public VouchersController(IVoucherRepository voucherRepository)
        {
            _voucherRepository = voucherRepository;
        }
    }
}
