#region << 版 本 注 释 >>
/*----------------------------------------------------------------
//
// 文件名：IAuthorizationProBuilder
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

namespace Microsoft.Extensions.DependencyInjection
{
    public interface IAuthorizationProBuilder
    {
        IServiceCollection Services { get; }
    }
}
