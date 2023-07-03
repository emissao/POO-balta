using Emissao.ContentContext;

namespace Emissao
{
        class program
        {
            public static void Main(string[] args)
            {
                var articles = new List<Article>();
                Articles.Add(new Article ("Artigo sobre OOP", "Orientacao-objetos"));
                Articles.Add(new Article ("Artigo sobre C#", "Charp"));
                Articles.Add(new Article ("Artigo sobre .NET", "dotnet"));
                foreach(var article ub articles)
                {
                    Console.WriteLine(article.Id);
                    Console.WriteLine(article.Title);
                    Console.WriteLine(article.Url);
                }
              
                var courseOOP = new Course("Fundamento OOP", "Fundamentos-oop");
                var courseCsharp = new Course("Fundamento C#", "Fundamentos-csharp");
                var courseAspNet = new Course("Fundamento ASP.NET", "Fundamentos-ASPNET");
                courses.Add(courseOOP);
                courses.Add(courseCsharp);
                courses.Add(courseAspNet);  
                if(courseAspNet.IsInvalid)
                courseAspNet.AddNotification(new Notification);
                var careers = new IList<Career>();
                var CareerDotnet = new Career("Especialista .NET", "especialista dotnet");     
                var CareerItem = new CareerItem(1,"Comece por aqui", "", courseAspNet);
                var CareerItem2 = new CareerItem(2,"Aprenda dotnet", "", courseCsharp);
                var CareerItem2 = new CareerItem(3,"oop", "", courseOOP);
                careers.Items.Add(careerItem);
                careers.Items.Add(CareerItem2);
                careers.Items.Add(CareerItem3); 
                careers.Add(CareerDotnet);
                foreach (var career in careers.OrderByDescending(c => c.Id))
                { 
                    Console.WriteLine(career.Title);
                    foreach(var item in career.Items)
                    {
                        Console.WriteLine($"{item.Order} {item.Title}");
                        Console.WriteLine(item.Course?.Title);
                        Console.WriteLine(item.Course?.Level);
                        
                        foreach(var notification in item.Notifications)
                        {
                            Console.WriteLine(${notification.Property} - {notification.Menssage});
                        }
                    }
                }
            }

        }
}
   