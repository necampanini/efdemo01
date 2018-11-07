using EFDemo01.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EFDemo01.DataAccess
{
    public class EventsDbContext : DbContext
    {
        //need to have EntityFramework nuget packet installed

        //these 'dbsets' are what map C# classes to database tables

        //the convention is: the entity is singular 'event'
        //the table is plural: 'events' - EF relies on these names to match in order to
        //'speak' with the database easily

        //take care to make sure both data types and names match exactly
        //between the db table and the C# entity

        public DbSet<Event> Events { get; set; }
    }
}