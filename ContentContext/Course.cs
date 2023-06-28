namespace Emissao.ContentContext{
    public class Course : Content
    {
        public Course(string title, string url)
            : base (title, url) 
        {
            Modules = new IList<Module>();
        }
        public string Tag { get; set; }
        public IList<Module> Modules  { get; set; } = 0;
    }
    
   
    
}