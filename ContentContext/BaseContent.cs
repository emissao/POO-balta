using Emissao.NotificationContext;

namespace Emissao.ContentContext
{
    public abstract class Base : Notifiable  
    {
        public Base()
        {
            Id = Guid.NewGuid ();
        }
        public Guid Id{ get; set; }
    }
}