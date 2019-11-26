import React from 'react';
import axios from 'axios';
import AdminItemList from '../components/AdminItemList';
import {
  ALL_UNIVERSITIES_URL,
  ALL_FACULTIES_URL,
  FACULTY_BY_UNI_URL,
  ALL_COURSES_URL,
  ALL_LECTURERS_URL,
  EDIT_LECTURER_URL,
  ADD_LECTURER_URL,
  COURSES_BY_FACULTY_URL,
} from '../config/adminRoutes';

class AdminLecturerTabContainer extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      faculties: this.props.faculties,
      universities: this.props.universities,
      programs: this.props.programs,
      courses: this.props.courses,
      lecturers: this.props.lecturers,
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
      .post(EDIT_LECTURER_URL, {
        Id: this.state.editingId,
        Title: this.state.editingTitle,
      })
      .then(res => {
        this.setState({
          lecturers: res.data,
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
        FacultyId: this.state.newItem.FacultyId,
      },
    });
  }

  handleAddSubmit() {
    if (!this.state.newItem.Title || !this.state.newItem.Id) {
      return;
    }

    axios
      .post(ADD_LECTURER_URL, {
        Title: this.state.newItem.Title,
        Id: this.state.newItem.Id,
        FacultyId: this.state.newItem.FacultyId,
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
      .get(ALL_LECTURERS_URL)
      .then(res => {
        this.setState({
          lecturers: res.data.filter(
            lecturer => lecturer.UniversityId == Number(id)
          ),
        });

        axios
          .get(`${FACULTY_BY_UNI_URL}/${id}`)
          .then(res => {
            this.setState({
              faculties: res.data.filter(
                faculty => faculty.UniversityId == Number(id)
              ),
            });
          })
          .catch(err => console.log(err));
      })
      .catch(err => console.log(err.response));
  }

  handleFacultySelectChange(id) {
    this.setState({
      lecturers: this.state.lecturers.filter(
        lecturer => lecturer.FacultyId == Number(id)
      ),
    });
  }

  handleFilterReset() {
    axios
      .get(ALL_LECTURERS_URL)
      .then(res => {
        this.setState({
          lecturers: res.data,
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
        FacultyId: this.state.newItem.FacultyId,
      },
    });
  }

  handleAddUniversityChange(id) {
    this.handleUniversitySelectChange(id);
  }

  handleAddFacultyChange(id) {
    axios
      .get(`${COURSES_BY_FACULTY_URL}/${id}`)
      .then(res => {
        this.setState({
          courses: res.data,
          newItem: {
            Title: this.state.newItem.Title,
            Id: this.state.newItem.Id,
            FacultyId: id,
          },
        });
      })
      .catch(err => console.log(err));
  }

  handleAddCourseChange(id) {
    this.setState({
      newItem: {
        Title: this.state.newItem.Title,
        Id: id,
        FacultyId: this.state.newItem.FacultyId,
      },
    });
  }

  render() {
    return (
      <React.Fragment>
        <div className="admin-container">
          <div className="row">
            <div className="col-sm-4 mt-20">
              <div className="form-group">
                <label htmlFor="adminLecturers-university">
                  Select university
                </label>
                <select
                  onChange={e =>
                    this.handleUniversitySelectChange(e.target.value)
                  }
                  className="form-control"
                  id="adminLecturers-university"
                >
                  <option defaultChecked hidden>
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
                <label htmlFor="adminLecturers-faculty">Select faculty</label>
                <select
                  onChange={e => this.handleFacultySelectChange(e)}
                  className="form-control"
                  id="adminLecturers-faculty"
                >
                  <option defaultChecked hidden>
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
                className="button mt-20 mr-5"
                data-target="#addLecturerModal"
                data-toggle="modal"
              >
                Add Lecturer
              </button>
              <button
                onClick={() => this.handleFilterReset()}
                className="button mt-20"
              >
                Reset
              </button>
            </div>
            <div className="col-sm-8">
              <AdminItemList
                target="#editLecturerModal"
                title="Lecturers"
                items={this.state.lecturers}
                onDelete={() => this.handleDelete()}
                onEditSelect={item => this.handleEditClick(item)}
              />
            </div>
          </div>
        </div>

        <div
          className="modal fade"
          id="addLecturerModal"
          data-keyboard="false"
          data-backdrop="static"
        >
          <div className="modal-dialog modal-sm">
            <div className="modal-content">
              <div className="modal-header">
                <button type="button" className="close" data-dismiss="modal">
                  &times;
                </button>
                <h4 className="modal-title">Add lecturer</h4>
              </div>
              <div className="modal-body">
                <div className="form-group">
                  <label htmlFor="addLecturer-university">
                    Select university
                  </label>
                  <select
                    onChange={e =>
                      this.handleAddUniversityChange(e.target.value)
                    }
                    className="university-select form-control"
                    id="addLecturer-university"
                  >
                    <option defaultChecked hidden>
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
                  <label htmlFor="addLecturer-faculty">Select faculty</label>
                  <select
                    onChange={e => this.handleAddFacultyChange(e.target.value)}
                    className="form-control"
                    id="addLecturer-faculty"
                  >
                    <option defaultChecked hidden>
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
                  <label htmlFor="addLecturer-course">Select course</label>
                  <select
                    onChange={e => this.handleAddCourseChange(e.target.value)}
                    className="faculty-select form-control"
                    id="addLecturer-course"
                  >
                    <option defaultChecked hidden>
                      Course
                    </option>
                    {this.state.courses.map(course => (
                      <option key={course.Id} value={course.Id}>
                        {course.Title}
                      </option>
                    ))}
                  </select>
                </div>
                <div className="form-group">
                  <label htmlFor="lecturer-name">Lecturer's name/surname</label>
                  <input
                    value={this.state.newItem.Title}
                    onChange={e => this.handleAddTitleChange(e)}
                    className="form-control"
                    placeholder="Enter lecturer's name and surname"
                    type="text"
                    id="lecturer-name"
                  />
                </div>
              </div>
              <div className="modal-footer">
                <button
                  onClick={() => this.handleAddSubmit()}
                  type="submit"
                  className="button mr-10"
                >
                  Submit
                </button>
                <button
                  type="button"
                  className="button button-danger"
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
          id="editLecturerModal"
          data-keyboard="false"
          data-backdrop="static"
        >
          <div className="modal-dialog modal-sm">
            <div className="modal-content">
              <div className="modal-header">
                <button type="button" className="close" data-dismiss="modal">
                  &times;
                </button>
                <h4 className="modal-title">Edit Lecturer</h4>
              </div>
              <div className="modal-body">
                <div className="form-group">
                  <label htmlFor="editLecturer-name">Lecturer's fullname</label>
                  <input
                    value={this.state.editingTitle}
                    onChange={e => this.handleTitleChange(e)}
                    className="form-control"
                    type="text"
                    id="editLecturer-name"
                  />
                </div>
              </div>
              <div className="modal-footer">
                <button
                  onClick={() => this.handleEditSubmit()}
                  type="submit"
                  className="button mr-10"
                >
                  Submit
                </button>
                <button
                  type="button"
                  className="button button-danger"
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

export default AdminLecturerTabContainer;
