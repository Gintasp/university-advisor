import {
  COUNT_TYPE,
  REVIEW_COUNT_TYPE,
  OVERAL_TYPE,
  SALARY_TYPE,
  SATISFACTION_TYPE,
  RELEVANT_TYPE,
  DIFFICULTY_TYPE,
  USEFULNESS_TYPE,
  INTERESTING_TYPE,
  THEORY_TYPE,
  PRACTICE_TYPE,
  COMPETENCE_TYPE,
  STRICTNESS_TYPE,
  DELIVERY_TYPE,
  PERSONALITY_TYPE,
} from '../config/types';

class IconClassResolver {
  resolveIconClass(type) {
    let iconClass = '';

    switch (type) {
      case COUNT_TYPE:
        iconClass = 'fa-hashtag';
        break;
      case REVIEW_COUNT_TYPE:
        iconClass = 'fa-pencil-alt';
        break;
      case OVERAL_TYPE:
        iconClass = 'fa-star';
        break;
      case SALARY_TYPE:
        iconClass = 'fa-euro-sign';
        break;
      case SATISFACTION_TYPE:
        iconClass = 'fa-smile';
        break;
      case RELEVANT_TYPE:
        iconClass = 'fa-briefcase';
        break;
      case DIFFICULTY_TYPE:
        iconClass = 'fa-hand-rock';
        break;
      case USEFULNESS_TYPE:
        iconClass = 'fa-user-check';
        break;
      case INTERESTING_TYPE:
        iconClass = 'fa-laugh-wink';
        break;
      case THEORY_TYPE:
        iconClass = 'fa-square-root-alt';
        break;
      case PRACTICE_TYPE:
        iconClass = 'fa-cogs';
        break;
      case COMPETENCE_TYPE:
        iconClass = 'fa-tasks';
        break;
      case STRICTNESS_TYPE:
        iconClass = 'fa-angry';
        break;
      case DELIVERY_TYPE:
        iconClass = 'fa-grin';
        break;
      case PERSONALITY_TYPE:
        iconClass = 'fa-user-tie';
        break;
    }

    return iconClass;
  }
}

export default new IconClassResolver();
