﻿using JT809.DotNetty.Core;
using JT809.DotNetty.Core.Configurations;
using JT809.DotNetty.Core.Handlers;
using JT809.DotNetty.Core.Interfaces;
using JT809.DotNetty.Core.Clients;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace JT809.DotNetty.Core.Internal
{
    /// <summary>
    /// 下级平台
    /// 默认消息处理业务实现
    /// </summary>
    internal class JT809InferiorMsgIdReceiveDefaultHandler : JT809InferiorMsgIdReceiveHandlerBase
    {
        public JT809InferiorMsgIdReceiveDefaultHandler(IJT809ManualResetEvent jT809ManualResetEvent, ILoggerFactory loggerFactory) : base(jT809ManualResetEvent, loggerFactory)
        {
        }
    }
}
