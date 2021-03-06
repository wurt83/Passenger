﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Passenger.Core.Domain
{
    public class Driver
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Vehicle Vehicle { get; set; }
        public IEnumerable<Route> Routes { get; set; }
        public IEnumerable<DailyRoute> DailyRoutes { get; set; }

        public Driver(Guid userid, Vehicle vehicle, IEnumerable<Route> routes,IEnumerable<DailyRoute> dailyroutes)
        {
            Id = Guid.NewGuid();
            Vehicle = vehicle;
            Routes = routes;
            DailyRoutes = dailyroutes;
        }

    }
    



}
