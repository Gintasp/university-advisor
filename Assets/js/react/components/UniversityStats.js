import React from 'react';
import ListItem from './ListItem';
import {
  COUNT_TYPE,
  REVIEW_COUNT_TYPE,
  OVERAL_TYPE,
  SALARY_TYPE,
  SATISFACTION_TYPE,
  RELEVANT_TYPE,
} from '../config/types';

const UniversityStats = ({ stats }) => (
  <div className="list-group uni-stats">
    <ListItem type={COUNT_TYPE}> Faculty count: {stats.faculty_count}</ListItem>
    <ListItem type={REVIEW_COUNT_TYPE}>Reviews: {stats.review_count}</ListItem>
    <ListItem type={OVERAL_TYPE}>Overal rating: {stats.overal}</ListItem>
    <ListItem type={SALARY_TYPE}>
      Average graduate salary: {stats.salary} €
    </ListItem>
    <ListItem type={COUNT_TYPE}>
      Study programs: {stats.study_program_count}
    </ListItem>
    <ListItem type={SATISFACTION_TYPE}>
      Student satisfaction: {stats.satisfaction}
    </ListItem>
    <ListItem type={RELEVANT_TYPE}>
      Percent of graduates working in relevant industry:{' '}
      {stats.relevant_industry}%
    </ListItem>
  </div>
);

export default UniversityStats;
