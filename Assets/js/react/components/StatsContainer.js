import React from 'react';
import { TYPE_UNIVERSITY } from '../config/types';
import UniversityStats from './UniversityStats';

class StatsContainer extends React.PureComponent {
  render() {
    const { type, data } = this.props;

    switch (type) {
      case TYPE_UNIVERSITY:
        return <UniversityStats data={data} />;
    }
  }
}

export default StatsContainer;
