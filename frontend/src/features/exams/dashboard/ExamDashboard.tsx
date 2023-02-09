import React from "react";
import { Grid, GridColumn, List } from "semantic-ui-react";
import { Exam } from "../../../app/models/exam";
import ExamDetails from "../details/ExamDetails";
import ExamForm from "../form/ExamForm";
import ExamList from "./ExamList";

interface Props {
  exams: Exam[];
}

export default function ExamDashboard({ exams }: Props) {
  return (
    <Grid>
      <Grid.Column width="10">
        <ExamList exams={exams} />
      </Grid.Column>
      <Grid.Column width="6">
        {exams[0] && 
        <ExamDetails exam={exams[0]} />}
        <ExamForm />
      </Grid.Column>
    </Grid>
  );
}
