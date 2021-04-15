import React, { Component } from 'react';
import TableItem from './BookItem';
import axios from 'axios';

export default class BookTable extends Component {
    constructor (props) {
        super(props);
        this.state = {bookList: [], loaded: false}
    }

    componentDidMount() {
      axios.get('/Book/Get')
          .then(response => {
              this.setState({ bookList: response.data, loaded: true});
      });
    }

    renderBookList() {
      if (this.state.loaded) {
        console.log(this.state.bookList)
      }
    }

  render () {
    return (
      <div>
        <TableItem />
        <TableItem />
        <TableItem />
        {this.renderBookList() }
      </div>
    );
  }
}
