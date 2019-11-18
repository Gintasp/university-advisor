import React from 'react';
import ReactDOM from 'react-dom';
import axios from 'axios';
import AdminUniversityTabContainer from './containers/AdminUniversityTabContainer';
import AdminFacultyTabContainer from './containers/AdminFacultyTabContainer';
import {
  ALL_UNIVERSITIES_URL,
  ALL_FACULTIES_URL,
  ALL_PROGRAMS_URL,
  ALL_COURSES_URL,
  ALL_LECTURERS_URL,
} from './config/adminRoutes';
import AdminStudyProgramTabContainer from './containers/AdminStudyProgramTabContainer';
import AdminCourseTabContainer from './containers/AdminCourseTabContainer';
import AdminLecturerTabContainer from './containers/AdminLecturerTabContainer';

let universities = [];
let faculties = [];
let programs = [];
let courses = [];
let lecturers = [];

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

        axios.get(ALL_PROGRAMS_URL).then(res => {
          programs = res.data;
          ReactDOM.render(
            <AdminStudyProgramTabContainer
              universities={universities}
              faculties={faculties}
              programs={programs}
            />,
            document.getElementById('studyProgramTab')
          );

          axios.get(ALL_COURSES_URL).then(res => {
            courses = res.data;
            ReactDOM.render(
              <AdminCourseTabContainer
                courses={courses}
                programs={programs}
                faculties={faculties}
                universities={universities}
              />,
              document.getElementById('courseTab')
            );

            axios.get(ALL_LECTURERS_URL).then(res => {
              lecturers = res.data;
              ReactDOM.render(
                <AdminLecturerTabContainer
                  courses={courses}
                  programs={programs}
                  faculties={faculties}
                  universities={universities}
                  lecturers={lecturers}
                />,
                document.getElementById('lecturerTab')
              );
            });
          });
        });
      })
      .catch(err => console.log(err));
  })
  .catch(err => console.log(err));
