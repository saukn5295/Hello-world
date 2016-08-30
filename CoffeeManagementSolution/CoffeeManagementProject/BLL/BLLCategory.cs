using CoffeeManagementProject.DAL.Enity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManagementProject.BLL
{
    public class BLLCategory
    {
        /// <summary>
        /// Lấy danh sách các danh mục sản phẩm
        /// có trong csdl
        /// </summary>
        /// <returns></returns>
        public static List<Category> GetList() {
            List<Category> ls = new List<Category>();
            ls.Add(new Category { ID = "1", Name = "Coffee" });
            ls.Add(new Category { ID = "2", Name = "Bánh" });
            ls.Add(new Category { ID = "3", Name = "Kem" });
            ls.Add(new Category { ID = "4", Name = "Nước giải khát" });
            ls.Add(new Category { ID = "5", Name = "Thuốc lá" });
            return ls;
        }
    }
}
