using Example.Domain.Entities;

namespace Example.Domain.Service
{
    public class SurveyService : ISurveyService
    {
        private readonly IUnitOfWork _unitOfWork;

        public SurveyService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task CreateAsync(Survey entity)
        {

            await _unitOfWork.SurveyRepository.CreateAsync(entity);
        }

        public async Task<IEnumerable<Survey>> GetAllAsync()
        {
            return await _unitOfWork.SurveyRepository.GetAllAsync();
        }

        public async Task<Survey> GetByIdAsync(int id)
        {
            return await _unitOfWork.SurveyRepository.GetByIdAsync(id);
        }

        public async Task UpdateAsync(Survey entity)
        {
            await _unitOfWork.SurveyRepository.UpdateAsync(entity);
        }

    }
}