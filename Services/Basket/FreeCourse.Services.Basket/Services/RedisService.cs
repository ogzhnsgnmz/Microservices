using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeCourse.Services.Basket.Services
{
    public class RedisService
    {
        private readonly string _Host;
        private readonly string _port;

        private ConnectionMultiplexer _connectionMultiplexer;

        public RedisService(string host, string port)
        {
            _Host = host;
            _port = port;
        }

        public void Connect() => _connectionMultiplexer = ConnectionMultiplexer.Connect($"{_Host}:{_port}");

        public IDatabase GetDb(int db=1) => _connectionMultiplexer.GetDatabase(db);
    }
}
