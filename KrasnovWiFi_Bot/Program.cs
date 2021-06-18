using System;
using System.IO;
using Telegram.Bot;

namespace TelegramBot
{
    class Program
    {
        static void Main(string[] args)
        {

            TelegramBotClient bot = new TelegramBotClient("1863063161:AAHJIZjhYb_U3prsRfgF1KCDse4aub0lb20");

            bot.OnMessage += (s, arg) =>
            {
                Console.WriteLine($"{arg.Message.Chat.FirstName}: {arg.Message.Text}");
                bot.SendTextMessageAsync(arg.Message.Chat.Id, $"Бот говорит: {arg.Message.Text}");
            };

            bot.StartReceiving();

            Console.ReadKey();
        }
    }
}