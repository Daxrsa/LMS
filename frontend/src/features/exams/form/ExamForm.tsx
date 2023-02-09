import React from "react";
import { Button, Form, Segment } from "semantic-ui-react";

export default function ExamForm(){
    return(
        <Segment clearing>
            <Form>
                <Form.Input placeholder='Id'/>
                <Form.Input placeholder='Course'/>
                <Form.Input placeholder='Professor'/>
                <Form.Input placeholder='Date'/>
                <Form.Input placeholder='Afati'/>
                <Button floated='right' content='View' color='green' href="" />
                <Button floated="right" positive type="submit" content="Submit"/>
                <Button floated="right" type="button" content="Cancel"/>
            </Form>
        </Segment>
    )
}