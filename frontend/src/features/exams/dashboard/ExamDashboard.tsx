import React from "react";
import { Button, Grid, GridColumn, List } from "semantic-ui-react";
import { Exam } from "../../../app/models/exam";
import ExamDetails from "../details/ExamDetails";
import ExamForm from "../form/ExamForm";
import ExamList from "./ExamList";

interface Props {
  exams: Exam[];
  selectedExam: Exam | undefined;
  selectExam: (id: string) => void;
  cancelSelectExam: () => void;
  editMode: boolean;
  openForm: (id: string) => void;
  closeForm: () => void;
  createOrEdit: (exam: Exam) => void;
  deleteExam: (id: string) => void;
  submitting: boolean;
}

export default function ExamDashboard({
  exams,
  selectedExam,
  selectExam,
  cancelSelectExam,
  editMode,
  openForm,
  closeForm,
  createOrEdit,
  deleteExam,
  submitting
}: Props) {
  return (
    <Grid>
      <Grid.Column width="10">
        <ExamList 
        exams={exams} 
        selectExam={selectExam} 
        deleteExam={deleteExam}
        submitting={submitting}
        />
      </Grid.Column>
      <Grid.Column width="6">
        {selectedExam && !editMode &&
          <ExamDetails
            exam={selectedExam}
            cancelSelectExam={cancelSelectExam}
            openForm={openForm}
          />}
        {editMode &&
        <ExamForm 
        closeForm={closeForm} 
        exam={selectedExam} 
        createOrEdit={createOrEdit} 
        submitting={submitting}
        />}
      </Grid.Column>
    </Grid>
  );
}
