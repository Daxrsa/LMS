import React, { SyntheticEvent, useState } from "react";
import { Button, Item, Label, Segment } from "semantic-ui-react";
import { Exam } from "../../../app/models/exam";

interface Props {
  exams: Exam[];
  selectExam: (id: string) => void;
  deleteExam: (id: string) => void;
  submitting: boolean;
}

export default function ExamList({
  exams,
  selectExam,
  deleteExam,
  submitting,
}: Props) {
  const [target, setTarget] = useState("");

  function handleExamDelete(e: SyntheticEvent<HTMLButtonElement>, id: string) {
    setTarget(e.currentTarget.name);
    deleteExam(id);
  }

  return (
    <Segment>
      <Item.Group divided>
        {exams.map((exam) => (
          <Item key={exam.id}>
            <Item.Content>
              <Item.Header as="a">{exam.id}</Item.Header>
              <Item.Meta>{exam.examDate}</Item.Meta>
              <Item.Header>{exam.course}</Item.Header>
              <Item.Meta>{exam.professor}</Item.Meta>
              <Item.Extra>
                <Button
                  onClick={() => selectExam(exam.id)}
                  floated="right"
                  content="View"
                  color="blue"
                />
                <Button
                  name={exam.id}
                  loading={submitting && target === exam.id}
                  onClick={(e) => handleExamDelete(e, exam.id)}
                  floated="right"
                  content="Delete"
                  color="red"
                />
                <Label basic content={exam.afati} />
              </Item.Extra>
            </Item.Content>
          </Item>
        ))}
      </Item.Group>
    </Segment>
  );
}
