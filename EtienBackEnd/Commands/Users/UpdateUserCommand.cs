using daoNHibernate;
using entities;
using interfaces;

namespace Commands.Users
{
    public class UpdateUserCommand:Command<UserEntity>
    {
        public override UserEntity Param { get; set; }
        public UserEntity NewData { get; set; }

        public UpdateUserCommand(UserEntity newData)
        {
            NewData = newData;
        }

        public override void Execute()
        {
            IDaoUserEntity dao = DaoNHbiernateFactory.FabricateUserEntityDao();
            Param = dao.Edit(NewData);
        }
    }
}