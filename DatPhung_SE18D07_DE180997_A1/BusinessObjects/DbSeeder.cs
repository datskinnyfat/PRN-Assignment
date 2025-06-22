using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace BusinessObjects
{
    public static class DbSeeder
    {
        public static void Seed(HotelDbContext context)
        {
            context.Database.EnsureCreated();

            // Seed RoomTypes if empty
            if (!context.RoomTypes.Any())
            {
                context.RoomTypes.AddRange(
                    new RoomType
                    {
                        RoomTypeName = "Standard",
                        TypeDescription = "Standard room with basic amenities",
                        TypeNote = "Suitable for 1-2 persons"
                    },
                    new RoomType
                    {
                        RoomTypeName = "Deluxe",
                        TypeDescription = "Deluxe room with premium amenities",
                        TypeNote = "Suitable for 2-3 persons"
                    },
                    new RoomType
                    {
                        RoomTypeName = "Suite",
                        TypeDescription = "Luxurious suite with separate living area",
                        TypeNote = "Suitable for 2-4 persons"
                    }
                );
                context.SaveChanges();
            }

            // Seed RoomInformations if empty
            if (!context.RoomInformations.Any())
            {
                // Get room types from database to use their IDs
                var standardRoomType = context.RoomTypes.FirstOrDefault(rt => rt.RoomTypeName == "Standard");
                var deluxeRoomType = context.RoomTypes.FirstOrDefault(rt => rt.RoomTypeName == "Deluxe");
                var suiteRoomType = context.RoomTypes.FirstOrDefault(rt => rt.RoomTypeName == "Suite");

                if (standardRoomType != null && deluxeRoomType != null && suiteRoomType != null)
                {
                    context.RoomInformations.AddRange(
                        new RoomInformation
                        {
                            RoomNumber = "101",
                            RoomDescription = "Standard room with city view",
                            RoomMaxCapacity = 2,
                            RoomStatus = 1, // Active
                            RoomPricePerDate = 100.00M,
                            RoomTypeID = standardRoomType.RoomTypeID
                        },
                        new RoomInformation
                        {
                            RoomNumber = "201",
                            RoomDescription = "Deluxe room with ocean view",
                            RoomMaxCapacity = 3,
                            RoomStatus = 1, // Active
                            RoomPricePerDate = 150.00M,
                            RoomTypeID = deluxeRoomType.RoomTypeID
                        },
                        new RoomInformation
                        {
                            RoomNumber = "301",
                            RoomDescription = "Suite with balcony",
                            RoomMaxCapacity = 4,
                            RoomStatus = 1, // Active
                            RoomPricePerDate = 200.00M,
                            RoomTypeID = suiteRoomType.RoomTypeID
                        }
                    );
                    context.SaveChanges();
                }
            }

            // Seed Customers if empty
            if (!context.Customers.Any())
            {
                context.Customers.AddRange(
                    new Customer
                    {
                        CustomerFullName = "John Doe",
                        Telephone = "1234567890",
                        EmailAddress = "john.doe@example.com",
                        CustomerBirthday = new DateTime(1990, 1, 1),
                        CustomerStatus = 1, // Active
                        Password = "password123"
                    },
                    new Customer
                    {
                        CustomerFullName = "Jane Smith",
                        Telephone = "0987654321",
                        EmailAddress = "jane.smith@example.com",
                        CustomerBirthday = new DateTime(1992, 5, 15),
                        CustomerStatus = 1, // Active
                        Password = "password456"
                    },
                    new Customer
                    {
                        CustomerFullName = "Michael Johnson",
                        Telephone = "5551234567",
                        EmailAddress = "michael.johnson@email.com",
                        CustomerBirthday = new DateTime(1985, 8, 22),
                        CustomerStatus = 1,
                        Password = "mike2024"
                    },
                    new Customer
                    {
                        CustomerFullName = "Sarah Williams",
                        Telephone = "5559876543",
                        EmailAddress = "sarah.williams@email.com",
                        CustomerBirthday = new DateTime(1995, 3, 10),
                        CustomerStatus = 1,
                        Password = "sarah123"
                    },
                    new Customer
                    {
                        CustomerFullName = "David Brown",
                        Telephone = "5554567890",
                        EmailAddress = "david.brown@email.com",
                        CustomerBirthday = new DateTime(1988, 12, 5),
                        CustomerStatus = 1,
                        Password = "david456"
                    },
                    new Customer
                    {
                        CustomerFullName = "Emily Davis",
                        Telephone = "5557890123",
                        EmailAddress = "emily.davis@email.com",
                        CustomerBirthday = new DateTime(1993, 7, 18),
                        CustomerStatus = 1,
                        Password = "emily789"
                    },
                    new Customer
                    {
                        CustomerFullName = "Robert Wilson",
                        Telephone = "5553210987",
                        EmailAddress = "robert.wilson@email.com",
                        CustomerBirthday = new DateTime(1982, 4, 30),
                        CustomerStatus = 1,
                        Password = "rob2024"
                    },
                    new Customer
                    {
                        CustomerFullName = "Lisa Anderson",
                        Telephone = "5556543210",
                        EmailAddress = "lisa.anderson@email.com",
                        CustomerBirthday = new DateTime(1991, 11, 12),
                        CustomerStatus = 1,
                        Password = "lisa321"
                    },
                    new Customer
                    {
                        CustomerFullName = "James Taylor",
                        Telephone = "5558765432",
                        EmailAddress = "james.taylor@email.com",
                        CustomerBirthday = new DateTime(1987, 6, 25),
                        CustomerStatus = 1,
                        Password = "james654"
                    },
                    new Customer
                    {
                        CustomerFullName = "Amanda Martinez",
                        Telephone = "5552345678",
                        EmailAddress = "amanda.martinez@email.com",
                        CustomerBirthday = new DateTime(1994, 9, 8),
                        CustomerStatus = 1,
                        Password = "amanda987"
                    },
                    new Customer
                    {
                        CustomerFullName = "Christopher Garcia",
                        Telephone = "5553456789",
                        EmailAddress = "chris.garcia@email.com",
                        CustomerBirthday = new DateTime(1989, 2, 14),
                        CustomerStatus = 1,
                        Password = "chris456"
                    },
                    new Customer
                    {
                        CustomerFullName = "Jessica Rodriguez",
                        Telephone = "5555678901",
                        EmailAddress = "jessica.rodriguez@email.com",
                        CustomerBirthday = new DateTime(1996, 1, 20),
                        CustomerStatus = 1,
                        Password = "jessica123"
                    },
                    new Customer
                    {
                        CustomerFullName = "Daniel Lee",
                        Telephone = "5556789012",
                        EmailAddress = "daniel.lee@email.com",
                        CustomerBirthday = new DateTime(1986, 10, 3),
                        CustomerStatus = 1,
                        Password = "daniel789"
                    },
                    new Customer
                    {
                        CustomerFullName = "Nicole White",
                        Telephone = "5557890123",
                        EmailAddress = "nicole.white@email.com",
                        CustomerBirthday = new DateTime(1990, 5, 17),
                        CustomerStatus = 1,
                        Password = "nicole321"
                    },
                    new Customer
                    {
                        CustomerFullName = "Kevin Thompson",
                        Telephone = "5558901234",
                        EmailAddress = "kevin.thompson@email.com",
                        CustomerBirthday = new DateTime(1984, 12, 28),
                        CustomerStatus = 1,
                        Password = "kevin654"
                    },
                    new Customer
                    {
                        CustomerFullName = "Rachel Clark",
                        Telephone = "5559012345",
                        EmailAddress = "rachel.clark@email.com",
                        CustomerBirthday = new DateTime(1992, 8, 11),
                        CustomerStatus = 1,
                        Password = "rachel987"
                    },
                    new Customer
                    {
                        CustomerFullName = "Steven Lewis",
                        Telephone = "5550123456",
                        EmailAddress = "steven.lewis@email.com",
                        CustomerBirthday = new DateTime(1983, 3, 7),
                        CustomerStatus = 1,
                        Password = "steven123"
                    }
                );
                context.SaveChanges();
            }

            // Seed BookingReservations if empty
            if (!context.BookingReservations.Any())
            {
                // Get customers and rooms from database to use their IDs
                var customer1 = context.Customers.FirstOrDefault(c => c.EmailAddress == "john.doe@example.com");
                var customer2 = context.Customers.FirstOrDefault(c => c.EmailAddress == "jane.smith@example.com");
                var room1 = context.RoomInformations.FirstOrDefault(r => r.RoomNumber == "101");
                var room2 = context.RoomInformations.FirstOrDefault(r => r.RoomNumber == "201");

                if (customer1 != null && customer2 != null && room1 != null && room2 != null)
                {
                    DateTime now = DateTime.Now;
                    context.BookingReservations.AddRange(
                        new BookingReservation
                        {
                            CustomerID = customer1.CustomerID,
                            RoomID = room1.RoomID,
                            BookingDate = now.AddDays(-10),
                            StartDate = now.AddDays(-5),
                            EndDate = now.AddDays(-3),
                            BookingDuration = 2,
                            TotalPrice = 200.00M,
                            BookingStatus = 2, // Completed
                            BookingType = 1 // Online
                        },
                        new BookingReservation
                        {
                            CustomerID = customer2.CustomerID,
                            RoomID = room2.RoomID,
                            BookingDate = now.AddDays(-3),
                            StartDate = now.AddDays(2),
                            EndDate = now.AddDays(5),
                            BookingDuration = 3,
                            TotalPrice = 450.00M,
                            BookingStatus = 1, // Active
                            BookingType = 1 // Online
                        }
                    );
                    context.SaveChanges();
                }
            }
        }
    }
} 