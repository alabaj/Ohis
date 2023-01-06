﻿using Ohis.DataContext.Databases.Base;
using Ohis.DataContext.Databases.Interfaces;
using Ohis.Library.Domain;

namespace Ohis.DataContext.Databases.ReadRepositories;

public class ReadTicketRepository : ReadRepository<TicketEntity>, IReadTicketRepository
{
}
