using TaskManager.Communication.Enums;

namespace TaskManager.Communication.Response;
public class ResponseTaskJson
{
    public int Id { get; set; }
    public String Name { get; set; } = string.Empty;
    public String Description { get; set; } = string.Empty;
    public Priority Priority { get; set; }
    public DateTime EndDate { get; set; }
    public Status Status { get; set; }
}
