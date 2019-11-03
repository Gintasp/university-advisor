import React from 'react';

const CourseStats = ({ stats }) => (
  <div className="list-group">
    <p className="list-group-item">Reviews: {stats.review_count}</p>
    <p className="list-group-item">Overal rating: {stats.overal}</p>
    <p className="list-group-item">Difficulty: {stats.difficulty}</p>
    <p className="list-group-item">
      Student satisfaction: {stats.satisfaction}
    </p>
    <p className="list-group-item">Usefulness: {stats.usefulness}</p>
    <p className="list-group-item">Interesting: {stats.interesting}</p>
    <p className="list-group-item">
      Percent of theory material {stats.theory}%
    </p>
    <p className="list-group-item">
      Percent of practice material {stats.practice}%
    </p>
  </div>
);

export default CourseStats;
