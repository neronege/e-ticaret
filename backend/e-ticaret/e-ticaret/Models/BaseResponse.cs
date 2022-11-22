using System.Collections.Generic;

namespace e_ticaret.Models
{
    public abstract class BaseResponse
    {
        public List<string> Errors { get; set; }
        public bool IsSuccesfull { get; set; }

        public bool HasError { get; set; }
    }
}
