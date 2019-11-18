import React from 'react';
import axios from 'axios';
import AdminItemList from '../components/AdminItemList';
import {
  ALL_UNIVERSITIES_URL,
  EDIT_FACULTY_URL,
  ALL_FACULTIES_URL,
  FACULTY_BY_UNI_URL,
  ADD_PROGRAM_URL,
  ALL_COURSES_URL,
  ADD_COURSE_URL,
  PROGRAM_BY_UNI_URL,
} from '../config/adminRoutes';

class AdminCourseTabContainer extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      faculties: this.props.faculties,
      universities: this.props.universities,
      programs: this.props.programs,
      courses: this.props.courses,
      editingId: '',
      editingTitle: '',
      newItem: {
        Title: '',
        Id: '',
      },
    };
  }

  fetchUniversities() {
    axios
      .get(ALL_UNIVERSITIES_URL)
      .then(res => {
        this.setState({
          universities: res.data,
        });
      })
      .catch(err => console.log(err.response));
  }

  fetchFaculties() {
    axios
      .get(ALL_FACULTIES_URL)
      .then(res => {
        this.setState({
          faculties: res.data,
        });
      })
      .catch(err => console.log(err.response));
  }

  handleDelete(id) {
    //TODO: implement deleting
  }

  handleTitleChange(e) {
    this.setState({
      editingTitle: e.target.value,
    });
  }

  handleEditSubmit() {
    if (!this.state.editingTitle || !this.state.editingId) {
      return;
    }

    axios
      .post(EDIT_FACULTY_URL, {
        Id: this.state.editingId,
        Title: this.state.editingTitle,
      })
      .then(res => {
        this.setState({
          courses: res.data,
        });
        $('.close').trigger('click');
      })
      .catch(err => console.log(err));
  }

  handleEditClick(item) {
    this.setState({
      editingId: item.Id,
      editingTitle: item.Title,
    });
  }

  handleAddTitleChange(e) {
    this.setState({
      newItem: {
        Title: e.target.value,
        Id: this.state.newItem.Id,
      },
    });
  }

  handleAddSubmit() {
    if (!this.state.newItem.Title || !this.state.newItem.Id) {
      return;
    }

    axios
      .post(ADD_COURSE_URL, {
        Title: this.state.newItem.Title,
        Id: this.state.newItem.Id,
      })
      .then(res => {
        this.setState({
          courses: res.data,
          newItem: {
            Title: '',
            Id: '',
          },
        });
        $('.close').trigger('click');
        this.handleFilterReset();
      })
      .catch(err => console.log(err));
  }

  handleUniversitySelectChange(id) {
    axios
      .get(ALL_COURSES_URL)
      .then(res => {
        this.setState({
          courses: res.data.filter(
            course => course.UniversityId === Number(id)
          ),
        });
      })
      .catch(err => console.log(err.response));

    axios
      .get(`${FACULTY_BY_UNI_URL}/${id}`)
      .then(res => {
        this.setState({
          faculties: res.data,
        });
      })
      .catch(err => console.log(err));
  }

  handleFacultySelectChange(id) {
    axios
      .get(ALL_COURSES_URL)
      .then(res => {
        this.setState({
          courses: res.data.filter(course => course.FacultyId === Number(id)),
        });
      })
      .catch(err => console.log(err.response));
  }

  handleFilterReset() {
    axios
      .get(ALL_COURSES_URL)
      .then(res => {
        this.setState({
          courses: res.data,
        });
        axios
          .get(ALL_FACULTIES_URL)
          .then(res => {
            this.setState({ faculties: res.data });
            this.fetchUniversities();
          })
          .catch(err => console.log(err));
      })
      .catch(err => console.log(err.response));
  }

  handleAddProgramSelect(id) {
    this.setState({
      newItem: {
        Id: id,
        Title: this.state.newItem.Title,
      },
    });
  }

  handleAddUniversityChange(id) {
    this.handleUniversitySelectChange(id);
    axios
      .get(`${PROGRAM_BY_UNI_URL}/${id}`)
      .then(res => {
        this.setState({
          programs: res.data,
        });
      })
      .catch(err => console.log(err));
  }

  render() {
    return (
      <React.Fragment>
        <div className="admin-container">
          <div className="row">
            <div className="col-sm-12 mt-20">
              <div className="col-sm-4 form-group">
                <label htmlFor="adminCourses-university">
                  Select university
                </label>
                <select
                  onChange={e =>
                    this.handleUniversitySelectChange(e.target.value)
                  }
                  className="form-control"
                  id="adminCourses-university"
                >
                  <option defaultChecked disabled hidden>
                    University
                  </option>
                  {this.state.universities.map(uni => (
                    <option key={uni.Id} value={uni.Id}>
                      {uni.Title}
                    </option>
                  ))}
                </select>
              </div>
              <div className="col-sm-4 form-group">
                <label htmlFor="adminCourses-faculty">Select faculty</label>
                <select className="form-control" id="adminCourses-faculty">
                  <option defaultChecked disabled hidden>
                    Faculty
                  </option>
                  {this.state.faculties.map(faculty => (
                    <option key={faculty.Id} value={faculty.Id}>
                      {faculty.Title}
                    </option>
                  ))}
                </select>
              </div>
              <button
                className="btn btn-primary mt-20"
                onClick={() => this.handleFilterReset()}
              >
                Reset
              </button>
            </div>
            <div className="col-sm-12">
              <AdminItemList
                target="#editCourseModal"
                title="Courses"
                items={this.state.courses}
                onDelete={() => this.handleDelete()}
                onEditSelect={course => this.handleEditClick(course)}
              />
              <button
                className="btn btn-primary mt-20"
                data-target="#addCourseModal"
                data-toggle="modal"
              >
                Add Course
              </button>
            </div>
          </div>
        </div>
        <div
          className="modal fade"
          id="addCourseModal"
          data-keyboard="false"
          data-backdrop="static"
        >
          <div className="modal-dialog modal-sm">
            <div className="modal-content">
              <div className="modal-header">
                <button type="button" className="close" data-dismiss="modal">
                  &times;
                </button>
                <h4 className="modal-title">Add Course</h4>
              </div>
              <div className="modal-body">
                <div className="form-group">
                  <label htmlFor="addCourse-university">
                    Select university
                  </label>
                  <select
                    onChange={e =>
                      this.handleAddUniversityChange(e.target.value)
                    }
                    className="form-control"
                    id="addCourse-university"
                  >
                    <option defaultChecked disabled hidden>
                      University
                    </option>
                    {this.state.universities.map(uni => (
                      <option key={uni.Id} value={uni.Id}>
                        {uni.Title}
                      </option>
                    ))}
                  </select>
                </div>
                <div className="form-group">
                  <label htmlFor="addCourse-studyprogram">
                    Select study program
                  </label>
                  <select
                    onChange={e => this.handleAddProgramSelect(e.target.value)}
                    className="form-control"
                    id="addCourse-studyprogram"
                  >
                    <option defaultChecked disabled hidden>
                      Study Program
                    </option>
                    {this.state.programs.map(program => (
                      <option key={program.Id} value={program.Id}>
                        {program.Title}
                      </option>
                    ))}
                  </select>
                </div>
                <div className="form-group">
                  <label htmlFor="courseTitle">Course title</label>
                  <input
                    value={this.state.newItem.Title}
                    onChange={e => this.handleAddTitleChange(e)}
                    className="form-control"
                    placeholder="Enter course title"
                    type="text"
                    id="courseTitle"
                  />
                </div>
              </div>
              <div className="modal-footer">
                <button
                  onClick={() => this.handleAddSubmit()}
                  type="submit"
                  className="btn btn-primary"
                >
                  Submit
                </button>
                <button
                  type="button"
                  className="btn btn-primary"
                  data-dismiss="modal"
                >
                  Cancel
                </button>
              </div>
            </div>
          </div>
        </div>

        <div
          className="modal fade"
          id="editCourseModal"
          data-keyboard="false"
          data-backdrop="static"
        >
          <div className="modal-dialog modal-sm">
            <div className="modal-content">
              <div className="modal-header">
                <button type="button" className="close" data-dismiss="modal">
                  &times;
                </button>
                <h4 className="modal-title">Edit Course</h4>
              </div>
              <div className="modal-body">
                <div className="form-group">
                  <label htmlFor="editCourseTitle">Course Title</label>
                  <input
                    value={this.state.editingTitle}
                    className="form-control"
                    type="text"
                    id="editCourseTitle"
                    onChange={e => this.handleTitleChange(e)}
                  />
                </div>
              </div>
              <div className="modal-footer">
                <button
                  onClick={() => this.handleEditSubmit()}
                  type="submit"
                  className="btn btn-primary"
                >
                  Submit
                </button>
                <button
                  type="button"
                  className="btn btn-primary"
                  data-dismiss="modal"
                >
                  Cancel
                </button>
              </div>
            </div>
          </div>
        </div>
      </React.Fragment>
    );
  }
}

export default AdminCourseTabContainer;
