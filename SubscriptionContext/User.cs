namespace Emissao.SubscriptionContext
{
    public class user : SharedContext.Base
    {
        public string UserName { get; set;}
        public string Password { get; set;}
    }
}