import { ApiQuestionSurveyRepository } from "../../repositories/questions-survey/questions-survey-impl";
import { IQuestionSurvey } from "../../types/question-survey/question-survey";
import { IQuestionsSurveyRepository } from "../../types/question-survey/question-survey-repository";

export class QuestionSurveyServices implements IQuestionsSurveyRepository {
  private apiQuestionSurveyRepository: ApiQuestionSurveyRepository;
  constructor() {
    this.apiQuestionSurveyRepository = new ApiQuestionSurveyRepository();
  }

  async getAllById(id: string): Promise<IQuestionSurvey[]> {
    return this.apiQuestionSurveyRepository.getAllById(id);
  }
}
