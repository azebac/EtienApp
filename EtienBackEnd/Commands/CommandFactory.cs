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

        public static SearchUserNicknameCommand GenerateSearchUserNicknameCommand(UserEntity userToSearch)
        {
            return new SearchUserNicknameCommand(userToSearch);
        }

        public static ValidateLoginCommand GenerateValidateLoginCommand(UserEntity userLogginIn, string jwtToken)
        {
            return new ValidateLoginCommand(userLogginIn, jwtToken);
        }

        public static GetAllUsersCommand GenerateGetAllUsersCommand()
        {
            return new GetAllUsersCommand();
        }

        public static GetUserByIdCommand GenerateGetUserByIdCommand(UserEntity userToSearch)
        {
            return new GetUserByIdCommand(userToSearch);
        }

        public static UpdateUserCommand GenerateUpdateUserCommand(UserEntity NewData)
        {
            return new UpdateUserCommand(NewData);
        }
    }
}