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

class AdminStudyProgramTabContainer extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      faculties: this.props.faculties,
      universities: this.props.universities,
      programs: this.props.programs,
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
        <div className="admin-container mt-20">
          <div className="row">
            <div className="col-sm-4 form-group">
              <label htmlFor="adminStudyPrograms-university">
                Select university
              </label>
              <select
                onChange={e =>
                  this.handleUniversitySelectChange(e.target.value)
                }
                className="university-select form-control"
                id="adminStudyPrograms-university"
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
            <div className="col-sm-4 form-group">
              <label htmlFor="adminStudyPrograms-faculty">Select faculty</label>
              <select
                onChange={e => this.handleFacultySelectChange(e.target.value)}
                className="faculty-select form-control"
                id="adminStudyPrograms-faculty"
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
            <div className="col-sm-4 form-group">
                <button
                    className="button mt-20"
                    onClick={() => this.handleFilterReset()}
                >
                Reset
                </button>
            </div>
            <div className="col-sm-12">
              <AdminItemList
                onEditSelect={program => this.handleEditClick(program)}
                onDelete={() => this.handleDelete()}
                target="#editStudyProgramModal"
                title="Study programs"
                items={this.state.programs}
              />
              <button
                className="button mt-20"
                data-target="#addStudyProgramModal"
                data-toggle="modal"
              >
                Add Study Program
              </button>
            </div>
          </div>
          <div
            className="modal fade"
            id="addStudyProgramModal"
            data-keyboard="false"
            data-backdrop="static"
          >
            <div className="modal-dialog modal-sm">
              <div className="modal-content">
                <div className="modal-header">
                  <button type="button" className="close" data-dismiss="modal">
                    &times;
                  </button>
                  <h4 className="modal-title">Add Study Program</h4>
                </div>
                <div className="modal-body">
                  <div className="form-group">
                    <label htmlFor="addStudyProgram-university">
                      Select university
                    </label>
                    <select
                      onChange={e => this.handleAddUniSelect(e)}
                      className="form-control"
                      id="addStudyProgram-university"
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
                    <label htmlFor="addStudyProgram-faculty">
                      Select faculty
                    </label>
                    <select
                      onChange={e => this.handleAddFacultySelect(e)}
                      className="form-control"
                      id="addStudyProgram-faculty"
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
                    <label htmlFor="studyProgramTitle">
                      Study program title
                    </label>
                    <input
                      value={this.state.newItem.Title}
                      onChange={e => this.handleAddTitleChange(e)}
                      className="form-control"
                      placeholder="Enter study program title"
                      type="text"
                      id="studyProgramTitle"
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
        </div>

        <div
          className="modal fade"
          id="editStudyProgramModal"
          data-keyboard="false"
          data-backdrop="static"
        >
          <div className="modal-dialog modal-sm">
            <div className="modal-content">
              <div className="modal-header">
                <button type="button" className="close" data-dismiss="modal">
                  &times;
                </button>
                <h4 className="modal-title">Edit Study Program</h4>
              </div>
              <div className="modal-body">
                <div className="form-group">
                  <label htmlFor="editStudyProgramTitle">
                    Study Program Title
                  </label>
                  <input
                    onChange={e => this.handleTitleChange(e)}
                    value={this.state.editingTitle}
                    className="form-control"
                    type="text"
                    id="editStudyProgramTitle"
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

export default AdminStudyProgramTabContainer;
