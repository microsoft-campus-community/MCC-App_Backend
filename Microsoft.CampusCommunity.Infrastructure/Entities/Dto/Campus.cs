using System;
using Microsoft.CampusCommunity.Infrastructure.Entities.Db;

namespace Microsoft.CampusCommunity.Infrastructure.Entities.Dto
{
    public class Campus : BaseEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid HubId { get; set; }
        public string HubName { get; set; }

        // TODO: Use graph extension for a nicer location name
        public string CampusLocation => Name.Replace("Campus ", "");
        public string University { get; set; }
        public Guid Lead { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public Guid? ModifiedBy { get; set; }

        public static Campus FromMccGroup(MccGraphGroup g)
        {
            return new Campus(null)
            {
                Id = g.Id,
                Name = g.Name,
                HubId = Guid.Empty,
                University = "?",
                Lead = Guid.Empty,
                HubName = "?"
            };
        }

        public static Campus FromDb(Db.Campus c)
        {
            return new Campus(c.ModifiedBy)
            {
                Id = c.Id,
                Name = c.Name,
                HubId = c.Hub.Id,
                HubName = c.Hub.Name,
                University = c.UniversityName,
                Lead = c.Lead,
                CreatedAt = c.CreatedAt,
                ModifiedAt = c.ModifiedAt
            };
        }

        /// <inheritdoc />
        public Campus(Guid? modifiedBy) : base(modifiedBy)
        {
        }
    }
}