using EHRServerApi.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHRServerApi
{
    interface IWebService
    {
        User Login(string userName, string password);
    }
}
