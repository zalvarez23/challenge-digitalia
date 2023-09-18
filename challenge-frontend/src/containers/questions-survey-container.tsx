import React from "react";
import HeaderComponent from "../components/organismos/header-component";
import { Box } from "@mui/material";
import useCreatePermissionContainer from "./useHooks/use-questions-container";
import QuestionsComponent from "../components/organismos/questions-component";

const QuestionsSurveyContainer: React.FC = () => {
  const { title, questionsSurvey, saveQuestionSurvey, isLoading, status } =
    useCreatePermissionContainer();

  return (
    <Box paddingY={5} paddingX={"10%"}>
      <HeaderComponent
        titleName={title}
        labelsLeft={["Información del la encuesta"]}
        labelsRight={["Responder en una escala de 1 al 5"]}
      />
      <QuestionsComponent
        questions={questionsSurvey || []}
        saveQuestionSurvey={saveQuestionSurvey}
        isLoading={isLoading}
        status={Number(status)}
      />
    </Box>
  );
};

export default QuestionsSurveyContainer;
