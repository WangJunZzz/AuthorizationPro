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
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuthorizationPro.Entity
{
    [Table("Role")]
    public class Role
    {
        /// <summary>
        /// primary key
        /// </summary>
        [Key]
        [MaxLength(36)]
        public Guid Id { get; set; }

        /// <summary>
        /// role name
        /// </summary>
        [MaxLength(36)]
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// 0 is delete; 1 not delete
        /// </summary>
        [Required]
        [DefaultValue(0)]
        public int IsDelete { get; set; }

        /// <summary>
        /// 0 is valid; 1 not valid
        /// </summary>
        [Required]
        [DefaultValue(0)]
        public int IsValid { get; set; }

        /// <summary>
        /// create time
        /// </summary>
        [Required]
        public DateTime CreateTime { get; set; }
    }
}
