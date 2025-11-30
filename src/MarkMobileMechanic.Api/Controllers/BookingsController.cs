using MarkMobileMechanic.Core.DTOs;
using MarkMobileMechanic.Core.Interfaces;
using MarkMobileMechanic.Infrastructure;
using MarkMobileMechanic.Infrastructure.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MarkMobileMechanic.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BookingsController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    private readonly IBookingConflictDetector _conflictDetector;

    public BookingsController(ApplicationDbContext context, IBookingConflictDetector conflictDetector)
    {
        _context = context;
        _conflictDetector = conflictDetector;
    }

    [HttpGet]
    public async Task<IEnumerable<BookingDto>> GetAsync()
    {
        var bookings = await _context.Bookings.AsNoTracking().ToListAsync();
        return bookings.Select(ToDto);
    }

    [HttpPost]
    [Authorize(Policy = "RequireTechnician")]
    public async Task<ActionResult<BookingDto>> CreateAsync([FromBody] CreateBookingDto request)
    {
        var proposed = new BookingDto
        {
            Id = Guid.NewGuid(),
            CustomerId = request.CustomerId,
            TechnicianId = request.TechnicianId,
            StartTime = request.StartTime,
            EndTime = request.EndTime,
            Status = "Pending"
        };

        var existing = await _context.Bookings
            .Where(b => b.TechnicianId == request.TechnicianId)
            .Select(b => ToDto(b))
            .ToListAsync();

        if (_conflictDetector.HasConflict(existing, proposed))
        {
            return Conflict(new { message = "Technician already booked for that time range." });
        }

        var entity = new Booking
        {
            Id = proposed.Id,
            CustomerId = proposed.CustomerId,
            TechnicianId = proposed.TechnicianId,
            StartTime = proposed.StartTime,
            EndTime = proposed.EndTime,
            Status = proposed.Status
        };

        _context.Bookings.Add(entity);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetAsync), new { id = entity.Id }, ToDto(entity));
    }

    private static BookingDto ToDto(Booking booking) => new()
    {
        Id = booking.Id,
        CustomerId = booking.CustomerId,
        TechnicianId = booking.TechnicianId,
        StartTime = booking.StartTime,
        EndTime = booking.EndTime,
        Status = booking.Status
    };
}
