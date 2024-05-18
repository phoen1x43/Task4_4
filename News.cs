using System;
using System.Collections.Generic;

public class News
{
    News = new List<NewsEntity>
    {
        new() {Text = "Трамп пообещал создать в США «Железный купол».", PublishDate = DateTime.Now.AddDays(-1) }
        new() {Text = "Участнику Евровидения Кляйну грозит суд из-за угрожающего жеста.", PublishDate = DateTime.Now}
    };

    public List<NewsEntity> News{get; set;}
}