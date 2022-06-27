namespace BlazorAppTest.Dto;

public class BalloonDto
{
    public Guid Id { get; set; }
    public DateTime? CreationDate { get; set; }
    public string Name { get; set; } = "";
    public string QRCod { get; set; } = "";
    public bool IsSelected { get; set; }
    public bool IsPrinted { get; set; }
    public bool IsFree { get; set; } = true;
    public bool IsRemove { get; set; }
}
