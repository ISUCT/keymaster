import React from 'react';
import logo from './logo.svg';
import './App.css';
import { render } from '@testing-library/react';
import MyTable from './components/MyTable'
import Header from './components/Header'
import TeachersTable from './components/TeachersTable'

class App extends React.Component{
  render(){
    return(
      <>
        <Header/>
        <MyTable/>
        <TeachersTable/>
      </>
    );
  }

}


export default App;
