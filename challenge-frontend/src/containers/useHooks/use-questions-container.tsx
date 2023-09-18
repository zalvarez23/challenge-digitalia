import { useEffect, useState } from "react";
import { useNavigate, useParams } from "react-router-dom";

import { IQuestionSurvey } from "../../types/question-survey/question-survey";
import { QuestionSurveyServices } from "../../services/questions-survey/questions-survey-services";
import { SurveyServices } from "../../services/survey/survey-services";
import { ISurvey } from "../../types/survey/survey";

const useQuestionSurveyContainer = () => {
  const { id, title } = useParams();
  const [mounted, setMounted] = useState(true);
  const [isLoading, setIsLoading] = useState<boolean>(false);
  const [questionsSurvey, setQuestionsSurvey] = useState<IQuestionSurvey[]>();
  const questionSurveyServices = new QuestionSurveyServices();
  const surveyServices = new SurveyServices();
  const navigate = useNavigate();

  const getAllQuestionSurvey = async () => {
    const result = await questionSurveyServices.getAllById(id || "");
    setQuestionsSurvey(result);
  };

  const saveQuestionSurvey = async (
    questionSurvey: IQuestionSurvey[]
  ): Promise<void> => {
    setIsLoading(true);
    const questionsToSave: ISurvey = {
      id: Number(id),
      surveyTitle: title || "",
      surveyStatus: 2,
      surveyDetails: questionSurvey,
    };
    await surveyServices.updateSurvey(questionsToSave);
    setTimeout(() => {
      setIsLoading(false);
      navigate("/");
    }, 2000);
  };
  useEffect(() => {
    if (!mounted) {
      getAllQuestionSurvey();
    }
    setMounted(false);
  }, [mounted]);

  return {
    saveQuestionSurvey,
    isLoading,
    questionsSurvey,
    title,
  };
};
export default useQuestionSurveyContainer;
