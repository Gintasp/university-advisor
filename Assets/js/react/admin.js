import React from 'react';
import ReactDOM from 'react-dom';
import axios from 'axios';
import AdminUniversityTabContainer from './containers/AdminUniversityTabContainer';
import AdminFacultyTabContainer from './containers/AdminFacultyTabContainer';
import { ALL_UNIVERSITIES_URL, ALL_FACULTIES_URL } from './config/adminRoutes';

let universities = [];
let faculties = [];
axios
  .get(ALL_UNIVERSITIES_URL)
  .then(res => {
    universities = res.data;
    ReactDOM.render(
      <AdminUniversityTabContainer universities={universities} />,
      document.getElementById('universityTab')
    );

    axios
      .get(ALL_FACULTIES_URL)
      .then(res => {
        faculties = res.data;
        ReactDOM.render(
          <AdminFacultyTabContainer
            faculties={faculties}
            universities={universities}
          />,
          document.getElementById('facultyTab')
        );
      })
      .catch(err => console.log(err));
  })
  .catch(err => console.log(err));
