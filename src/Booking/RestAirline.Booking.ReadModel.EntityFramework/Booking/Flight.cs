﻿using System;
using System.ComponentModel.DataAnnotations;

namespace RestAirline.Booking.ReadModel.EntityFramework.Booking
{
    public class Flight
    {
        [Key]
        public Guid Id { get; set; }

        public string FlightKey { get; set; }

        public string Number { get; set; }

        public DateTime DepartureDate { get; set; }

        public string DepartureStation { get; set; }

        public DateTime ArriveDate { get; set; }

        public string ArriveStation { get; set; }

        public decimal Price { get; set; }

        public Aircraft Aircraft { get; set; }
        
        public Journey Journey { get; set; }
        
        public Guid JourneyId { get; set; }
    }

    public static class FlightMapper
    {
        public static Flight ToReadModel(this Domain.Booking.Trip.Flight flight)
        {
            var model = new Flight
            {
                Id = Guid.NewGuid(),
                FlightKey = flight.FlightKey,
                Aircraft = (Aircraft) flight.Aircraft,
                Number = flight.Number,
                Price = flight.Price,
                ArriveDate = flight.ArriveDate,
                ArriveStation = flight.ArriveStation,
                DepartureDate = flight.DepartureDate,
                DepartureStation = flight.DepartureStation
            };

            return model;
        }
    }

    public enum Aircraft
    {
        A320,
        A380,
        Boeing707,
        Boeing717,
        Boeing737
    }
}