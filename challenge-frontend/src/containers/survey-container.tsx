import React from "react";
import HeaderComponent from "../components/organismos/header-component";
import { Box } from "@mui/material";
import TableComponent from "../components/organismos/table-component";
import useSurveyContainer from "./useHooks/use-survey-container";

const SurveyContainer: React.FC = () => {
  const { surveyList } = useSurveyContainer();

  return (
    <Box paddingY={5} paddingX={"10%"}>
      <HeaderComponent />
      <TableComponent data={surveyList} />
    </Box>
  );
};

export default SurveyContainer;
