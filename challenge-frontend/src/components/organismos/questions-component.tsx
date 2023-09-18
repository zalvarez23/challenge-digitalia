import React, { useEffect, useState } from "react";
import { IQuestionSurvey } from "../../types/question-survey/question-survey";
import { Box } from "@mui/material";
import { QuestionsButtons } from "../moleculas";
import QuestionControlLabel from "../moleculas/question-control-label";

type QuestionsComponentProps = {
  questions: IQuestionSurvey[];
  isLoading: boolean;
  saveQuestionSurvey: (questionsSurvey: IQuestionSurvey[]) => void;
  status: number;
};
const QuestionsComponent: React.FC<QuestionsComponentProps> = ({
  questions,
  isLoading,
  saveQuestionSurvey,
  status,
}) => {
  const [questionsSurvey, setQuestionSurvey] = useState<IQuestionSurvey[]>([]);

  useEffect(() => {
    setQuestionSurvey(questions);
  }, [questions]);

  const handleRadioChange = (score: number, questionId: number) => {
    const changedQuestionSurvey = questionsSurvey.filter((question) => {
      if (question.id === questionId) {
        question.questionScore = score;
      }
      return question;
    });
    setQuestionSurvey(changedQuestionSurvey);
  };

  const handleClearQuestions = () => {
    const changedToInitQuestions = questionsSurvey.map((question) => {
      question.questionScore = 0;
      return question;
    });
    setQuestionSurvey(changedToInitQuestions);
  };

  const handlerSaveQuestions = () => {
    saveQuestionSurvey(questionsSurvey);
  };

  return (
    <Box>
      {questionsSurvey.length > 0 && (
        <>
          <QuestionControlLabel
            questionsSurvey={questionsSurvey}
            handleRadioChange={handleRadioChange}
            status={status}
          />
          {status === 1 && (
            <QuestionsButtons
              isLoading={isLoading}
              handlerSaveQuestions={handlerSaveQuestions}
              handleClearQuestions={handleClearQuestions}
            />
          )}
        </>
      )}
    </Box>
  );
};

export default QuestionsComponent;
