using SV22T1020193.DataLayers.Interfaces;
using SV22T1020193.DataLayers.SQLServer;
using SV22T1020193.Models.Common;
using SV22T1020193.Models.Partner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SV22T1020193.BusinessLayers
{
    /// <summary>
    /// Cung cấp các tính năng xử lý dữ liệu liên quan đến đối tác hệ thống
    /// Bao gồm: Supplier (nhà cung cấp),Customer (khách hàng),Shipper ( người giao hàng) 
    /// </summary>
    public static class PartnerDataService
    {
        private static readonly IGenericRepository<Supplier> supplierDB;
        private static readonly IGenericRepository<Shipper> shipperDB;
        private static readonly ICustomerRepository customerDB;

        static PartnerDataService()
        {
            supplierDB = new SupplierRepository(Configuration.ConnectionString);
            shipperDB = new ShipperRepository(Configuration.ConnectionString);
            customerDB = new CustomerRepository(Configuration.ConnectionString);
        }

        //=CÁC CHỨC NĂNG LIÊN QUAN ĐẾN NHÀ CUNG CẤP
        public static async Task<PagedResult<Supplier>> ListSupplierAsync(PaginationSearchInput input)
        {
            return await supplierDB.ListAsync(input);
        }
        /// <summary>
        /// Lấy thông tin của một nhà cung cấp có mã là <parmef name ="supplierID"/>
        /// </summary>
        /// <param name="supplierID"></param>
        /// <returns></returns>
        public static async Task <Supplier?> GetSupplierAsync(int supplierID)
        {
         return await supplierDB.GetAsync(supplierID);
        }
        ///<summary>
        ///Bổ sung một nhà cung cấp mới
        ///<param name="supplier"></param>
        ///<return>Mã của nhà cung cấp được bổ sung </return>
        /// </summary>
        
        public static async Task<int> AddSupplierAsync(Supplier supplier) {

            return await supplierDB.AddAsync(supplier);

        }
        /// <summary>
        /// Cập nhật thông tin của nhà cung câp
        /// </summary>
        /// <param name="supplier"></param>
        /// <returns></returns>
        public static async Task<bool> UppdateSupplierAsync(Supplier supplier)
        {
            return await supplierDB.UpdateAsync(supplier);

        }
        /// <summary>
        /// Xóa nhà cc có mã là <paramref name="supplierID"/>
        /// </summary>
        /// <param name="supplierID "></param>
        /// <returns></returns>
        public static async Task<bool> DeleteSupplierAsync(int  supplierID)
        {
          if   ( await supplierDB.IsUsedAsync (supplierID))
                    
                    return false;
            
            return await supplierDB.DeleteAsync(supplierID);

        }
        /// <summary>
        /// Kiêm tra xem một nhà cung cấp có mặt hàng liên quan không
        /// (sử dụng để kiêm tra xem có được phép xóa hay ko ?)
        /// </summary>
        /// <param name="supplierID"></param>
        /// <returns></returns>

        public static async Task<bool> IsUsedSupplierAsync ( int  supplierID )
        {
            return await supplierDB.IsUsedAsync(supplierID);
        }

        //== CÁC CHỨC NĂNG LIÊN QUAN ĐẾN NGƯỜI GIAO HÀNG


        //=CÁC CHỨC NĂNG LIÊN QUAN ĐẾN KHÁCH HÀNG


    }
}

/// Hãy viết đầy đủ các chức năng còn lại cho shipper và customer như đối với supplier
/// viết đầy đủ summary
/// xuất đầy đủ toàn bộ class 