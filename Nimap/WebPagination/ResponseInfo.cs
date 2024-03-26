using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using WebApplication5.Dtos;

namespace WebApplication5.Respone
{
    public class ResponseInfo
    {
        public ResponseInfo()
        {
            Status = 404;
            Message = "No Records";
            data = "";
        }
        [DataMember(Order = 0)]
        public int Status { get; set; }

        [DataMember(Order = 1)]
        public string Message { get; set; }

        [DataMember(Order = 2)]
        public dynamic data { get; set; }

        public void setsuccess(dynamic response)
        {
            Status = 200;
            Message = "Success";
            data = response;
        }

        public void SetFailure(dynamic responseData)
        {
            Status = 500;
            Message = "Fail";
            data = responseData;
        }
    }
}