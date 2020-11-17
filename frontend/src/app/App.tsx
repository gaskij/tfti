import React from 'react';
import { BrowserRouter, Switch, Route } from 'react-router-dom';
import { ThemeProvider } from '@material-ui/core';  

import theme from '../theme';
import Header from './header';
import Footer from './footer';
import Dashboard from '../dashboard';
import './App.css';

function App() {
  return (
    <ThemeProvider theme={theme}>
      <BrowserRouter>
        <header className="App-header">
          <Header />
        </header>
        <main>
          <Switch>
            <Route exact path="/">
              <Dashboard />
            </Route>
            <Route path="/index">
              <Dashboard />
            </Route>
          </Switch>
        </main>
        <footer>
          <Footer />
        </footer>
      </BrowserRouter>
    </ThemeProvider>
  );
}

export default App;
