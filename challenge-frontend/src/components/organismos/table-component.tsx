import React from "react";
import { SurveyTable } from "../moleculas";
import { ISurvey } from "../../types/survey/survey";

type TableComponentProps = {
  data: ISurvey[];
};

const TableComponent: React.FC<TableComponentProps> = ({ data }) => {
  return <SurveyTable data={data} />;
};

export default TableComponent;
