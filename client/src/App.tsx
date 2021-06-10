import React from 'react';
import logo from './logo.svg';
import './App.css';
import { render } from '@testing-library/react';
import MyTable from './components/MyTable'

class App extends React.Component{
  render(){
    return(
      <>
        <MyTable/>
      </>
    );
  }

}


export default App;
