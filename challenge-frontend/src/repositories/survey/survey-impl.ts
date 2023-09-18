import { ISurvey } from "../../types/survey/survey";
import { ISurveyRepository } from "../../types/survey/survey-repository";
import { ApiClient } from "../../utils/ApiClient";
import { AxiosResponse } from "axios";

export class ApiSurveypository implements ISurveyRepository {
  private apiClient: ApiClient;
  constructor() {
    this.apiClient = ApiClient.getInstance();
  }

  async getAll(): Promise<ISurvey[]> {
    const response: AxiosResponse<{ data: ISurvey[] }> = await this.apiClient
      .getHttpClient()
      .get(`${import.meta.env.VITE_API_URL as string}/survey`);
    return response.data.data;
  }

  async updateSurvey(iSurvey: ISurvey): Promise<void> {
    const response: AxiosResponse<void> = await this.apiClient
      .getHttpClient()
      .put(`${import.meta.env.VITE_API_URL as string}/survey`, {
        ...iSurvey,
      });
    return response.data;
  }
}
