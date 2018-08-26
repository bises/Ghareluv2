using System;

namespace RegistrationPortal.Services.SharedContext.Entities
{
    public class Udhyog
    {
        public int RegNum { get; set; }

        public DateTimeOffset RegDate { get; set; }

        public int TypeId { get; set; }

        public int ClassId { get; set; }

        public int SubClassId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int PanNo { get; set; }

        public int AddressId { get; set; }

        public UdhyogType Type { get; set; }

        public virtual UdhyogClass Class { get; set; }

        public virtual UdhyogSubClass SubClass { get; set; }

        public Address Address { get; set; }
    }
}
