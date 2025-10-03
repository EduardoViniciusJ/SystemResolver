using SystemResolver.Domain.Enums;

namespace SystemResolver.Domain.Entities
{
    public class Ticket
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty ;
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedDate { get; set; } = DateTime.UtcNow;
        public User ?Author { get; set; } 
        public User ?Technician { get; set; }   
        public TicketStatus Status { get; set; }

        
        private Ticket() { }
        public Ticket(Guid id, string title, string description, DateTime createdDate, DateTime updatedDate, User? author, User? technician, TicketStatus status)
        {
            Id = id;
            Title = title;
            Description = description;
            CreatedDate = createdDate;
            UpdatedDate = updatedDate;
            Author = author;
            Technician = technician;
            Status = status;
        }

        public void AddTechnician(User techinicianId)
        {
            Technician = techinicianId;
            Status = TicketStatus.InProgress;
            UpdatedDate = DateTime.UtcNow;
        }
    }
}
