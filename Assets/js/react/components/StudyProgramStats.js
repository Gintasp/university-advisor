import React from 'react';

const StudyProgramStats = ({ stats }) => (
  <div className="list-group">
    <p className="list-group-item">Reviews: {stats.review_count}</p>
    <p className="list-group-item">Overal rating: {stats.overal}</p>
    <p className="list-group-item">Average graduate salary: {stats.salary}</p>
    <p className="list-group-item">Courses: {stats.course_count}</p>
    <p className="list-group-item">
      Student satisfaction: {stats.satisfaction}
    </p>
    <p className="list-group-item">
      Percent of graduates working in relevant industry:{' '}
      {stats.relevant_industry}%
    </p>
  </div>
);

export default StudyProgramStats;
