using System.Configuration.Assemblies;

namespace Emissao.NotificationContext
{
    public abstract class Notifiable
    {
    
        public List<Notification> Notifications { get; set; }
        public Notifiable()
        {
            Notification = new List<Notification>();    
        }

    public void AddNotification (Notification notification)
    {
        Notifications.Add (notification);
    }
    
    public void AddNotification(IEnumerable<Notification> notification)
    {
        notification.AddRange(notifications);
    }
    public bool IsInvalid => Notifications.Any();
    
        
    }
} 
