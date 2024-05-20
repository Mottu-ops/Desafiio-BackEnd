﻿namespace MotorcycleRental.MailServiceConsumer.Config
{
    public class RabbitMqSettings
    {
        public string Exchange { get; set; }
        public string Queue { get; set; }
        public string RoutingKey { get; set; }
        public string TypeExchange { get; set; }
        public ushort PrefetchCount { get; set; }
    }
}
