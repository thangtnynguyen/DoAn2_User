using BUS.Interfaces;
using DAO.Interfaces;
using DataModel.Common;
using DataModel.KhoaHoc;
using System.Reflection;

namespace BUS
{
    public class KhoaHocBUS : IKhoaHocBUS
    {
        private IKhoaHocDAO _khoaHocDAO;
        public KhoaHocBUS(IKhoaHocDAO res)
        {
            _khoaHocDAO = res;
        }
        public KhoaHocModel GetDatabyID(string id)
        {
            return _khoaHocDAO.GetDatabyID(id);
        }

     
        public PagingResult<KhoaHocModel> SearchLoai(GetKhoaHocRequest getKhoaHocRequest)
        {
            return _khoaHocDAO.SearchLoai(getKhoaHocRequest);

        }
        public PagingResult<KhoaHocModel> Search(GetKhoaHocRequest getKhoaHocRequest)
        {
            return _khoaHocDAO.Search(getKhoaHocRequest);

        }
        public PagingResult<KhoaHocModel> SearchPro(GetKhoaHocRequest getKhoaHocRequest)
        {
            return _khoaHocDAO.SearchPro(getKhoaHocRequest);

        }
        public PagingResult<KhoaHocModel> SearchFree(GetKhoaHocRequest getKhoaHocRequest)
        {
            return _khoaHocDAO.SearchFree(getKhoaHocRequest);

        }
        public PagingResult<KhoaHocModel> SearchByUser(GetKhoaHocRequest getKhoaHocRequest)
        {
            return _khoaHocDAO.SearchByUser(getKhoaHocRequest);

        }

        public List<KhoaHocModel> KhoaHocCuaToi(Guid UserId)
        {
            return _khoaHocDAO.KhoaHocCuaToi(UserId);
        }
        public bool DangKiKhoaHoc(DangKiKhoaHocRequest getKhoaHocRequest)
        {
            return _khoaHocDAO.DangKiKhoaHoc(getKhoaHocRequest);
        }


        public List<KhoaHocModel> SearchAll()
        {
            return _khoaHocDAO.SearchAll();
        }
      
    }
}