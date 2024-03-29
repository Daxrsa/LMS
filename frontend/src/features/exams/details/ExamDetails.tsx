import React from "react";
import { Button, Card, Icon, Image } from "semantic-ui-react";
import { Exam } from "../../../app/models/exam";
import mathExam from '../../../assets/mathExam.jpeg';

interface Props{
    exam: Exam;
    cancelSelectExam: () => void;
    openForm: (id: string) => void;
}

export default function ExamDetails({ exam, cancelSelectExam, openForm }: Props) {
  return (
      <Card fluid>
        <Image src={mathExam} />
        <Card.Content>
          <Card.Header>{exam.id}</Card.Header>
          <Card.Meta>
            <span>{exam.examDate}</span>
          </Card.Meta>
          <Card.Description>
           {exam.afati}
          </Card.Description>
        </Card.Content>
        <Card.Content extra>
          <a>
            <Icon name="eye" />
            Detailed Exam View
          </a>
        </Card.Content>
        <Card.Content>
            <Button.Group widths='2'>
                <Button onClick={() => openForm(exam.id)} basic color="blue" content='Edit' />
                <Button onClick={cancelSelectExam} basic color="grey" content='Cancel' />
            </Button.Group>
        </Card.Content>
      </Card>
  );
}
