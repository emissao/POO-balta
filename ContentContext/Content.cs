namespace Emissao.ContentContext
    {
        public abstract class Content : Base
        {
            public Content (string Title, string Url)
            {
                
                title = Title;
                Url = Url;
            }
            
            public string Title { get; set; }
            public  string  Url { get; set; }
        }
    }
