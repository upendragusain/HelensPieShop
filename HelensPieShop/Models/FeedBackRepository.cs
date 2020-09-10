using HelensPieShop.Infrastructure;
using System.Threading.Tasks;

namespace HelensPieShop.Models
{
    public class FeedBackRepository : IFeedbackRepository
    {
        private readonly PieContext _pieContext;

        public FeedBackRepository(PieContext pieContext)
        {
            _pieContext = pieContext;
        }
        public async Task AddFeedback(Infrastructure.Feedback feedback)
        {
            _pieContext.Feedbacks.Add(feedback);
            await _pieContext.SaveChangesAsync();
        }
    }
}