using PMS.Business;
using PMS.Business.Models;
using PMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace PMS_WWW_Ver2.Controllers
{ 
    public class A_ProductController : ApiController
    {
        [HttpGet]
        public List<ProductModel> Gets(int FloorId, int IsAll)
        {
            return BLLCommodity.Gets(FloorId, IsAll);
            BLLSize.Instance.Gets
        }

        [HttpGet]
        public ResponseBase Save(SanPham model)
        {
            return BLLCommodity.InsertOrUpdate(model);
        }

        [HttpGet]
        public ResponseBase Delete(int Id)
        {
            return BLLCommodity.Delete(Id);
        }
    }
}
