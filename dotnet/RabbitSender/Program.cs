// See https://aka.ms/new-console-template for more information

using RabbitMQ.Client;
using System.Text;

//ConnectionFactory factory = new();

var factory = new ConnectionFactory()
{
    HostName = "localhost",
    UserName = "guest",
    Password = "guest",
};

factory.ClientProvidedName = "Rabbit Sender Application";

IConnection cnn = factory.CreateConnection();

IModel channel = cnn.CreateModel();
