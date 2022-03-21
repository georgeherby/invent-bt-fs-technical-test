import React, { useReducer, useState } from 'react';
import './App.css';
import Button from 'react-bootstrap/Button';
import Form from 'react-bootstrap/Form';
import Card from 'react-bootstrap/Card';
import Navbar from 'react-bootstrap/Navbar';
import Col from 'react-bootstrap/Col';
import Container from 'react-bootstrap/Container';

interface AppState {
  name: string;
  value: string;
}

// An interface for our actions
interface TypeAction {
  name: string;
  value: string;
}

const formReducer = (state: AppState, action : TypeAction) => {
  return {
    ...state,
    [action.name]: action.value
  }
}

function App() {
  const [formData, setFormData] = useReducer(formReducer, { name:"", value:""});
  const [submitting, setSubmitting] = useState(false);
  const handleSubmit = (event: React.SyntheticEvent<HTMLFormElement>) => {
    event.preventDefault();
    setSubmitting(true);
  }

  const handleChange = (event: React.ChangeEvent<HTMLInputElement>) => {
    setFormData({
      name: event.target.name,
      value: event.target.value,
    });
  }


  return (
    <Col>
      <Navbar bg="light" expand="lg">
        <Container>

          <Navbar.Brand href="#home"><img
            alt=""
            src="/logo.png"
            width="30"
            height="30"
            className="d-inline-block align-top"
          />{' '} The Shop</Navbar.Brand>

        </Container>
      </Navbar>
      <Container>
        {submitting &&
          <Card><Card.Body><h1>Hello {Object.entries(formData).map(([name, value]) => (
            <strong>{value.toString()}</strong>
          ))}, good luck!
          </h1></Card.Body></Card>
        }
        <Card>
          <Form onSubmit={handleSubmit}>
            <Card.Body><Form.Group className="mb-3" controlId="exampleForm.name">
              <Form.Label>Name</Form.Label>
              <Form.Control as='input' name="name" placeholder="Enter your name" onChange={handleChange} />
            </Form.Group>
              <Button variant="primary" type="submit">Submit</Button>

              <Button variant="secondary" type="reset" onClick={event => setSubmitting(false)}>Reset</Button>
            </Card.Body>
          </Form>
        </Card>
      </Container>
    </Col >

  )
}


export default App;
