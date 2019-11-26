import React from 'react';
import axios from 'axios';
import AdminItemList from '../components/AdminItemList';
import {
  ALL_UNIVERSITIES_URL,
  EDIT_UNIVERSITY_URL,
  ADD_UNIVERSITY_URL,
} from '../config/adminRoutes';

class AdminUniversityTabContainer extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      universities: this.props.universities,
      editingId: '',
      editingTitle: '',
      newUniversityTitle: '',
    };
  }

  handleUniversityDelete(id) {
    const { universities } = this.state;
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

  handleUniversityEditSubmit() {
    if (!this.state.editingTitle) {
      return;
    }

    axios
      .post(EDIT_UNIVERSITY_URL, {
        Id: this.state.editingId,
        Title: this.state.editingTitle,
      })
      .then(res => {
        this.setState({
          universities: res.data,
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

  handleNewUniversityTitle(e) {
    this.setState({
      newUniversityTitle: e.target.value,
    });
  }

  handleNewUniversitySubmit() {
    if (!this.state.newUniversityTitle) {
      return;
    }

    axios
      .post(ADD_UNIVERSITY_URL, {
        Title: this.state.newUniversityTitle,
      })
      .then(res => {
        this.setState({
          universities: res.data,
          newUniversityTitle: '',
        });
        $('.close').trigger('click');
      })
      .catch(err => console.log(err));
  }

  render() {
    const { universities, editingTitle } = this.state;

    return (
      <React.Fragment>
        <div className="admin-container mt-20">
          <AdminItemList
            target="#editUniversityModal"
            items={universities}
            title="Universities"
            onEditSelect={item => this.handleEditUniversitySelect(item)}
            onDelete={id => this.handleUniversityDelete(id)}
          />
          <button
            className="button mt-20"
            data-target="#addUniversityModal"
            data-toggle="modal"
          >
            Add University
          </button>
        </div>

        <div
          className="modal fade"
          id="addUniversityModal"
          data-keyboard="false"
          data-backdrop="static"
        >
          <div className="modal-dialog modal-sm">
            <div className="modal-content">
              <div className="modal-header">
                <button type="button" className="close" data-dismiss="modal">
                  &times;
                </button>
                <h4 className="modal-title">Add University</h4>
              </div>
              <div className="modal-body">
                <div className="form-group">
                  <label htmlFor="universityTitle">University Title</label>
                  <input
                    className="form-control"
                    placeholder="Enter university title"
                    value={this.state.newUniversityTitle}
                    onChange={e => this.handleNewUniversityTitle(e)}
                    type="text"
                    id="universityTitle"
                  />
                </div>
              </div>
              <div className="modal-footer">
                <button
                  onClick={() => this.handleNewUniversitySubmit()}
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
          id="editUniversityModal"
          data-keyboard="false"
          data-backdrop="static"
        >
          <div className="modal-dialog modal-sm">
            <div className="modal-content">
              <div className="modal-header">
                <button type="button" className="close" data-dismiss="modal">
                  &times;
                </button>
                <h4 className="modal-title">Edit University</h4>
              </div>
              <div className="modal-body">
                <div className="form-group">
                  <label htmlFor="editUniversityTitle">University Title</label>
                  <input
                    className="form-control"
                    type="text"
                    id="editUniversityTitle"
                    onChange={e => this.handleTitleChange(e)}
                    value={editingTitle}
                  />
                </div>
              </div>
              <div className="modal-footer">
                <button
                  onClick={() => this.handleUniversityEditSubmit()}
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

export default AdminUniversityTabContainer;
