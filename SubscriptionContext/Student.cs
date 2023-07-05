using System.Security.Cryptography.X509Certificates;
using Emissao.SharedContext;

namespace Emissao.SubscriptionContext
{
    public class Student : Base
    {
        public Student(Parameters)
        {
            Subscription = new List<Subscription>();
        }
        public string Name { get; set; }
        public string Email { get; set;}
        public user User { get; set; }
        public IList<Subscription> Subscriptions { get; set; }
        public void CreateSubscription(Subscription subscription)
        {
             if(IsPremium)
            {
                AddNotification(new NotificationContext.Notification ("Premium", "O aluno já tem uma assinatura ativa"));
                return;
                Subscription.AddNotification(subscription);
            }
        }
        public bool IsPremium => Subscription.Any( x => !x.IsInactive);
    }
}