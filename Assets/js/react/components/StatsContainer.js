import React from 'react';
import { TYPE_UNIVERSITY, TYPE_FACULTY } from '../config/types';
import UniversityStats from './UniversityStats';
import FacultyStats from './FacultyStats';

class StatsContainer extends React.PureComponent {
  render() {
    const { item, stats } = this.props;

    switch (item.Type) {
      case TYPE_UNIVERSITY:
        return (
          <React.Fragment>
            <h4 className="text-center">{item.Title}</h4>
            <UniversityStats stats={stats} />
          </React.Fragment>
        );
      case TYPE_FACULTY:
        return (
          <React.Fragment>
            <h4 className="text-center">{item.Title}</h4>
            <FacultyStats stats={stats} />
          </React.Fragment>
        );
    }
  }
}

export default StatsContainer;
