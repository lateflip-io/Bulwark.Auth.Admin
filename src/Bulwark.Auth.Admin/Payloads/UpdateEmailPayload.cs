namespace Bulwark.Auth.Admin.Payloads;

public class UpdateEmailPayload
{
    public string Email { get; set; }
    public string NewEmail { get; set; }
    
    public UpdateEmailPayload()
    {
        Email = string.Empty;
        NewEmail = string.Empty;
    }
}