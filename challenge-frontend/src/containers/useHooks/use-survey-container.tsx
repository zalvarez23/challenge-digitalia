import { useEffect, useState } from "react";
import { SurveyServices } from "../../services/survey/survey-services";
import { ISurvey } from "../../types/survey/survey";

const useSurveyContainer = () => {
  const [mounted, setMounted] = useState(true);
  const [surveyList, setSurveyList] = useState<ISurvey[]>([]);

  const surveyServices = new SurveyServices();
  const getAllSurvey = async (): Promise<void> => {
    const result = await surveyServices.getAll();
    setSurveyList(result);
  };
  useEffect(() => {
    if (!mounted) {
      getAllSurvey();
    }
    setMounted(false);
  }, [mounted]);

  return {
    surveyList,
  };
};
export default useSurveyContainer;
