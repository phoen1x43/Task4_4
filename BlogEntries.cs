using System;
using System.Collections.Generic;

public class BlogEntries
{
    BlogsEntities = new List<BlogsEntity>()
    {
        new BlogsEntity()
        {
            Article = "Тик Ток снова работает?"
            Text = "Эта новость шокировала всех россиян."
        }
    };
    public List<BlogsEntity> BlogsEntities{get; set;}
}
