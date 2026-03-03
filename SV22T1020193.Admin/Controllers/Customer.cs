using Microsoft.AspNetCore.Mvc;

namespace SV22T1020193.Admin.Controllers
{
    public class Customer : Controller
    {
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
