using TaskManager.Communication.Enums;

namespace TaskManager.Communication.Response;
public class ResponseRegisterTaskJson
{
    public int Id { get; set; }
    public String Name { get; set; } = string.Empty;
}
