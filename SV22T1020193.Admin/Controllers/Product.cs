using Microsoft.AspNetCore.Mvc;
using System;

namespace SV22T1020193.Admin.Controllers
{
    public class Product : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Detail(int id)
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult Delete ()
        {
            return View();
        }
        public IActionResult ListAttributes(int id)
        {
            return View();
        }
        public IActionResult CreateAttributes(int id)
        {
            return View();
        }
        /// <summary>
        /// Cập nhật thông tin thuộc tính của sản phẩm
        /// </summary>
        /// <param name="id">Mã mặt hàng có thuộc tính cần nhật</param>
        /// <param name="attributeID">Mã thuộc tính cần cập nhật</param>
        /// <returns></returns>
        public IActionResult EditAttributes(int id,int attributeID)
        {
            return View();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="attributeID"></param>
        /// <returns></returns>
        public IActionResult DeleteAttributes(int id, int attributeID)
        {
            return View();
        }
        public IActionResult ListPhoto(int id)
        {
            return View();
        }
        /// <summary>
        /// Bổ sung ảnh cho mặt hàng
        /// </summary>
        /// <param name="id">Mã mặt hàng cần bổ sung ảnh</param>
        /// <returns></returns>
        public IActionResult CreateListPhoto(int id)
        {
            return View();
        }
        /// <summary>
        /// Cập nhật thông tin ảnh của mặt hàng
        /// </summary>
        /// <param name="id">Mã mặt hàng có ảnh cần cập nhật</param>
        /// <param name="photoid">Mã ảnh cần cập nhật</param>
        /// <returns></returns>
        public IActionResult EditPhoto(int id,int photoid)
        {
            return View();
        }
        /// <summary>
        /// Xóa ảnh của mặt hàng
        /// </summary>
        /// <param name="id"></param>
        /// <param name="photoid"></param>
        /// <returns></returns>
        public IActionResult DeletePhoto(int id, int photoid)
        {
            return View();
        }
    }
}
