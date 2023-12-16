using DataModel.Common;
using DataModel.KhoaHoc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Interfaces
{
    public partial interface IKhoaHocDAO
    {
        KhoaHocModel GetDatabyID(string id);

        public PagingResult<KhoaHocModel> SearchLoai(GetKhoaHocRequest getKhoaHocRequest);
        public PagingResult<KhoaHocModel> Search(GetKhoaHocRequest getKhoaHocRequest);
        public PagingResult<KhoaHocModel> SearchPro(GetKhoaHocRequest getKhoaHocRequest);
        public PagingResult<KhoaHocModel> SearchFree(GetKhoaHocRequest getKhoaHocRequest);
        public PagingResult<KhoaHocModel> SearchByUser(GetKhoaHocRequest getKhoaHocRequest);
        public bool DangKiKhoaHoc(DangKiKhoaHocRequest getKhoaHocRequest);

        public List<KhoaHocModel> KhoaHocCuaToi(Guid UserId);
        public List<KhoaHocModel> SearchAll();



    }
}
