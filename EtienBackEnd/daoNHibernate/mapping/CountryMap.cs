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
            Map(x => x.Name).Column("name").Not.Nullable();
            Map(x => x.ISO).Column("iso").Not.Nullable();
            Map(x => x.NiceName).Column("nicename").Not.Nullable();
            Map(x => x.ISO3).Column("iso3");
            Map(x => x.NumCode).Column("numcode");
            Map(x => x.PhoneCode).Column("phonecode").Not.Nullable();
            HasMany<UserEntity>(x => x.AssociatedUsers).ForeignKeyConstraintName("CountryId").Cascade.Persist();
        }


    }
}