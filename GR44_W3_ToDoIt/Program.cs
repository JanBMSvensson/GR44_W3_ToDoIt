[assembly: InternalsVisibleTo("UnitTests")] // Make sure that any internal classes can be tested as well.

PeopleService PS = new();
ToDoService TDS = new();

Person P1 = PS.CreateNewPerson("Jan", "Jansson");
Person P2 = PS.CreateNewPerson("Sven", "Svensson");
Person P3 = PS.CreateNewPerson("Bengt", "Bengtsson");

ToDo td1 = TDS.CreateNewToDoItem("Talk to Sven about that thing");
ToDo td2 = TDS.CreateNewToDoItem("Buy some milk");
ToDo td3 = TDS.CreateNewToDoItem("Fix that stuff");

td1.Assignee = P1;
td1.Done = true;

td2.Assignee = P2;

PrintResults("FindAllToDoItems", TDS.FindAll());
PrintResults("FindUnassignedTodoItems", TDS.FindUnassignedTodoItems());
foreach (Person P in PS.FindAll())
    PrintResults($"FindByAssignee {P.FirstName}", TDS.FindByAssignee(P));
PrintResults("FindByDoneStatus False", TDS.FindByDoneStatus(false));
PrintResults("FindByDoneStatus True", TDS.FindByDoneStatus(true));

PS.FindById(-1);

void PrintResults(string text, ToDo[] toDoItems)
{
    WriteLine(text);

    if (toDoItems?.Length > 0)
        foreach (ToDo toDo in toDoItems)
            WriteLine(
                  toDo.ID.ToString().PadLeft(3) 
                + " "
                + toDo.Description.PadRight(50) 
                + (toDo.Assignee?.FirstName ?? "[not assigned]").PadRight(25) 
                + (toDo.Done ? "Done" : "Not done")
                );
    else
        WriteLine("".PadLeft(4) + "[empty]");

    WriteLine();
}

