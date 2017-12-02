﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elton.Aqara
{
    public class CtrlNeutral2Device : AqaraDevice
    {
        public CtrlNeutral2Device(AqaraConnector connector, Guid id, AqaraGateway gateway, string sid)
            : base(connector, id, gateway, sid)
        {
        }
        
        public void TurnOn()
        {
            var dic = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            dic.Add("channel_0", "on");
            dic.Add("channel_1", "on");
            connector.SendWriteCommand(this, dic);
        }

        public void TurnOff()
        {
            var dic = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            dic.Add("channel_0", "off");
            dic.Add("channel_1", "off");
            connector.SendWriteCommand(this, dic);
        }
    }
}
