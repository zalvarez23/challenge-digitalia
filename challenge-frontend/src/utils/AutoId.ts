export const generarIDNumericoAleatorio = (): number => {
  const randomDecimal = Math.random();
  const rango = 10000 - 1 + 1;
  const idNumericoAleatorio = Math.floor(randomDecimal * rango) + 1;
  return idNumericoAleatorio;
};
