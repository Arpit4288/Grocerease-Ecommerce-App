using MVC_Assignment.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MVC_Assignment.Interfaces
{
    public interface IEventRepository
    {

        Task<int> AddBookReadingEvent(BookReadingEventModel bookReadingEventModel);

        Task<BookReadingEventModel> FindById(int? id);

        Task<List<CommentModel>> GetAllComments();

        Task<BookReadingEventModel> GetBookReadingEventModelById(int? id);


        Task<List<BookReadingEventModel>> GetBookReadingEventModelsCreatedByUser(string userId);

        Task<List<BookReadingEventModel>> GetAllBookReadingEventModels();

        Task UpdateBookReadingEventModelAndSave(BookReadingEventModel bookReadingEventModel);


        Task DeleteBookReadingEventModelAndSave(BookReadingEventModel bookReadingEventModel);

        Task<bool> BookReadingEventExists(int id);

        Task AddComment(CommentModel newComment);
    }

}
