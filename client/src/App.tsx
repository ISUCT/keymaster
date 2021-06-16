import React from 'react';
import logo from './logo.svg';
import './App.css';
import { render } from '@testing-library/react';
import MyTable from './components/MyTable'
import MyHeader from './components/MyHeader'

class App extends React.Component{
  render(){
    return(
      <>
        <MyHeader/>
        <MyTable/>
      </>
    );
  }

}


export default App;
