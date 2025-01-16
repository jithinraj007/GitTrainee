namespace GitTrainee.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }
        public string? UserName { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
