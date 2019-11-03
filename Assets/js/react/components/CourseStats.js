import React from 'react';
import ListItem from './ListItem';
import {
  REVIEW_COUNT_TYPE,
  OVERAL_TYPE,
  DIFFICULTY_TYPE,
  SATISFACTION_TYPE,
  USEFULNESS_TYPE,
  INTERESTING_TYPE,
  THEORY_TYPE,
  PRACTICE_TYPE,
} from '../config/types';

const CourseStats = ({ stats }) => (
  <div className="list-group">
    <ListItem type={REVIEW_COUNT_TYPE}>Reviews: {stats.review_count}</ListItem>
    <ListItem type={OVERAL_TYPE}>Overal rating: {stats.overal}</ListItem>
    <ListItem type={DIFFICULTY_TYPE}>Difficulty: {stats.difficulty}</ListItem>
    <ListItem type={SATISFACTION_TYPE}>
      Student satisfaction: {stats.satisfaction}
    </ListItem>
    <ListItem type={USEFULNESS_TYPE}>Usefulness: {stats.usefulness}</ListItem>
    <ListItem type={INTERESTING_TYPE}>
      Interesting: {stats.interesting}
    </ListItem>
    <ListItem type={THEORY_TYPE}>
      Percent of theory material {stats.theory}%
    </ListItem>
    <ListItem type={PRACTICE_TYPE}>
      Percent of practice material {stats.practice}%
    </ListItem>
  </div>
);

export default CourseStats;
