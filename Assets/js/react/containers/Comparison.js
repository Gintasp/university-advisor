import React from 'react';
import axios from 'axios';
import InputDropdown from '../components/InputDropdown';
import {
  TYPE_UNIVERSITY,
  TYPE_FACULTY,
  TYPE_PROGRAM,
  TYPE_COURSE,
  TYPE_LECTURER,
} from '../config/types';
import statsProvider from '../service/statsProvider';

class ComparisonContainer extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      items: [],
      filtered: [],
      selectedItem: null,
      searchValue: '',
      stats: null,
    };
  }

  componentDidMount() {
    axios
      .get('/api/items')
      .then(res => {
        this.setState({
          items: res.data,
        });
      })
      .catch(err => console.log(err));
  }

  handleSearchChange(value, timeout) {
    const { items } = this.state;
    this.setState({ searchValue: value });
    setTimeout(() => {
      if (value !== '') {
        this.setState({
          filtered: items.filter(item => {
            return item.Title.toLowerCase().includes(value.toLowerCase());
          }),
        });
      } else {
        this.setState({
          filtered: [],
        });
      }
    }, timeout);
  }

  handleItemClick(item) {
    this.setState({
      filtered: [],
      selectedItem: item,
      searchValue: '',
    });

    switch (item.Type) {
      case TYPE_UNIVERSITY:
        console.log(statsProvider.getUniversityData(item.Id));
        this.setState({
          stats: statsProvider.getUniversityData(item.Id),
        });
        break;
      case TYPE_FACULTY:
        this.setState({
          stats: statsProvider.getFacultyData(item.Id),
        });
        break;
      case TYPE_PROGRAM:
        this.setState({
          stats: statsProvider.getStudyProgramData(item.Id),
        });
        break;
      case TYPE_COURSE:
        this.setState({
          stats: statsProvider.getCourseData(item.Id),
        });
        break;
      case TYPE_LECTURER:
        this.setState({
          stats: statsProvider.getLecturerData(item.Id),
        });
        break;
    }
  }

  render() {
    const { filtered, searchValue } = this.state;

    return (
      <React.Fragment>
        <div className="mt-50">
          <h1>Compare</h1>
          <p>
            Choose and compare various universities, faculties, study programs,
            courses and lecturers to get valuable insights.
          </p>
        </div>
        <div>
          <input
            className="form-control"
            placeholder="Search for university, faculty, etc."
            value={searchValue}
            onChange={e => this.handleSearchChange(e.target.value, 1500)}
            onFocus={e => this.handleSearchChange(e.target.value, 0)}
          />
          <InputDropdown
            opened={filtered.length !== 0}
            items={filtered}
            onItemClick={item => this.handleItemClick(item)}
          />
        </div>
      </React.Fragment>
    );
  }
}

export default ComparisonContainer;
