using entities;
using FluentNHibernate.Mapping;

namespace daoNHibernate.mapping
{
    public class CountryMap : ClassMap<CountryEntity>
    {
        public CountryMap()
        {
            Table("Country");
            Id(x => x.Id).GeneratedBy.Identity().Column("ID").UnsavedValue(0);
            Map(x => x.Name).Column("Name").Not.Nullable();
            HasMany<UserEntity>(x => x.AssociatedUsers).ForeignKeyConstraintName("CountryId").Cascade.Persist();
        }


    }
}