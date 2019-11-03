import React from 'react';
import ReactDOM from 'react-dom';
import axios from 'axios';
import ComparisonContainer from './containers/ComparisonContainer';

class App extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      items: [],
    };
  }

  componentDidMount() {
    axios
      .get('/api/items')
      .then(res => {
        this.setState({
          items: res.data,
        });
      })
      .catch(err => console.log(err));
  }

  render() {
    const { items } = this.state;

    return (
      <React.Fragment>
        <div className="mt-50">
          <h1>Compare</h1>
          <p className="mt-20">
            Choose and compare various universities, faculties, study programs,
            courses and lecturers to get valuable insights.
          </p>
        </div>
        <div className="d-flex mt-50">
          <ComparisonContainer items={items} />
          <ComparisonContainer items={items} />
        </div>
      </React.Fragment>
    );
  }
}

ReactDOM.render(<App />, document.getElementById('comparison'));
