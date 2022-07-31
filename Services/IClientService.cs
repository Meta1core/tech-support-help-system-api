﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TechSupportHelpSystem.Models;

namespace TechSupportHelpSystem.Services
{
    interface IClientService
    {
        List<Client> GetClients();
        Client GetClient(int id_Client);
        Client FindClientByPrefix(string prefix);
        DbContextOptions GetClientOptions(Client client);
    }
}
