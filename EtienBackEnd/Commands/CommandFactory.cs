using Commands.Users;
using entities;

namespace Commands
{
    public class CommandFactory
    {
        public static CreateUserCommand GenerateCreateUserCommand(UserEntity userToRegister)
        {
            return new CreateUserCommand(userToRegister);
        }
    }
}