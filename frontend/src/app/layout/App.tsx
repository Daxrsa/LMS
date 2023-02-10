import React, { useEffect, useState } from "react";
import "./styles.css";
import { Exam } from "../models/exam";
import NavBar from "./NavBar";
import { Container } from "semantic-ui-react";
import ExamDashboard from "../../features/exams/dashboard/ExamDashboard";
import {v4 as uuid} from 'uuid';
import agent from "../api/agent";
import LoadingComponent from "./LoadingComponent";

function App() {
  const [exams, setExams] = useState<Exam[]>([]);
  const [selectedExam, setSelectedExam] = useState<Exam | undefined>(undefined);
  const [editMode, setEditMode] = useState(false);
  const [loading, setLoading ] = useState(true);
  const [submitting, setSubmitting] = useState(false);

  useEffect(() => {
    agent.Exams.list().then((response) => {
      let exams: Exam[] = [];
      response.forEach(exam => {
        exam.examDate = exam.examDate.split('T')[0];
        exams.push(exam);
      })
      setExams(exams);
      setLoading(false);
    });
  }, []);

  function handleSelectExam(id: String) {
    setSelectedExam(exams.find((x) => x.id === id));
  }

  function handleCancelSelectExam() {
    setSelectedExam(undefined);
  }

  function handleFormOpen(id?: string){
    id ? handleSelectExam(id) : handleCancelSelectExam();
    setEditMode(true);
  }

  function handleFormClose(){
    setEditMode(false);
  }

  function handleCreateOrEditExam(exam: Exam){
    setSubmitting(true);
    if (exam.id){
      agent.Exams.update(exam).then(() => {
        setExams([...exams.filter(x => x.id !== exam.id), exam])
        setSelectedExam(exam);
        setEditMode(false);
        setSubmitting(false);
      })
    } else {
      exam.id = uuid();
      agent.Exams.create(exam).then(() => {
      setExams([...exams, exam])
      setSelectedExam(exam);
      setEditMode(false);
      setSubmitting(false);
      })
    }
  }

  function handleDeleteExam(id: string){
    setSubmitting(true);
    agent.Exams.delete(id).then(() => {
    setExams([...exams.filter(x => x.id !== id)]);
    setSubmitting(false);
    })
  }

  if (loading) return <LoadingComponent content="Loading app" />

  return (
    <>
      <NavBar openForm={handleFormOpen} />
      <Container style={{ marginTop: "7em" }}>
        <ExamDashboard 
        exams={exams}
        selectedExam={selectedExam}
        selectExam={handleSelectExam}
        cancelSelectExam={handleCancelSelectExam}
        editMode={editMode}
        openForm={handleFormOpen}
        closeForm={handleFormClose}
        createOrEdit={handleCreateOrEditExam}
        deleteExam={handleDeleteExam}
        submitting={submitting}
        />
      </Container>
    </>
  );
}

export default App;
