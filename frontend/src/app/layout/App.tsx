import React, { useEffect, useState } from "react";
import "./styles.css";
import axios from "axios";
import { Exam } from "../models/exam";
import NavBar from "./NavBar";
import { Container } from "semantic-ui-react";
import ExamDashboard from "../../features/exams/dashboard/ExamDashboard";

function App() {
  const [exams, setExams] = useState<Exam[]>([]);

  useEffect(() => {
    axios.get<Exam[]>("http://localhost:5113/api/Exam").then((response) => {
      console.log(response);
      setExams(response.data);
    });
  }, []);

  return (
    <>
      <NavBar />
        <Container style={{ marginTop: "7em" }}>
          <ExamDashboard exams={exams} />
        </Container>
    </>
  );
}

export default App;
