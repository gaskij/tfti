import React from 'react';
import { BrowserRouter, Switch, Route } from 'react-router-dom';
import { ThemeProvider } from '@material-ui/core';  

import theme from '../theme';
import Header from './header/Header';
import Dashboard from '../dashboard/Dashboard';
import EventDetails from '../event-details/EventDetailsPage';
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
            <Route path="/events/:id">
              <EventDetails />
            </Route>
          </Switch>
        </main>
      </BrowserRouter>
    </ThemeProvider>
  );
}

export default App;
