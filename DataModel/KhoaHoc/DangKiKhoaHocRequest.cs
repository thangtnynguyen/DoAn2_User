using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.KhoaHoc
{
    public class DangKiKhoaHocRequest
    {
        public Guid? UserId {  get; set; }

        public int IdKhoaHoc {  get; set; }
    }
}
