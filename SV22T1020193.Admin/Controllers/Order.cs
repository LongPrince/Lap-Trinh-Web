using Microsoft.AspNetCore.Mvc;
using System;

namespace SV22T1020193.Admin.Controllers
{
    public class Order : Controller
    {
        /// <summary>
        /// Nhập đầu vào tìm kiếm và hiển thị kết quả tìm kiếm đơn hàng
        /// </summary>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Tìm kiếm đơn hàng
        /// </summary>
        public IActionResult Search()
        {
            return View();
        }

        /// <summary>
        /// Giao diện các chức năng hỗ trợ cho nghiệp tạo đơn hàng mới 
        /// </summary>
        /// <return></returns>
        public IActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// Hiển thị thông tin chi tiết đơn hàng,
        /// và điều hướng các chức năng xử lý trên đơn hàng
        /// </summary>
        /// <param name="id">Mã đơn hàng cần xem và xử lý </param>
        public IActionResult Detail(int id)
        {
            return View();
        }

        /// <summary>
        /// Cập nhật số lượng,giá bán của 1  sản phẩm trong giỏ hoặc trong một đơn hàng 
        /// </summary>
        /// <param name="id"> =0: giỏ hàng, =! 0: Mã đơn hàng cần xử lý </param>
        /// <param name="productId">Mã sản phẩm</param>
        public IActionResult EditCartItem(int id = 0, int productId = 0)
        {
            if (id ==0)
            {
                //xử lý cho giỏ hàng 
            }
            else
            {
                //xử lý cho đơn hàng ///nguyên lý solib 
            }
            return View();
        }
       ///public IActionResult OderDetail (int id = 0, int productId = 0)

        /// <summary>
        /// Xóa sản phẩm khỏi đơn hàng
        /// </summary>
        /// <param name="id">Mã đơn hàng</param>
        /// <param name="productId">Mã sản phẩm cần xóa</param>
        public IActionResult DeleteCartItem(int id=0, int productId = 0)
        {
            return View();
        }

        /// <summary>
        /// Xóa toàn bộ giỏ hàng
        /// </summary>
        public IActionResult ClearCart()
        {
            return View();
        }

        /// <summary>
        /// Duyệt đơn hàng
        /// </summary>
        /// <param name="id">Mã đơn hàng</param>
        public IActionResult Accept(int id)
        {
            return View();
        }

        /// <summary>
        /// Chuyển trạng thái đang giao
        /// </summary>
        /// <param name="id">Mã đơn hàng</param>
        public IActionResult Shipping(int id)
        {
            return View();
        }

        /// <summary>
        /// Hoàn tất đơn hàng
        /// </summary>
        /// <param name="id">Mã đơn hàng</param>
        public IActionResult Finish(int id)
        {
            return View();
        }

        /// <summary>
        /// Từ chối đơn hàng
        /// </summary>
        /// <param name="id">Mã đơn hàng</param>
        public IActionResult Reject(int id)
        {
            return View();
        }

        /// <summary>
        /// Hủy đơn hàng
        /// </summary>
        /// <param name="id">Mã đơn hàng</param>
        public IActionResult Cancel(int id)
        {
            return View();
        }
        public IActionResul test(int id)
        {
            return View();
        }
    }
}