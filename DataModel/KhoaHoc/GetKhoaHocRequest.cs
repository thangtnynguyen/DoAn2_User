using DataModel.Common;

namespace DataModel.KhoaHoc
{
    public class GetKhoaHocRequest : PagingRequest
    {
        public string? Ten { get; set; }
        public int? LoaiId { get; set; }

        public Guid? UserId { get; set; }

    }
}
