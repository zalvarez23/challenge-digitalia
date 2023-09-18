import { IQuestionSurvey } from "../../types/question-survey/question-survey";
import { IQuestionsSurveyRepository } from "../../types/question-survey/question-survey-repository";
import { ApiClient } from "../../utils/ApiClient";
import { AxiosResponse } from "axios";

export class ApiQuestionSurveyRepository implements IQuestionsSurveyRepository {
  private apiClient: ApiClient;
  constructor() {
    this.apiClient = ApiClient.getInstance();
  }

  async getAllById(id: string): Promise<IQuestionSurvey[]> {
    const response: AxiosResponse<{ data: IQuestionSurvey[] }> =
      await this.apiClient
        .getHttpClient()
        .get(`${import.meta.env.VITE_API_URL as string}/surveydetail/${id}`);
    return response.data.data;
  }
}
