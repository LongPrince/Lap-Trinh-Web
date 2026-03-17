using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteCommerce.DataLayers.Interfaces;
using LiteCommerce.DataLayers.SQLServer;
using LiteCommerce.Models.Partner;

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

        //== CÁC CHỨC NĂNG LIÊN QUAN ĐẾN NGƯỜI GIAO HÀNG

        //=CÁC CHỨC NĂNG LIÊN QUAN ĐẾN KHÁCH HÀNG


    }
}
