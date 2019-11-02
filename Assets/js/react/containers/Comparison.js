import React from 'react';
import axios from 'axios';

class ComparisonContainer extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      items: [],
    };
  }

  componentDidMount() {
    axios
      .get('/api/items')
      .then(res => console.log(res.data))
      .catch(err => console.log(err));
  }

  render() {
    return (
      <React.Fragment>
        <div className="mt-50">
          <h1>Compare</h1>
          <p>
            Choose and compare various universities, faculties, study programs
            to get valuable insights.
          </p>
        </div>
      </React.Fragment>
    );
  }
}

export default ComparisonContainer;
