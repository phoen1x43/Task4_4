using System.Collections.Generic;

public class MainWindowNewModel
{
    MainMenuEntity = new()
    {
        MainTopicsList = new List<string> {"Main topic 1","Main topic 2", "Main topic 3"};
    }
     public MainEntity MainMenuEntity {get; set;}
}