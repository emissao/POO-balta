using System.Runtime.Intrinsics.X86;
using Emissao.SharedContext;

namespace Emissao.SubscriptionContext 
{
    public class Subscription : Base
    {
        public Plan Plan { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsInactive => EndDate
        <= DateTime.Now;
    }
}