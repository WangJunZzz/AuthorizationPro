#region << 版 本 注 释 >>
/*----------------------------------------------------------------
//
// 文件名：Role
// 文件功能描述：
//
// 
// 创建者：WangJunZzz
// 时间：2019/12/20 星期五 17:39:44
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
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuthorizationPro.Entity
{
    [Table("Role")]
    public class Role
    {
        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        [MaxLength(36)]
        public string RoleId { get; set; }

        /// <summary>
        /// 角色名称
        /// </summary>
        [MaxLength(36)]
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// 0 没有删除 1 删除
        /// </summary>
        [Required]
        [DefaultValue(0)]
        public int IsDelete { get; set; }

        /// <summary>
        /// 0 有效 1 无效
        /// </summary>
        [Required]
        [DefaultValue(0)]
        public int IsValid { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [Required]
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 角色接口关联
        /// </summary>
        public virtual ICollection<RoleApiResourceRelation> RoleApiResourceRelations { get; set; }
    }
}
