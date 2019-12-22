#region << 版 本 注 释 >>
/*----------------------------------------------------------------
//
// 文件名：AuthorizationProServices
// 文件功能描述：
//
// 
// 创建者：WangJunZzz
// 时间：2019/12/20 星期五 18:01:20
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
    public static class AuthorizationProServices
    {
        public static IAuthorizationProBuilder AddAuthorizationPro(this IServiceCollection services)
        {
            var builder = new AuthorizationProBuilder(services);
            return builder;
        }
    }
}
