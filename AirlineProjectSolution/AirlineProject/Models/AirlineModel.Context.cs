﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AirlineProject.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class dbAirlineReservationEntities : DbContext
    {
        public dbAirlineReservationEntities()
            : base("name=dbAirlineReservationEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tblFlight_Details> tblFlight_Details { get; set; }
        public virtual DbSet<tblFlight_Schedule> tblFlight_Schedule { get; set; }
        public virtual DbSet<tblPassenger_Details> tblPassenger_Details { get; set; }
        public virtual DbSet<tblSeat_Details> tblSeat_Details { get; set; }
        public virtual DbSet<tblTicket_Details> tblTicket_Details { get; set; }
        public virtual DbSet<tblUser> tblUsers { get; set; }
    
        public virtual int delete_flight(Nullable<int> fid)
        {
            var fidParameter = fid.HasValue ?
                new ObjectParameter("fid", fid) :
                new ObjectParameter("fid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("delete_flight", fidParameter);
        }
    
        public virtual int delete_schedule(Nullable<int> schedule_id)
        {
            var schedule_idParameter = schedule_id.HasValue ?
                new ObjectParameter("schedule_id", schedule_id) :
                new ObjectParameter("schedule_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("delete_schedule", schedule_idParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> seat_Details(Nullable<int> ticket_Id)
        {
            var ticket_IdParameter = ticket_Id.HasValue ?
                new ObjectParameter("Ticket_Id", ticket_Id) :
                new ObjectParameter("Ticket_Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("seat_Details", ticket_IdParameter);
        }
    
        public virtual ObjectResult<ticket_details_Result> ticket_details()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ticket_details_Result>("ticket_details");
        }
    
        public virtual ObjectResult<string> seat_numbers(Nullable<int> ticket_Id)
        {
            var ticket_IdParameter = ticket_Id.HasValue ?
                new ObjectParameter("Ticket_Id", ticket_Id) :
                new ObjectParameter("Ticket_Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("seat_numbers", ticket_IdParameter);
        }
    
        public virtual int cancel_tickets(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("cancel_tickets", idParameter);
        }
    }
}
