import { ISurvey } from "./survey";

export interface ISurveyRepository {
  getAll(): Promise<ISurvey[]>;
  updateSurvey(iSurvey: ISurvey): Promise<void>;
}
