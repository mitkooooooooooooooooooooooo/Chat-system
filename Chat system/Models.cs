namespace ChatApp.Models
{
    public class MessageViewModel
    {
        public string? Sender { get; set; }
        public string? MessageText { get; set; }
    }

    public class ChatViewModel
    {
        public MessageViewModel CurrentMessage { get; set; } = new();
        public List<MessageViewModel> Messages { get; set; } = new();
    }
}
