import React, { ChangeEvent, useState } from "react";
import { Button, Form, Segment } from "semantic-ui-react";
import { Exam } from "../../../app/models/exam";

interface Props{
    exam: Exam | undefined;
    closeForm: () => void;
    createOrEdit: (exam: Exam) => void;
    submitting: boolean;
}

export default function ExamForm({ exam: selectedExam, closeForm, createOrEdit, submitting }: Props){

    const initialState = selectedExam ?? {
        id: '',
        course: '',
        professor: '',
        examDate: '',
        afati: '',
        students: ''
    }

    const [exam, setExam] = useState(initialState);

    function handleSubmit(){
        createOrEdit(exam);
    }

    function handleInputChange(event: ChangeEvent<HTMLInputElement>){
        const {name, value} = event.target;
        setExam({...exam, [name]: value})
    }

    return(
        <Segment clearing>
            <Form onSubmit={handleSubmit} autoComplete='off'>
                <Form.Input placeholder='Course' value={exam.course} name='course' onChange={handleInputChange}/>
                <Form.Input placeholder='Professor' value={exam.professor} name='professor' onChange={handleInputChange}/>
                <Form.Input type="date" placeholder='Date' value={exam.examDate} name='examDate' onChange={handleInputChange}/>
                <Form.Input placeholder='Afati' value={exam.afati} name='afati' onChange={handleInputChange}/>
                <Button loading={submitting} floated="right" positive type="submit" content="Submit"/>
                <Button onClick={closeForm} floated="right" type="button" content="Cancel"/>
            </Form>
        </Segment>
    )
}