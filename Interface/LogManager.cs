﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class LogManager : ILogger
    {

        public ILogger _logger;

        public LogManager(ILogger logger)
        {
            this._logger = logger;
        }

        public void WriteLog()
        {
            _logger.WriteLog();
        }
    }
}
