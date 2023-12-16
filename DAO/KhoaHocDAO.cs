using DAO.Helper.Interfaces;
using DAO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.Helper.Interfaces;
using System.Runtime.InteropServices;
using DAO.Helper;
using DataModel.KhoaHoc;
using System.Reflection;
using DataModel.Common;
using DataModel.User;

namespace DAO
{
    public class KhoaHocDAO : IKhoaHocDAO
    {

        private ITruyVanDuLieu _truyvan;
        public KhoaHocDAO(ITruyVanDuLieu dbHelper)
        {
            _truyvan = dbHelper;
        }
       

       

        public KhoaHocModel GetDatabyID(string id)
        {
            string msgError = "";
            try
            {
                var dt = _truyvan.ExecuteSProcedureReturnDataTable(out msgError, "sp_LayKhoaHocById",
                "@id", id);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<KhoaHocModel>().FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
      
        public PagingResult<KhoaHocModel> SearchLoai(GetKhoaHocRequest getKhoaHocRequest)
        {
            string msgError = "";
            try
            {
                var dt = _truyvan.ExecuteSProcedureReturnDataTable(out msgError, "sp_TimKiemKhoaHocLoai",
                "@page_index", getKhoaHocRequest.PageIndex,
                "@page_size", getKhoaHocRequest.PageSize,
                "@loai_id",getKhoaHocRequest.LoaiId);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                if (dt.Rows.Count > 0)
                {
                    long TotalPages_pre = (long)dt.Rows[0]["RecordCount"] / ((int)getKhoaHocRequest.PageSize);
                    if ((long)dt.Rows[0]["RecordCount"] % ((int)getKhoaHocRequest.PageSize) != 0)
                    {
                        TotalPages_pre++;
                    }
                    return new PagingResult<KhoaHocModel>()
                    {
                        Items = dt.ConvertTo<KhoaHocModel>().ToList(),
                        PageIndex = (int)getKhoaHocRequest.PageIndex,
                        PageSize = (int)getKhoaHocRequest.PageSize,
                        TotalRecords = (long)dt.Rows[0]["RecordCount"],
                        TotalPages = TotalPages_pre,
                    };
                }
                else
                {
                    return new PagingResult<KhoaHocModel>()
                    {
                        Items = null,
                        PageIndex = 0,
                        PageSize =0,
                        TotalRecords = 0,
                        TotalPages = 0,
                    };
                }
                

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public PagingResult<KhoaHocModel> Search(GetKhoaHocRequest getKhoaHocRequest)
        {
            string msgError = "";
            try
            {
                var dt = _truyvan.ExecuteSProcedureReturnDataTable(out msgError, "sp_TimKiemKhoaHoc",
                "@page_index", getKhoaHocRequest.PageIndex,
                "@page_size", getKhoaHocRequest.PageSize,
                "@ten_khoa", getKhoaHocRequest.Ten);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                if (dt.Rows.Count > 0)
                {
                    long TotalPages_pre = (long)dt.Rows[0]["RecordCount"] / ((int)getKhoaHocRequest.PageSize);
                    if ((long)dt.Rows[0]["RecordCount"] % ((int)getKhoaHocRequest.PageSize) != 0)
                    {
                        TotalPages_pre++;
                    }
                    return new PagingResult<KhoaHocModel>()
                    {
                        Items = dt.ConvertTo<KhoaHocModel>().ToList(),
                        PageIndex = (int)getKhoaHocRequest.PageIndex,
                        PageSize = (int)getKhoaHocRequest.PageSize,
                        TotalRecords = (long)dt.Rows[0]["RecordCount"],
                        TotalPages = TotalPages_pre,
                    };
                }
                else
                {
                    return new PagingResult<KhoaHocModel>()
                    {
                        Items = null,
                        PageIndex = 0,
                        PageSize = 0,
                        TotalRecords = 0,
                        TotalPages = 0,
                    };
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public PagingResult<KhoaHocModel> SearchPro(GetKhoaHocRequest getKhoaHocRequest)
        {
            string msgError = "";
            try
            {
                var dt = _truyvan.ExecuteSProcedureReturnDataTable(out msgError, "sp_TimKiemKhoaHocPro",
                "@page_index", getKhoaHocRequest.PageIndex,
                "@page_size", getKhoaHocRequest.PageSize,
                "@ten_khoa", getKhoaHocRequest.Ten);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                if (dt.Rows.Count > 0)
                {
                    long TotalPages_pre = (long)dt.Rows[0]["RecordCount"] / ((int)getKhoaHocRequest.PageSize);
                    if ((long)dt.Rows[0]["RecordCount"] % ((int)getKhoaHocRequest.PageSize) != 0)
                    {
                        TotalPages_pre++;
                    }
                    return new PagingResult<KhoaHocModel>()
                    {
                        Items = dt.ConvertTo<KhoaHocModel>().ToList(),
                        PageIndex = (int)getKhoaHocRequest.PageIndex,
                        PageSize = (int)getKhoaHocRequest.PageSize,
                        TotalRecords = (long)dt.Rows[0]["RecordCount"],
                        TotalPages = TotalPages_pre,
                    };
                }
                else
                {
                    return new PagingResult<KhoaHocModel>()
                    {
                        Items = null,
                        PageIndex = 0,
                        PageSize = 0,
                        TotalRecords = 0,
                        TotalPages = 0,
                    };
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public PagingResult<KhoaHocModel> SearchFree(GetKhoaHocRequest getKhoaHocRequest)
        {
            string msgError = "";
            try
            {
                var dt = _truyvan.ExecuteSProcedureReturnDataTable(out msgError, "sp_TimKiemKhoaHocFree",
                "@page_index", getKhoaHocRequest.PageIndex,
                "@page_size", getKhoaHocRequest.PageSize,
                "@ten_khoa", getKhoaHocRequest.Ten);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                if (dt.Rows.Count > 0)
                {
                    long TotalPages_pre = (long)dt.Rows[0]["RecordCount"] / ((int)getKhoaHocRequest.PageSize);
                    if ((long)dt.Rows[0]["RecordCount"] % ((int)getKhoaHocRequest.PageSize) != 0)
                    {
                        TotalPages_pre++;
                    }
                    return new PagingResult<KhoaHocModel>()
                    {
                        Items = dt.ConvertTo<KhoaHocModel>().ToList(),
                        PageIndex = (int)getKhoaHocRequest.PageIndex,
                        PageSize = (int)getKhoaHocRequest.PageSize,
                        TotalRecords = (long)dt.Rows[0]["RecordCount"],
                        TotalPages = TotalPages_pre,
                    };
                }
                else
                {
                    return new PagingResult<KhoaHocModel>()
                    {
                        Items = null,
                        PageIndex = 0,
                        PageSize = 0,
                        TotalRecords = 0,
                        TotalPages = 0,
                    };
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public PagingResult<KhoaHocModel> SearchByUser(GetKhoaHocRequest getKhoaHocRequest)
        {
            string msgError = "";
            try
            {
                var dt = _truyvan.ExecuteSProcedureReturnDataTable(out msgError, "sp_TimKiemKhoaHocProByUser",
                "@page_index", getKhoaHocRequest.PageIndex,
                "@page_size", getKhoaHocRequest.PageSize,
                "@ten_khoa", getKhoaHocRequest.Ten,
                "@UserId",getKhoaHocRequest.UserId);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                if (dt.Rows.Count > 0)
                {
                    long TotalPages_pre = (long)dt.Rows[0]["RecordCount"] / ((int)getKhoaHocRequest.PageSize);
                    if ((long)dt.Rows[0]["RecordCount"] % ((int)getKhoaHocRequest.PageSize) != 0)
                    {
                        TotalPages_pre++;
                    }
                    return new PagingResult<KhoaHocModel>()
                    {
                        Items = dt.ConvertTo<KhoaHocModel>().ToList(),
                        PageIndex = (int)getKhoaHocRequest.PageIndex,
                        PageSize = (int)getKhoaHocRequest.PageSize,
                        TotalRecords = (long)dt.Rows[0]["RecordCount"],
                        TotalPages = TotalPages_pre,
                    };
                }
                else
                {
                    return new PagingResult<KhoaHocModel>()
                    {
                        Items = null,
                        PageIndex = 0,
                        PageSize = 0,
                        TotalRecords = 0,
                        TotalPages = 0,
                    };
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<KhoaHocModel> KhoaHocCuaToi(Guid UserId)
        {
            string msgError = "";
            try
            {
                string query = "SELECT *  FROM KhoaHocCuaToi INNER JOIN KhoaHoc ON KhoaHocCuaToi.IdKhoaHoc=KhoaHoc.Id  WHERE UserId = '" + UserId + "' ";
                var dt = _truyvan.ExecuteQueryToDataTable(query, out msgError);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<KhoaHocModel>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DangKiKhoaHoc(DangKiKhoaHocRequest dangKiKhoaHocRequest)
        {
            try
            {
                string ere = "";
                object[] parameters = new object[] { "@UserId", dangKiKhoaHocRequest.UserId, "@IdKhoaHoc", dangKiKhoaHocRequest.IdKhoaHoc};
                var dt = _truyvan.ExecuteScalarSProcedureWithTransaction(out ere, "sp_ThemKhoaHocCuaToi", parameters);
                return true;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public List<KhoaHocModel> SearchAll()
        {
            string msgError = "";
            try
            {
                string query = "SELECT *  FROM KhoaHoc WHERE DeleteAt is null";
                var dt = _truyvan.ExecuteQueryToDataTable(query, out msgError);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<KhoaHocModel>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
