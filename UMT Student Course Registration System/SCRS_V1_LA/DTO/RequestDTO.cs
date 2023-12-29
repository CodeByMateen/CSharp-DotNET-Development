using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lect25_W3_LA.DTO
{
    class RequestDTO
    {
        private string _reqID;
        private string _reqStatus;
        private string _secID;
        private string _stdID;
        private string _reqType;
        private string _facID;

        public string ReqID { get => _reqID; set => _reqID = value; }
        public string ReqStatus { get => _reqStatus; set => _reqStatus = value; }
        public string SecID { get => _secID; set => _secID = value; }
        public string StdID { get => _stdID; set => _stdID = value; }
        public string ReqType { get => _reqType; set => _reqType = value; }
        public string FacID { get => _facID; set => _facID = value; }
    }
}
