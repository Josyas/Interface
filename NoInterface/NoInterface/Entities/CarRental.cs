﻿using System;
namespace NoInterface.Entities
{
    class CarRental
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public Vehicle Vehicle { get; set; }
        public Invoice Invoice { get; set; }

        public CarRental(DateTime Start, DateTime Finish, Vehicle Vehicle)
        {
            this.Start = Start;
            this.Finish = Finish;
            this.Vehicle = Vehicle;
        }

    }
}
