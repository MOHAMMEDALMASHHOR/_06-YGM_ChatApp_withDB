namespace ChatEntities;

public class Chats
{
    public int Id { get; set; }
    public string? UserName { get; set; }
    public string? Message { get; set; }
    public DateTime SendDate { get; set; }
}
