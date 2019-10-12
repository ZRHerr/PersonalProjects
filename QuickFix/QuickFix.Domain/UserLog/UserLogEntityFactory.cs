using QuickFix.Model;

namespace QuickFix.Domain
{
    public static class UserLogEntityFactory
    {
        public static UserLogEntity Create(UserLogModel userLogModel)
        {
            return new UserLogEntity(userLogModel.UserId, userLogModel.LogType);
        }
    }
}
