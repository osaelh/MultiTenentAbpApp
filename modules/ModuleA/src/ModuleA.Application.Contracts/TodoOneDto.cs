using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace ModuleA
{
    public class TodoOneDto : EntityDto<Guid>
    {
        public string Content { get; set; }
        public bool IsDone { get; set; }
        public Guid? TenantId { get; set; }

        public TodoOneDto(string content, bool isDone, Guid? tenantId)
        {
            Content = content;
            IsDone = isDone;
            TenantId = tenantId;
        }
    }
}
