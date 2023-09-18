import { ApiSurveypository } from "../../repositories/survey/survey-impl";
import { ISurvey } from "../../types/survey/survey";
import { ISurveyRepository } from "../../types/survey/survey-repository";

export class SurveyServices implements ISurveyRepository {
  private apiSurveyRepository: ApiSurveypository;
  constructor() {
    this.apiSurveyRepository = new ApiSurveypository();
  }

  async getAll(): Promise<ISurvey[]> {
    return this.apiSurveyRepository.getAll();
  }
  async updateSurvey(iSurvey: ISurvey): Promise<void> {
    return this.apiSurveyRepository.updateSurvey(iSurvey);
  }
}
