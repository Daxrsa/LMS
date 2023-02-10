import React from 'react';
import { Button, Container, Header, Icon, Menu } from 'semantic-ui-react';

interface Props{
    openForm: () => void;
}

export default function NavBar({openForm}: Props){
    return(
        <Menu inverted fixed='top'>
            <Container>
                <Menu.Item header>
                <Header icon='laptop' inverted style={{marginRight: '10px', marginTop: '5px'}}/>
                    E-Learning Demo App
                </Menu.Item>
                <Menu.Item name='Exams'/>
                <Menu.Item>
                    <Button onClick={openForm} positive content='Add'/>
                </Menu.Item>
            </Container>
        </Menu>
    )
}