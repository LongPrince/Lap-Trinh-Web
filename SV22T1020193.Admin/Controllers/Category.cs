using Microsoft.AspNetCore.Mvc;

namespace SV22T1020193.Admin.Controllers
{
    public class Category : Controller
    {
        /// <summary>
        /// Tìm kiếm và hiển thị danh sách loại hàng
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// Bổ sunng loại hàng mới
        /// </summary>
        /// <returns></returns>
        public IActionResult Create()
        {
            return View();
        }
        /// <summary>
        /// Cập nhật thông tin loại hàng
        /// </summary>
        /// <returns></returns>
        public IActionResult Edit()
        {
            return View();
        }
        /// <summary>
        ///   
        /// </summary>
        /// <returns></returns>
        public IActionResult Delete()
        {
            return View();
        }
    }
}
