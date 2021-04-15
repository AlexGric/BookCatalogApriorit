import React, { Component } from 'react';
import { Route, Switch } from 'react-router'
import BookTable from './components/BookTable';

export default class App extends Component {

  render () {
    return (
      <Switch>
        <Route exact path='/' component={BookTable} />
      </Switch>
    );
  }
}
