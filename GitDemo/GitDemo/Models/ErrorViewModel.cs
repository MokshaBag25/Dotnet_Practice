namespace GitDemo.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }
        //random changes
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
