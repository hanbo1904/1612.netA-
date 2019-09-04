using System;
using System.Collections.Generic;
using System.Text;

using HospitalScheds.Model;
using System.Data;

namespace HospitalScheds.IServerce
{
    public interface UserInfo
    {
        int Add(UserInfo userInfo);
        List<UserInfo> GetUserInfos(String Name = "");
        UserInfo GetUserInfo(int Id);
        int GetUserInfos(UserInfo userInfo, int Id);
    }
}
