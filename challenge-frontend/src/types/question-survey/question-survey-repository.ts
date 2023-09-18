import { IQuestionSurvey } from "./question-survey";

export interface IQuestionsSurveyRepository {
  getAllById(id: string): Promise<IQuestionSurvey[]>;
}
