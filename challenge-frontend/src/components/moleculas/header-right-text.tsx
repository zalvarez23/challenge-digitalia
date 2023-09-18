import React from "react";
import { InfoSharp } from "@mui/icons-material";
import { Box } from "@mui/material";
import { HeaderText } from "../atomos";

type HeaderRightTextProps = {
  labels: string[];
};
const HeaderRightText: React.FC<HeaderRightTextProps> = ({ labels }) => {
  return (
    <Box display="flex" alignItems="center" gap={1}>
      {labels.map((label, i) => (
        <HeaderText label={label} key={i} />
      ))}
      <InfoSharp fontSize="small" color="disabled" />
    </Box>
  );
};

export default HeaderRightText;
