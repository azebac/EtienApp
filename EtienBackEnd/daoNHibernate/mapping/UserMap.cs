using entities;
using enums;
using FluentNHibernate.Mapping;

namespace daoNHibernate.mapping
{
    public class UserMap : ClassMap<UserEntity>
    {
        public UserMap()
        {
            Table("User");
            Id(x => x.Id).GeneratedBy.Identity().Column("ID").UnsavedValue(0);
            Map(x => x.Name).Column("Name").Not.Nullable();
            Map(x => x.LastName).Column("LastName").Not.Nullable();
            Map(x => x.UserName).Column("UserName").Not.Nullable().Unique();
            Map(x => x.Password).Column("Password").Not.Nullable();
            Map(x => x.Email).Column("Email").Not.Nullable().Unique();
            Map(x => x.Cellphone).Column("Cellphone").Nullable();
            Map(x => x.IsAdmin).Column("IsAdmin").Not.Nullable().Default("0");
            Map(x => x.IsReseller).Column("IsReseller").Not.Nullable().Default("0");
            Map(x => x.Salt).Column("Salt").Default("0");
            Map(x => x.AppToken).Column("Token");
            Map(x => x.Gender).Column("Gender").CustomType<UserGenderType>().Not.Nullable().Default("1");
            Map(x => x.Status).Column("Status").CustomType<UserStatusType>().Not.Nullable().Default("1");

            References<CountryEntity>(x => x.Country).Column("CountryId");
            HasManyToMany<PreferenceEntity>(x=> x.SelectedPreferences).Table("User_Preferences")
                .ParentKeyColumn("IdUser").ChildKeyColumn("IdPreference");
        }
    }
}