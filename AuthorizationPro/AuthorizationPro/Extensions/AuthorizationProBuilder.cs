#region << 版 本 注 释 >>
/*----------------------------------------------------------------
//
// 文件名：AuthorizationProBuilder
// 文件功能描述：
//
// 
// 创建者：WangJunZzz
// 时间：2019/12/20 星期五 17:17:33
//
// 修改人：
// 时间：
// 修改说明：
//
// 修改人：
// 时间：
// 修改说明：
//
//----------------------------------------------------------------*/
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Extensions.DependencyInjection
{
    public class AuthorizationProBuilder : IAuthorizationProBuilder
    {
        public IServiceCollection Services { get; }

        public AuthorizationProBuilder(IServiceCollection theService)
        {
            Services = theService ?? throw new ArgumentNullException(nameof(theService));
        }
    }
}
