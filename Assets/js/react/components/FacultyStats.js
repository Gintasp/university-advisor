import React from 'react';

const FacultyStats = ({ stats }) => (
  <div className="list-group">
    <p className="list-group-item">Lecturers: {stats.lecturer_count}</p>
    <p className="list-group-item">Reviews: {stats.review_count}</p>
    <p className="list-group-item">Overal rating: {stats.overal}</p>
    <p className="list-group-item">Average graduate salary: {stats.salary} €</p>
    <p className="list-group-item">
      Study programs: {stats.study_program_count}
    </p>
    <p className="list-group-item">
      Student satisfaction: {stats.satisfaction}
    </p>
    <p className="list-group-item">
      Percent of graduates working in relevant industry:{' '}
      {stats.relevant_industry}%
    </p>
  </div>
);

export default FacultyStats;
