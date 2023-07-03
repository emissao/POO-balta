using Emissao.NotificationContext;

namespace Emissao.ContentContext{
    public class article : Content
    {
            public IList<Notification> Notifications{ get; set; }   
            public void Add(Notification)
            {
                Notifications.Add(Notification);
            }  

}            public article(string title, string url)
                :base(title, url)
             {
                
             }
    }
}