namespace Calculator.Shared
{
    public class Notification
    {
        public static void ShowMessage(MessageType messageType, object x, object y)
        {
            Notification n = new();
            string messageText = n.GetMessage(messageType, x, y);
            Console.WriteLine(messageText);
        }
        private string GetMessage(MessageType messageType, object x, object y) =>
            messageType switch
            {
                MessageType.Welcome => $"Willkommen in deinem Taschenrechner!",
                MessageType.Quit => "Möchtest du das Programm beenden?\n1: Ja\n2: Nein",
                MessageType.UnknownInput => "Unbekannte Eingabe. Bitte versuche es nochmal.",
                _ => "Unbekannte Eingabe.",
            };
    }
}