using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;
using Volo.Abp.MultiTenancy;

namespace ModuleA
{
    public class TodoOne : Entity<Guid>, IMultiTenant
    {
        public string Content { get; set; }
        public bool IsDone { get; set; }

        public Guid? TenantId { get; private set; }

        public TodoOne()
        {

        }

        public TodoOne(string content, bool isDone, Guid? tenantId)
        {
            Content = content;
            IsDone = isDone;
            TenantId = tenantId;
        }
    }
}
