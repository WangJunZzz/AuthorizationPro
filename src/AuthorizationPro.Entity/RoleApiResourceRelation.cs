using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AuthorizationPro.Entity
{
    public class RoleApiResourceRelation
    {
        /// <summary>
        /// 角色编号
        /// </summary>
        public string RoleId { get; set; }

        /// <summary>
        /// Api接口编号
        /// </summary>
        public string ApiResourceId { get; set; }

        /// <summary>
        /// 角色
        /// </summary>
        public virtual Role Role { get; set; }

        /// <summary>
        /// Api接口
        /// </summary>
        public virtual ApiResource ApiResource { get; set; }
    }
}
