﻿using Ohis.DataContext.Databases.Base;
using Ohis.Library.Domain;

namespace Ohis.DataContext.Databases.Interfaces;

public interface IReadTicketRepository : IReadRepository<TicketEntity>
{
}