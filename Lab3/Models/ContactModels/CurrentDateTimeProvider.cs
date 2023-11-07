﻿namespace Lab3.Models.ContactModels
{
    public class CurrentDateTimeProvider : IDateTimeProvider
    {
        public DateTime Now()
        {
            return DateTime.Now;
        }
    }
}
