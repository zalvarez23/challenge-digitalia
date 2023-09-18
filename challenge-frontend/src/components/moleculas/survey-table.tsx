import React from "react";
import { Link } from "react-router-dom";
import { BodyText, CustomChip, HeaderText } from "../atomos";
import { formatDate } from "../../utils/DateFormat";
import {
  SegmentOutlined,
  AutofpsSelectOutlined,
  CalendarMonthOutlined,
  EditNote,
} from "@mui/icons-material";
import {
  Box,
  IconButton,
  Table,
  TableBody,
  TableCell,
  TableContainer,
  TableHead,
  TableRow,
} from "@mui/material";
import { ISurvey } from "../../types/survey/survey";

type SurveyTableProps = {
  data: ISurvey[];
};

const SurveyTable: React.FC<SurveyTableProps> = ({ data }) => {
  return (
    <TableContainer>
      <Table>
        <TableHead>
          <TableRow>
            <TableCell>
              <Box display="flex" alignItems="center" gap={1}>
                <AutofpsSelectOutlined fontSize="small" color="disabled" />
                <HeaderText label="Id" />
              </Box>
            </TableCell>
            <TableCell>
              <Box display="flex" alignItems="center" gap={1}>
                <SegmentOutlined fontSize="small" color="disabled" />
                <HeaderText label="Titulo" />
              </Box>
            </TableCell>
            <TableCell>
              <Box display="flex" alignItems="center" gap={1}>
                <CalendarMonthOutlined fontSize="small" color="disabled" />
                <HeaderText label="Fecha" />
              </Box>
            </TableCell>
            <TableCell>
              <Box display="flex" alignItems="center" gap={1}>
                <SegmentOutlined fontSize="small" color="disabled" />
                <HeaderText label="Estado" />
              </Box>
            </TableCell>
            <TableCell></TableCell>
          </TableRow>
        </TableHead>
        <TableBody>
          {data?.map((survey, i) => (
            <TableRow key={i}>
              <TableCell>
                <BodyText label={String(survey.id)} />
              </TableCell>
              <TableCell>
                <BodyText label={survey.surveyTitle} />
              </TableCell>
              <TableCell>
                <BodyText label={formatDate(survey.surveyDate || "")} />
              </TableCell>
              <TableCell>
                <CustomChip status={survey.surveyStatus} />
              </TableCell>
              <TableCell>
                <Link
                  to={{
                    pathname: `/questions/${survey.id || 0}/${
                      survey.surveyTitle
                    }/${survey.surveyStatus}`,
                  }}
                >
                  <IconButton>
                    <EditNote />
                  </IconButton>
                </Link>
              </TableCell>
            </TableRow>
          ))}
        </TableBody>
      </Table>
    </TableContainer>
  );
};

export default SurveyTable;
