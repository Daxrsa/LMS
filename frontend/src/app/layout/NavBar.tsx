import React from 'react';
import { Button, Container, Header, Icon, Menu } from 'semantic-ui-react';

export default function NavBar(){
    return(
        <Menu inverted fixed='top'>
            <Container>
                <Menu.Item header>
                <Header icon='laptop' inverted style={{marginRight: '10px', marginTop: '5px'}}/>
                    E-Learning Demo App
                </Menu.Item>
                <Menu.Item name='Exams'/>
                <Menu.Item>
                    <Button positive content='Add'/>
                </Menu.Item>
            </Container>
        </Menu>
    )
}