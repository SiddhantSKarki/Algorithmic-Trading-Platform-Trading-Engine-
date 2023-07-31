using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace TradingEnginer.Core {

    class TradingEnginerServer : BackgroundService, ITradingEnginerServer
    {
        private readonly ILogger<TradingEnginerServer> _logger;
        public TradingEnginerServer(ILogger<TradingEnginerServer> logger) {

            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested) {

            }
        }
    }

}