import React from 'react';
import { render } from 'react-dom';
import ComparisonContainer from './containers/Comparison';

const App = () => (
  <React.Fragment>
    <ComparisonContainer />
  </React.Fragment>
);

render(<App />, document.getElementById('comparison'));
