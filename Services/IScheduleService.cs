using app.DTO;

namespace app.Services
{
    public interface IScheduleService
    {
        Task<List<ScheduleByDateDto>> GetScheduleForGroup(string groupName, DateTime startDate, DateTime endDate);
    }
}
