import "./App.css";
import { BrowserRouter, Routes, Route } from "react-router-dom";
import SurveyContainer from "./containers/survey-container";
import QuestionsSurveyContainer from "./containers/questions-survey-container";

const App: React.FC = () => {
  return (
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<SurveyContainer />} />
        <Route
          path="/questions/:id/:title/:status"
          element={<QuestionsSurveyContainer />}
        />
      </Routes>
    </BrowserRouter>
  );
};

export default App;
