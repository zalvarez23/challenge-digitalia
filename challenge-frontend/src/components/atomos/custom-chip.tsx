import { Chip, Typography } from "@mui/material";
import React from "react";
import { CustomColors } from "../../constants/Colors";

type CustomChipProps = {
  status: number;
};
const CustomChip: React.FC<CustomChipProps> = ({ status }) => {
  return (
    <Chip
      size="small"
      label={
        <Typography
          fontFamily="Montserrat-Medium"
          fontSize={10}
          variant="caption"
          color={CustomColors.gray2}
        >
          {status === 1 ? "Pendiente" : "Completado"}
        </Typography>
      }
      color={status === 1 ? "warning" : "success"}
    />
  );
};

export default CustomChip;
