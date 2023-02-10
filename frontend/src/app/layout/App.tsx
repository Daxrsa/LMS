import React, { useEffect, useState } from "react";
import "./styles.css";
import axios from "axios";
import { Exam } from "../models/exam";
import NavBar from "./NavBar";
import { Container } from "semantic-ui-react";
import ExamDashboard from "../../features/exams/dashboard/ExamDashboard";
import Register from "./Register";

function App() {
  const [exams, setExams] = useState<Exam[]>([]);
  const [currentForm, setCurrentForm]=useState('login');
  useEffect(() => {
    axios.get<Exam[]>("http://localhost:5113/api/Exam").then((response) => {
      console.log(response);
      setExams(response.data);
    });
  }, []);

//it knows which name it should set
 /* const toggleForm =(formName: any)=> { 
    setCurrentForm(formName);
  }*/

  return (
    <>
      <NavBar />
        <Container style={{ marginTop: "7em" }}>
          {
           // currentForm=="login" ?<Login onFormSwitch ={toggleForm}/> : <Register  onFormSwitch ={toggleForm}/>
          }
          <Register/>
          <ExamDashboard exams={exams} />
        </Container>
    </>
  );
}

export default App;
