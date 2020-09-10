using System.Threading.Tasks;

namespace HelensPieShop.Models
{
    public interface IFeedbackRepository
    {
        Task AddFeedback(Infrastructure.Feedback feedback);
    }
}