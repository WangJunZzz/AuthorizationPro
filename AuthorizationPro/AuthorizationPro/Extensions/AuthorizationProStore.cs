#region << 版 本 注 释 >>
/*----------------------------------------------------------------
//
// 文件名：AuthorizationProStore
// 文件功能描述：添加数据库支持，支持Mysql,Sql Server,Oracle
//  
// 
// 创建者：WangJunZzz
// 时间：2019/12/20 星期五 17:22:46
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
using AuthorizationPro.Entity;
using Microsoft.EntityFrameworkCore;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// Store Extensions
    /// </summary>
    public static class AuthorizationProStore
    {
        /// <summary>
        /// add database support
        /// </summary>
        /// <param name="builder">iauthorizationProBuilder</param>
        /// <param name="dbContextOptionsBuilder">DbContextOptionsBuilder</param>
        /// <returns></returns>
        public static IAuthorizationProBuilder AddAuthorizationProStore(this IAuthorizationProBuilder builder, Action<DbContextOptionsBuilder> dbContextOptionsBuilder)
        {
            return builder.AddAuthorizationProStore<AuthProDbContext>(dbContextOptionsBuilder);
        }

        public static IAuthorizationProBuilder AddAuthorizationProStore<TContext>(this IAuthorizationProBuilder authorizationProBuilder, Action<DbContextOptionsBuilder> dbContextOptionsBuilder) where TContext : DbContext
        {
            authorizationProBuilder.Services.AddDbContext<TContext>(builder => dbContextOptionsBuilder.Invoke(builder));
            return authorizationProBuilder;
        }
    }
}
