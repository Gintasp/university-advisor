import React from 'react';

const UniversityStats = ({ data }) => (
  <div className="list-group">
    <p className="list-group-item">Faculty count: {data.faculty_count}</p>
    <p className="list-group-item">Reviews: {data.review_count}</p>
    <p className="list-group-item">Overal rating: {data.overal}</p>
    <p className="list-group-item">Average graduate salary: {data.salary}</p>
    <p className="list-group-item">
      Study programs: {data.study_program_count}
    </p>
    <p className="list-group-item">Student satisfaction: {data.satisfaction}</p>
    <p className="list-group-item">
      Percent of graduates working in relevant industry:{' '}
      {data.relevant_industry}%
    </p>
  </div>
);

export default UniversityStats;
