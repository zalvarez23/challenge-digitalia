using Example.Domain.Entities;

namespace Example.Domain.Service
{
    public class SurveyDetailService : ISurveyDetailService
    {
        private readonly IUnitOfWork _unitOfWork;

        public SurveyDetailService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task CreateAsync(SurveyDetail entity)
        {
            await _unitOfWork.SurveyDetailRepository.CreateAsync(entity);
        }

        public async Task<IEnumerable<SurveyDetail>> GetAllAsync()
        {
            return await _unitOfWork.SurveyDetailRepository.GetAllAsync();
        }

        public async Task<IEnumerable<SurveyDetail>> GetAllByIdAsync(int id)
        {
            return await _unitOfWork.SurveyDetailRepository.GetAllByIdAsync(id);
        }

        public async Task UpdateAsync(SurveyDetail entity)
        {
            await _unitOfWork.SurveyDetailRepository.UpdateAsync(entity);
        }
    }
}