import React from 'react';
import ListItem from './ListItem';
import {
  SALARY_TYPE,
  COUNT_TYPE,
  SATISFACTION_TYPE,
  RELEVANT_TYPE,
  OVERAL_TYPE,
  REVIEW_COUNT_TYPE,
} from '../config/types';

const FacultyStats = ({ stats }) => (
  <div className="list-group">
    <ListItem type={COUNT_TYPE}>Lecturers: {stats.lecturer_count}</ListItem>
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

export default FacultyStats;
