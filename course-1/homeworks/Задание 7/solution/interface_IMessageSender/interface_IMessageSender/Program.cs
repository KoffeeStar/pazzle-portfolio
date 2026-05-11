using static IMessageSender;

public interface IMessageSender
{
    void Send(string message);

    public class EmailSender : IMessageSender
    {
        public void Send(string message)
        {
            Console.WriteLine($"Отправка email: { message}");
        }
    }
    public class SmsSender : IMessageSender
    {
        public void Send(string message)
        {
            Console.WriteLine($"Отправка sms: {message}");
        }
    }
}

public class NotificationHub
{
    List<IMessageSender> senders = new List<IMessageSender>();
    Dictionary<string, int> n_sms_or_email = new Dictionary<string, int>();

    public void Register(IMessageSender sender)
    {
        senders.Add(sender);
    }

    public void SendAll(string message)
    {
        foreach (var sender in senders)
        {
            sender.Send(message);

            string sender_type = sender.GetType().Name;
            if (n_sms_or_email.ContainsKey(sender_type))
            {
                n_sms_or_email[sender_type]++;
            }
            else
            {
                n_sms_or_email[(sender_type)] = 1;
            }
        }
    }

    public Dictionary<string, int> GetStatus()
    {
        return n_sms_or_email;
    }
}

class Program
{
    static void Main()
    {
        IMessageSender[] senders =
        {
            new EmailSender(),
            new SmsSender()
        };

        foreach (var sender in senders)
        {
            sender.Send("Привет!");
        }

        var hub = new NotificationHub();
        hub.Register(new EmailSender());
        hub.Register(new SmsSender());

        hub.SendAll("Важное уведомление!");

        var stats = hub.GetStatus();
    }
}