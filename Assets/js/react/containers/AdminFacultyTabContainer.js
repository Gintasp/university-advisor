import React from 'react';
import axios from 'axios';
import AdminItemList from '../components/AdminItemList';
import {
  ALL_UNIVERSITIES_URL,
  ADD_FACULTY_URL,
  EDIT_FACULTY_URL,
  ALL_FACULTIES_URL,
} from '../config/adminRoutes';

class AdminFacultyTabContainer extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      faculties: this.props.faculties,
      universities: this.props.universities,
      editingId: '',
      editingTitle: '',
      newFacultyTitle: '',
      addSelectedUni: '',
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

  handleUniversityDelete(id) {
    const { faculties: universities } = this.state;
    const uniTitle = universities.filter(uni => uni.Id === id)[0].Title;
    if (confirm(`Are you sure you want to delete ${uniTitle}?`)) {
      console.log('Delete TO BE DONE');
    }
  }

  handleTitleChange(e) {
    this.setState({
      editingTitle: e.target.value,
    });
  }

  handleEditSubmit() {
    if (!this.state.editingTitle) {
      return;
    }

    axios
      .post(EDIT_FACULTY_URL, {
        Id: this.state.editingId,
        Title: this.state.editingTitle,
      })
      .then(res => {
        this.setState({
          faculties: res.data,
        });
        $('.close').trigger('click');
      })
      .catch(err => console.log(err));
  }

  handleEditUniversitySelect(item) {
    this.setState({
      editingId: item.Id,
      editingTitle: item.Title,
    });
  }

  handleNewTitle(e) {
    this.setState({
      newFacultyTitle: e.target.value,
    });
  }

  handleNewSubmit() {
    if (!this.state.newFacultyTitle) {
      return;
    }

    axios
      .post(ADD_FACULTY_URL, {
        Title: this.state.newFacultyTitle,
        UniversityId: this.state.addSelectedUni,
      })
      .then(res => {
        this.setState({
          faculties: res.data,
          newFacultyTitle: '',
        });
        $('.close').trigger('click');
      })
      .catch(err => console.log(err));
  }

  handleUniversitySelectChange(id) {
    axios
      .get(ALL_FACULTIES_URL)
      .then(res => {
        this.setState({
          faculties: res.data.filter(
            faculty => faculty.UniversityId === Number(id)
          ),
        });
      })
      .catch(err => console.log(err.response));
  }

  handleFilterReset() {
    this.fetchFaculties();
  }

  handleAddUniSelect(e) {
    this.setState({
      addSelectedUni: e.target.value,
    });
  }

  render() {
    return (
      <React.Fragment>
        <div className="admin-container mt-20">
          <div className="form-group">
            <label htmlFor="adminFaculties-university">Select university</label>
            <select
              onChange={e => this.handleUniversitySelectChange(e.target.value)}
              className="form-control"
              id="adminFaculties-university"
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
            <button
              className="btn btn-primary mt-20"
              onClick={() => this.handleFilterReset()}
            >
              Reset
            </button>
          </div>
          <AdminItemList
            target="#editFacultyModal"
            title="Faculties"
            onDelete={id => this.handleUniversityDelete(id)}
            onEditSelect={item => this.handleEditUniversitySelect(item)}
            items={this.state.faculties}
          />
          <button
            className="btn btn-primary mt-20"
            data-target="#addFacultyModal"
            data-toggle="modal"
          >
            Add Faculty
          </button>
        </div>

        <div
          className="modal fade"
          id="addFacultyModal"
          data-keyboard="false"
          data-backdrop="static"
        >
          <div className="modal-dialog modal-sm">
            <div className="modal-content">
              <div className="modal-header">
                <button type="button" className="close" data-dismiss="modal">
                  &times;
                </button>
                <h4 className="modal-title">Add Faculty</h4>
              </div>
              <div className="modal-body">
                <div className="form-group">
                  <label htmlFor="addFaculty-university">
                    Select university
                  </label>
                  <select
                    onChange={e => this.handleAddUniSelect(e)}
                    className="form-control"
                    id="addFaculty-university"
                  >
                    <option defaultChecked disabled hidden>
                      University
                    </option>
                    {this.state.universities.map(uni => (
                      <option value={uni.Id} key={uni.Id}>
                        {uni.Title}
                      </option>
                    ))}
                  </select>
                </div>
                <div className="form-group">
                  <label htmlFor="facultyTitle">Faculty title</label>
                  <input
                    className="form-control"
                    placeholder="Enter faculty title"
                    value={this.state.newFacultyTitle}
                    onChange={e => this.handleNewTitle(e)}
                    type="text"
                    id="facultyTitle"
                  />
                </div>
              </div>
              <div className="modal-footer">
                <button
                  onClick={() => this.handleNewSubmit()}
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
          id="editFacultyModal"
          data-keyboard="false"
          data-backdrop="static"
        >
          <div className="modal-dialog modal-sm">
            <div className="modal-content">
              <div className="modal-header">
                <button type="button" className="close" data-dismiss="modal">
                  &times;
                </button>
                <h4 className="modal-title">Edit Faculty</h4>
              </div>
              <div className="modal-body">
                <div className="form-group">
                  <label htmlFor="editFacultyTitle">Faculty Title</label>
                  <input
                    className="form-control"
                    type="text"
                    id="editFacultyTitle"
                    value={this.state.editingTitle}
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

export default AdminFacultyTabContainer;
