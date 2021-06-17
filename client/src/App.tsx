import React from 'react';
import logo from './logo.svg';
import './App.css';
import { render } from '@testing-library/react';
import MyTable from './components/MyTable'
import MyHeader from './components/MyHeader'
import TeachersTable from './components/TeachersTable'

class App extends React.Component{
  render(){
    return(
      <>
        <MyHeader/>
        <MyTable/>
        <TeachersTable/>
      </>
    );
  }

}


export default App;
