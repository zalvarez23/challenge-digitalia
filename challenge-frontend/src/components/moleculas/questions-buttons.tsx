import { Button, CircularProgress, Grid } from "@mui/material";
import React from "react";
import { BodyText } from "../atomos";

type QuestionsButtonsProps = {
  isLoading: boolean;
  handlerSaveQuestions: () => void;
  handleClearQuestions: () => void;
};
const QuestionsButtons: React.FC<QuestionsButtonsProps> = ({
  isLoading,
  handlerSaveQuestions,
  handleClearQuestions,
}) => {
  return (
    <Grid container spacing={2} paddingTop={5}>
      <Grid item>
        <Button
          variant="outlined"
          color="primary"
          onClick={handlerSaveQuestions}
        >
          {isLoading ? (
            <CircularProgress size={24} color="inherit" />
          ) : (
            <BodyText
              label="Guardar"
              size={12}
              fontFamily="Montserrat-SemiBold"
            />
          )}
        </Button>
      </Grid>
      <Grid item>
        <Button
          variant="outlined"
          color="secondary"
          onClick={handleClearQuestions}
        >
          <BodyText
            label="Limpiar"
            size={12}
            fontFamily="Montserrat-SemiBold"
          />
        </Button>
      </Grid>
    </Grid>
  );
};

export default QuestionsButtons;
