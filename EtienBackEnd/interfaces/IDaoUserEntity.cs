using entities;

namespace interfaces
{
    public interface IDaoUserEntity: IBaseDao<UserEntity>
    {
        UserEntity searchUserByNickname(UserEntity user);
    }
}