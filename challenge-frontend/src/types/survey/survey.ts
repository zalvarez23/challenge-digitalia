import { IQuestionSurvey } from "../question-survey/question-survey";

export interface ISurvey {
  id?: number;
  surveyTitle: string;
  surveyStatus: number;
  surveyDate?: string;
  surveyDetails?: IQuestionSurvey[];
}
