import { Typography } from "@mui/material";
import React from "react";
import { CustomColors } from "../../constants/Colors";

type BodyTextProps = {
  label: string | number;
  color?: string;
  fontFamily?: string;
  size?: number;
};
const BodyText: React.FC<BodyTextProps> = ({
  label,
  color,
  fontFamily,
  size,
}) => {
  return (
    <Typography
      fontFamily={fontFamily}
      variant="caption"
      color={color}
      fontSize={size}
    >
      {label}
    </Typography>
  );
};

BodyText.defaultProps = {
  label: "Mi Nombre",
  color: CustomColors.black,
  fontFamily: "Montserrat-Medium",
  size: 12,
};

export default BodyText;
