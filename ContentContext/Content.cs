namespace Emissao.ContentContext
    {
        public abstract class Content 
        {
            public Content (string Title, string Url)
            {
                Id = Guid.NewGuid ();
                title = Title;
                Url = Url;
            }
            public Guid Id { get; set; }
            public string Title { get; set; }
            public  string  Url { get; set; }
        }
    }
