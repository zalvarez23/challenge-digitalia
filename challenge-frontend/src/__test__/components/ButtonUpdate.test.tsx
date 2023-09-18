import { render, RenderResult } from "@testing-library/react";
import "@testing-library/jest-dom/extend-expect";
import { ButtonUpdate } from "../../components/atomos";

describe("<ButtonUpdate />", () => {
  let component: RenderResult;
  beforeEach(() => {
    component = render(
      <ButtonUpdate
        isLoading={false}
        updatePermission={() => null}
        label="my button"
      />
    );
  });
  test("Renders label text correctly", () => {
    expect(component.container).toHaveTextContent("my button");
    expect(component.container).toBeInTheDocument();
  });

  test("Renders label text correctly is loading false", () => {
    component = render(
      <ButtonUpdate isLoading={true} updatePermission={() => null} label="" />
    );
    const circleLoading = component.container.querySelector("circle");
    expect(component.container).toHaveTextContent("Procesando . .");
    expect(circleLoading).toBeInTheDocument();
    expect(component.container).toBeInTheDocument();
  });
});
