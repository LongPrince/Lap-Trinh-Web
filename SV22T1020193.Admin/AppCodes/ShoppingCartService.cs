using Microsoft.AspNetCore.Mvc;
using SV22T1020193.Models.Sales;

namespace SV22T1020193.Admin.AppCodes
{
    /// <summary>
    /// cung cấp chức năng xử lý trên giỏ hàng
    /// (giỏ hàng lưu trong sesion)
    /// </summary>
    public class ShoppingCartService
    {
        /// <summary>
        /// Tên biến để lưu trong session 
        /// </summary>
        private const string CART = "ShoppingCart";
        //Lấy giỏ hàng từ sesion 
        public static List<OrderDetailViewInfo> GetShoppingCart()
        {
            var cart = ApplicationContext.GetSessionData<List<OrderDetailViewInfo>>(CART);
            if (cart == null)
            {
                cart = new List<OrderDetailViewInfo>();
                ApplicationContext.SetSessionData(CART, cart);

            }
            return cart;
        }

        /// <summary>
        ///   Lấy thông tin 1 mặt hàng từ giỏ hàng
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public static OrderDetailViewInfo GetCartItem(int productId)
        {
            var cart = GetShoppingCart();
            return cart.Find(m => m.ProductID == productId);
        }

        // Thêm mặt hàng vào giỏ hàng
        public static void AddCartItem(OrderDetailViewInfo item)
        { 
            var car = GetShoppingCart();
            var existsItem = car.Find(m => m.ProductID == item.ProductID);
            if (existsItem == null)
            {
                car.Add(item);
            }
            else
            {
                existsItem.Quantity += item.Quantity;
                existsItem.SalePrice = item.SalePrice;
            }
            ApplicationContext.SetSessionData(CART, car);

        }


        //Cập nhật số lượng và giá của một mặt hàng trong giỏ hàng

        public static void UpdateCartItem(int productID, int quantity, int salePrice)
        {
            var cart = GetShoppingCart();
            var item = cart.Find (m => m.ProductID == productID);
            if ( item != null)
            {
                item.Quantity = quantity;
                item.SalePrice = salePrice;
                ApplicationContext.SetSessionData (CART, cart);
            }

        }

        //Xóa một mặt hàng ra khỏi giỏ hàng

        public static void RemoveCartItem(int productID)
        {
            var cart = GetShoppingCart();
            int index = cart.FindIndex(m => m.ProductID == productID);
            if (index >= 0)
            {
                ApplicationContext.SetSessionData(CART, cart);
            }
        }
        //Xóa all  giỏ hàng
        public static void ClearCart ()
        {
            var cart = new List<OrderDetailViewInfo>();
            ApplicationContext.SetSessionData(CART, cart);
        }
    }
}
