import React from 'react';

const LecturerStats = ({ stats }) => (
  <div className="list-group">
    <p className="list-group-item">Reviews: {stats.review_count}</p>
    <p className="list-group-item">Competence: {stats.competence}</p>
    <p className="list-group-item">Overal rating: {stats.overal}</p>
    <p className="list-group-item">Strictness: {stats.strictness}</p>
    <p className="list-group-item">Delivery: {stats.delivery}</p>
    <p className="list-group-item">Personality: {stats.personality}</p>
  </div>
);

export default LecturerStats;
