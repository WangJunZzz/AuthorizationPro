#region << 版 本 注 释 >>
/*----------------------------------------------------------------
//
// 文件名：AuthProDbContext
// 文件功能描述：
//
// 
// 创建者：WangJunZzz
// 时间：2019/12/20 星期五 17:26:26
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
using Microsoft.EntityFrameworkCore;

namespace AuthorizationPro.Entity
{
    public class AuthProDbContext : DbContext
    {
        public AuthProDbContext(DbContextOptions<AuthProDbContext> options) : base(options) { }

        public virtual DbSet<Role> Role { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<RoleApiResourceRelation>(entity =>
            {
                entity.HasKey(e => new { e.RoleId, e.ApiResourceId });
            });
            base.OnModelCreating(builder);
        }
    }
}
