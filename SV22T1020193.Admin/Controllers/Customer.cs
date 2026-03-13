using SV22T1020193.Models.Common;
using Microsoft.AspNetCore.Mvc;
using SV22T1020193.BusinessLayers;

namespace SV22T1020193.Admin.Controllers
{
    public class Customer : Controller
    {
        private const int PAGESIZE = 5; 
        public IActionResult Index (int page = 1, string searchValue="")
        {
            var input = new PaginationSearchInput()
            {
                Page = page,
                PageSize = PAGESIZE,
                SearchValue = searchValue
            };
        
        var result = await PartnerDataService.listCustomerAsync(input);

         return  View();
        }
        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// Bổ sung khách hàng mới
        /// </summary>
        /// <returns></returns>
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
        /// <summary>
        /// Xóa khách hàng
        /// 
        /// </summary>
        /// <returns></returns>
        public IActionResult Delete()
        {
            return View();
        }
        /// <summary>
        /// Đổi mật khẩu khách hàng 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult Changepassword(int id)
        {
            return View();
        }
    }
}
