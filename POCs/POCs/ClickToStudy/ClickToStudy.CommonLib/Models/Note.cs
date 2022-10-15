using System;

namespace ClickToStudy.CommonLib.Models;

public class Note
{
    public int Id { get; set; }
    public string Title { get; set; } = String.Empty;
    public string Content { get; set; } = String.Empty;
}
