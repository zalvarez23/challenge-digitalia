import { Box, FormControlLabel, Radio } from "@mui/material";
import React from "react";
import { BodyText } from "../atomos";
import { CustomColors } from "../../constants/Colors";
import { Number_Questions } from "../../constants/survey";
import { IQuestionSurvey } from "../../types/question-survey/question-survey";

type QuestionControlLabelProps = {
  questionsSurvey: IQuestionSurvey[];
  handleRadioChange: (score: number, questionId: number) => void;
};

const QuestionControlLabel: React.FC<QuestionControlLabelProps> = ({
  questionsSurvey,
  handleRadioChange,
}) => {
  return (
    <Box paddingTop={3}>
      {questionsSurvey.map((question) => (
        <Box key={question.id}>
          <BodyText
            label={question.surveyQuestion}
            size={13}
            fontFamily="Montserrat-SemiBold"
            color={CustomColors["gray-2"]}
          />
          <Box>
            {Number_Questions.map((option) => (
              <FormControlLabel
                key={`option-${option}`}
                value={option}
                control={<Radio />}
                label={
                  <BodyText
                    label={option}
                    size={12}
                    fontFamily="Montserrat-SemiBold"
                  />
                }
                checked={option === Number(question.questionScore)}
                onChange={(e: any) =>
                  handleRadioChange(e.target.value, question.id)
                }
              />
            ))}
          </Box>
        </Box>
      ))}
    </Box>
  );
};

export default QuestionControlLabel;
