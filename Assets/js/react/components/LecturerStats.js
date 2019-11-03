import React from 'react';
import ListItem from './ListItem';
import {
  REVIEW_COUNT_TYPE,
  COMPETENCE_TYPE,
  OVERAL_TYPE,
  STRICTNESS_TYPE,
  DELIVERY_TYPE,
  PERSONALITY_TYPE,
} from '../config/types';

const LecturerStats = ({ stats }) => (
  <div className="list-group">
    <ListItem type={REVIEW_COUNT_TYPE}>Reviews: {stats.review_count}</ListItem>
    <ListItem type={COMPETENCE_TYPE}>Competence: {stats.competence}</ListItem>
    <ListItem type={OVERAL_TYPE}>Overal rating: {stats.overal}</ListItem>
    <ListItem type={STRICTNESS_TYPE}>Strictness: {stats.strictness}</ListItem>
    <ListItem type={DELIVERY_TYPE}>Delivery: {stats.delivery}</ListItem>
    <ListItem type={PERSONALITY_TYPE}>
      Personality: {stats.personality}
    </ListItem>
  </div>
);

export default LecturerStats;
