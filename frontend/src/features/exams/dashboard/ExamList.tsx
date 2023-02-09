import React from "react";
import { Button, Item, Label, Segment } from "semantic-ui-react";
import { Exam } from "../../../app/models/exam";

interface Props{
    exams: Exam[];
}

export default function ExamList({exams}: Props){
    return(
        <Segment>
            <Item.Group divided>
                {exams.map(exam => (
                    <Item key={exam.id}>
                        <Item.Content>
                            <Item.Header as='a'>{exam.id}</Item.Header>
                            <Item.Meta>{exam.examDate}</Item.Meta>
                            <Item.Header>{exam.professor}</Item.Header>
                            <Item.Header>{exam.course}</Item.Header>
                            <Item.Header>{exam.students}</Item.Header>
                            <Item.Extra>
                                <Button floated='right' content='View' color='blue' />
                                <Label basic content={exam.afati}/>
                            </Item.Extra>
                        </Item.Content>
                    </Item>
                ))}
            </Item.Group>
        </Segment>
    )
}