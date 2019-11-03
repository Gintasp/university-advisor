import React from 'react';
import ListItem from './ListItem';
import {
  REVIEW_COUNT_TYPE,
  OVERAL_TYPE,
  SALARY_TYPE,
  COUNT_TYPE,
  SATISFACTION_TYPE,
  RELEVANT_TYPE,
} from '../config/types';

const StudyProgramStats = ({ stats }) => (
  <div className="list-group">
    <ListItem type={REVIEW_COUNT_TYPE}>Reviews: {stats.review_count}</ListItem>
    <ListItem type={OVERAL_TYPE}>Overal rating: {stats.overal}</ListItem>
    <ListItem type={SALARY_TYPE}>
      Average graduate salary: {stats.salary} €
    </ListItem>
    <ListItem type={COUNT_TYPE}>Courses: {stats.course_count}</ListItem>
    <ListItem type={SATISFACTION_TYPE}>
      Student satisfaction: {stats.satisfaction}
    </ListItem>
    <ListItem type={RELEVANT_TYPE}>
      Percent of graduates working in relevant industry:{' '}
      {stats.relevant_industry}%
    </ListItem>
  </div>
);

export default StudyProgramStats;
