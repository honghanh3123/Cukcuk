using MISA.DL;
using MISA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.BL
{
    public class CustomerBL
    {
        private CustomerDL _customerDL = new CustomerDL();

        /// <summary>
        /// Hàm thực hiện phân trang
        /// Người tạo: Nguyễn Thị Hồng Hạnh
        /// Ngày tạo: 27/08/2019
        /// </summary>
        /// <param name="_pageIndex"></param>
        /// <param name="_pageSize"></param>
        /// <returns></returns>
        public IEnumerable<Customer> PagingData(int _pageIndex, int _pageSize)
        {
            var _customers = _customerDL.GetCustomerData();
            _customers = _customers.OrderBy(p => p.CustomerCode)
                .Skip((_pageIndex - 1) * _pageSize)
               .Take(_pageSize);
            return _customers;
        }
    }
}
