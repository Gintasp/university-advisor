import React from 'react';
import { TYPE_UNIVERSITY, TYPE_FACULTY, TYPE_PROGRAM } from '../config/types';
import UniversityStats from './UniversityStats';
import FacultyStats from './FacultyStats';
import StudyProgramStats from './StudyProgramStats';

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
            <h6 className="text-center gray">{item.University}</h6>
            <FacultyStats stats={stats} />
          </React.Fragment>
        );
      case TYPE_PROGRAM:
        return (
          <React.Fragment>
            <h4 className="text-center">{item.Title}</h4>
            <h6 className="text-center gray">{item.University}</h6>
            <StudyProgramStats stats={stats} />
          </React.Fragment>
        );
    }
  }
}

export default StatsContainer;
