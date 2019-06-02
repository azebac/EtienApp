using entities;
using FluentNHibernate.Mapping;

namespace daoNHibernate.mapping
{
    public class PreferenceMap : ClassMap<PreferenceEntity>
    {
        public PreferenceMap()
        {
            Table("Preference");

            Id(x => x.Id).GeneratedBy.Identity().Column("ID").UnsavedValue(0);
            Map(x => x.Name).Column("Name").Not.Nullable();
            HasManyToMany<UserEntity>(x => x.AssociatedUsers).Table("User_Preferences")
                .ParentKeyColumn("IdPreference").ChildKeyColumn("IdUser");
            
        }
    }
}