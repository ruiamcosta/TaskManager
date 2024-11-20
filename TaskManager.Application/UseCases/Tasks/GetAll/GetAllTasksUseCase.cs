using TaskManager.Communication.Response;

namespace TaskManager.Application.UseCases.Tasks.GetAll;
public class GetAllTasksUseCase
{
    public ResponseAllTasksJson Execute()
    {
        return new ResponseAllTasksJson
        {
            Tasks = new List<ResponseShortTaskJson>
            {
                new ResponseShortTaskJson
                {
                    Id = 1,
                    Name = "Cycling",
                    Description = "Go for a 40km ride",
                },
                new ResponseShortTaskJson
                {
                    Id = 1,
                    Name = "Running",
                    Description = "Go for a 5km ride",
                }
            }
        };
           
    }
}
