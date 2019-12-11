using System;

namespace Framework.Database.SqlServer.EntityFrameworkCore
{
    public interface IHasUniqueId
    {
        Guid UniqueId { get; set; }
    }
}