import React from 'react';
import axios from 'axios';
import AdminItemList from '../components/AdminItemList';
import {
  ALL_UNIVERSITIES_URL,
  ADD_FACULTY_URL,
  EDIT_FACULTY_URL,
  ALL_FACULTIES_URL,
  ALL_PROGRAMS_URL,
  FACULTY_BY_UNI_URL,
  ADD_PROGRAM_URL,
} from '../config/adminRoutes';
import AdminFacultyTabContainer from './AdminFacultyTabContainer';

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
        UniversityId: '',
        FacultyId: '',
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
          programs: res.data,
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
        FacultyId: this.state.newItem.FacultyId,
        UniversityId: this.state.newItem.UniversityId,
      },
    });
  }

  handleAddSubmit() {
    if (!this.state.newItem.Title || !this.state.newItem.FacultyId) {
      return;
    }

    axios
      .post(ADD_PROGRAM_URL, {
        Title: this.state.newItem.Title,
        FacultyId: this.state.newItem.FacultyId,
      })
      .then(res => {
        this.setState({
          programs: res.data,
          newItem: {
            Title: '',
          },
        });
        $('.close').trigger('click');
        this.handleFilterReset();
      })
      .catch(err => console.log(err));
  }

  handleUniversitySelectChange(id) {
    axios
      .get(ALL_PROGRAMS_URL)
      .then(res => {
        this.setState({
          programs: res.data.filter(
            program => program.UniversityId === Number(id)
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
      .get(ALL_PROGRAMS_URL)
      .then(res => {
        this.setState({
          programs: res.data.filter(
            program => program.FacultyId === Number(id)
          ),
        });
      })
      .catch(err => console.log(err.response));
  }

  handleFilterReset() {
    axios
      .get(ALL_FACULTIES_URL)
      .then(res => {
        this.setState({
          faculties: res.data,
        });
        axios
          .get(ALL_PROGRAMS_URL)
          .then(res => {
            this.setState({ programs: res.data });
            this.fetchUniversities();
          })
          .catch(err => console.log(err));
      })
      .catch(err => console.log(err.response));
  }

  handleAddUniSelect(e) {
    this.handleUniversitySelectChange(e.target.value);
    this.setState({
      newItem: {
        UniversityId: e.target.value,
        FacultyId: this.state.newItem.FacultyId,
        Title: this.state.newItem.Title,
      },
    });
  }

  handleAddFacultySelect(e) {
    this.setState({
      newItem: {
        FacultyId: e.target.value,
        UniversityId: this.state.newItem.UniversityId,
        Title: this.state.newItem.Title,
      },
    });
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
                <select className="form-control" id="adminCourses-university">
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
                  <select className="form-control" id="addCourse-university">
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
                  <label htmlFor="addCourse-faculty">Select faculty</label>
                  <select className="form-control" id="addCourse-faculty">
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
                <div className="form-group">
                  <label htmlFor="addCourse-studyprogram">
                    Select study program
                  </label>
                  <select className="form-control" id="addCourse-studyprogram">
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
                    className="form-control"
                    placeholder="Enter course title"
                    type="text"
                    id="courseTitle"
                  />
                </div>
              </div>
              <div className="modal-footer">
                <button type="submit" className="btn btn-primary">
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
                <form>
                  <div className="form-group">
                    <label htmlFor="editCourseTitle">Course Title</label>
                    <input
                      className="form-control"
                      type="text"
                      id="editCourseTitle"
                    />
                  </div>
                </form>
              </div>
              <div className="modal-footer">
                <button type="submit" className="btn btn-primary">
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
