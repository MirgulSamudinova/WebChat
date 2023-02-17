﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace WebChat.SignalR.hubs
{
    public class ChatHub : Hub
    {
        public void Send(string name, string message, string imgURL)
        {
            Clients.All.addNewMessageToPage(name, message, imgURL);
        }
    }
}