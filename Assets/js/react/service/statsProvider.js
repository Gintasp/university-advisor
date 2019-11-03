import axios from 'axios';
import '@babel/polyfill';
import {
  STATS_UNIVERSITY_URL,
  STATS_FACULTY_URL,
  STATS_PROGRAM_URL,
  STATS_COURSE_URL,
  STATS_LECTURER_URL,
} from '../config/routes';

class StatsProvider {
  getUniversityData(id) {
    return this.fetchUrl(`${STATS_UNIVERSITY_URL}/${id}`);
  }

  getFacultyData(id) {
    return this.fetchUrl(`${STATS_FACULTY_URL}/${id}`);
  }

  getStudyProgramData(id) {
    return this.fetchUrl(`${STATS_PROGRAM_URL}/${id}`);
  }

  getCourseData(id) {
    return this.fetchUrl(`${STATS_COURSE_URL}/${id}`);
  }

  getLecturerData(id) {
    return this.fetchUrl(`${STATS_LECTURER_URL}/${id}`);
  }

  fetchUrl(url) {
    return axios.get(url);
  }
}

export default new StatsProvider();
