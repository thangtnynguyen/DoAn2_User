using DAO.Interfaces;
using Microsoft.AspNetCore.Mvc;
using BUS;
using BUS.Interfaces;
using Microsoft.AspNetCore.Authorization;
using DataModel.KhoaHoc;
using DataModel.Common;
using DataModel.User;

namespace DoAn2.QLKhoaHoc.Api.User.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class KhoaHocController : ControllerBase
    {
        private IKhoaHocBUS _khoahocbus;
        private string _path;
        private IWebHostEnvironment _env;
        public KhoaHocController(IKhoaHocBUS khoahocbus, IConfiguration configuration, IWebHostEnvironment env)
        {
            _khoahocbus = khoahocbus;
            _path = configuration["AppSettings:PATH"];
            _env = env;
        }

        [Route("search-khoahoc-danhmuc")]
        [HttpPost]
        [AllowAnonymous]
        public ApiResult<PagingResult<KhoaHocModel>> SearchLoai([FromBody] GetKhoaHocRequest getKhoaHocRequest)
        {
            try
            {
                var data = _khoahocbus.SearchLoai(getKhoaHocRequest);
                return new ApiResult<PagingResult<KhoaHocModel>>()
                {
                    Status = true,
                    Message = "Danh sách khóa học đã được lấy thành công!",
                    Data = data
                };
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        [Route("search-khoahoc")]
        [HttpPost]
        [AllowAnonymous]
        public ApiResult<PagingResult<KhoaHocModel>> Search([FromBody] GetKhoaHocRequest getKhoaHocRequest)
        {
            try
            {
                var data = _khoahocbus.Search(getKhoaHocRequest);
                return new ApiResult<PagingResult<KhoaHocModel>>()
                {
                    Status = true,
                    Message = "Danh sách khóa học đã được lấy thành công!",
                    Data = data
                };
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        [Route("search-khoahoc-pro")]
        [HttpPost]
        [AllowAnonymous]
        public ApiResult<PagingResult<KhoaHocModel>> SearchPro([FromBody] GetKhoaHocRequest getKhoaHocRequest)
        {
            try
            {
                var data = _khoahocbus.SearchPro(getKhoaHocRequest);
                return new ApiResult<PagingResult<KhoaHocModel>>()
                {
                    Status = true,
                    Message = "Danh sách khóa học đã được lấy thành công!",
                    Data = data
                };
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        [Route("search-khoahoc-free")]
        [HttpPost]
        [AllowAnonymous]
        public ApiResult<PagingResult<KhoaHocModel>> SearchFree([FromBody] GetKhoaHocRequest getKhoaHocRequest)
        {
            try
            {
                var data = _khoahocbus.SearchFree(getKhoaHocRequest);
                return new ApiResult<PagingResult<KhoaHocModel>>()
                {
                    Status = true,
                    Message = "Danh sách khóa học đã được lấy thành công!",
                    Data = data
                };
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        [Route("search-khoahoc-byUser")]
        [HttpPost]
        [AllowAnonymous]
        public ApiResult<PagingResult<KhoaHocModel>> SearchByUser([FromBody] GetKhoaHocRequest getKhoaHocRequest)
        {
            try
            {
                var data = _khoahocbus.SearchByUser(getKhoaHocRequest);
                return new ApiResult<PagingResult<KhoaHocModel>>()
                {
                    Status = true,
                    Message = "Danh sách khóa học đã được lấy thành công!",
                    Data = data
                };
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        [Route("khoahoccuatoi")]
        [HttpPost]
        [AllowAnonymous]
        public ApiResult<List<KhoaHocModel>> KhoaHocCuaToi([FromBody] Guid UserId)
        {
            try
            {
                var data = _khoahocbus.KhoaHocCuaToi(UserId);
                return new ApiResult<List<KhoaHocModel>>()
                {
                    Status = true,
                    Message = "Danh sách khóa học đã được lấy thành công!",
                    Data = data
                };
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        [Route("dangkikhoahoc")]
        [HttpPost]
        public ApiResult<DangKiKhoaHocRequest> SignUp([FromForm] DangKiKhoaHocRequest dangKiKhoaHocRequest)
        {
            if (_khoahocbus.DangKiKhoaHoc(dangKiKhoaHocRequest))
            {
                return new ApiResult<DangKiKhoaHocRequest>()
                {
                    Status = true,
                    Message = "Đăng kí khóa học thành công",
                    Data = dangKiKhoaHocRequest
                };
            }
            else
                return new ApiResult<DangKiKhoaHocRequest>()
                {
                    Status = false,
                    Message = "Đăng kí thất bại!",
                    Data = null
                };
        }


    }
}
