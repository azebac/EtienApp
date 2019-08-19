using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Threading.Tasks;
using log4net;
using entities;

namespace Commands.Users
{
    public class CreateUserCommand:AsyncCommand<UserEntity>
    {
        private UserEntity UserToRegister { get; set; }
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        public override UserEntity Param { get; set; }

        public CreateUserCommand(UserEntity userToRegister)
        {
            UserToRegister = userToRegister;
        }

        public override void Execute()
        {
            throw new System.NotImplementedException();
        }

        public override Task ExecuteAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}