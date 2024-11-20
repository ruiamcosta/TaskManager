using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Communication.Response;

namespace TaskManager.Application.UseCases.Tasks.GetById;
public class GetTaskByIdUseCase
{
    public ResponseTaskJson Execute(int id)
    {
        return new ResponseTaskJson 
        { 
            Id = id,
            Name = "Go for a run",
            Description = "Do a lap around the football stadium",
            EndDate = new DateTime(year: 2024, month: 12, day: 12),
            Priority = Communication.Enums.Priority.Medium,
            Status = Communication.Enums.Status.Waiting,
        };
    }
}
