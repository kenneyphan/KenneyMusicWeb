using System.ComponentModel.DataAnnotations;

public class Email
{
    [Required]
    [EmailAddress]
    public string email { get; set; }
    public string senderName { get; set; }
    public string subjectEmail { get; set; }
    public string bodyEmail { get; set; }
}