using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AuthorizationPro.Entity
{
    public class ApiResource
    {
        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        [MaxLength(36)]
        public string ApiResourceId { get; set; }

        /// <summary>
        /// Base Url
        /// </summary>
        [MaxLength(128)]
        [Required]
        public string BaseUrl { get; set; }

        /// <summary>
        /// Api 参数
        /// </summary>
        [MaxLength(128)]
        public string Parameters { get; set; }

        /// <summary>
        /// 请求方法
        /// </summary>
        [Required]
        [MaxLength(12)]
        public string Method { get; set; }

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
