namespace Emissao.ContentContext
{
     public class Lecture : Base 
    {
        public int Ordem { get; set;}
        public string Title { get; set;}
        public int DourationInMinutes  { get; set; }
        public EContentLevel Level { get; set; }
    }
}