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
import StatsContainer from '../components/StatsContainer';

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

  async handleItemClick(item) {
    this.setState({
      filtered: [],
      selectedItem: item,
      searchValue: '',
    });

    switch (item.Type) {
      case TYPE_UNIVERSITY:
        let response = await statsProvider.getUniversityData(item.Id);
        this.setState({
          stats: response.data,
        });
        break;
      case TYPE_FACULTY:
        response = await statsProvider.getFacultyData(item.Id);
        this.setState({
          stats: response.data,
        });
        break;
      case TYPE_PROGRAM:
        response = await statsProvider.getStudyProgramData(item.Id);
        this.setState({
          stats: response.data,
        });
        break;
      case TYPE_COURSE:
        response = await statsProvider.getCourseData(item.Id);
        this.setState({
          stats: response.data,
        });
        break;
      case TYPE_LECTURER:
        response = await statsProvider.getLecturerData(item.Id);
        this.setState({
          stats: response.data,
        });
        break;
    }
  }

  handleDropdownClose() {
    this.setState({
      filtered: [],
    });
  }

  render() {
    const { filtered, searchValue, stats, selectedItem } = this.state;

    return (
      <React.Fragment>
        <div className="mt-50">
          <h1>Compare</h1>
          <p>
            Choose and compare various universities, faculties, study programs,
            courses and lecturers to get valuable insights.
          </p>
        </div>
        <div className="d-flex">
          <div className="w-50 ph-10">
            <div>
              <input
                className="form-control m-w-unset"
                placeholder="Search for university, faculty, etc."
                value={searchValue}
                onChange={e => this.handleSearchChange(e.target.value, 1500)}
                onFocus={e => this.handleSearchChange(e.target.value, 0)}
              />
              <InputDropdown
                opened={filtered.length !== 0}
                items={filtered}
                onItemClick={item => this.handleItemClick(item)}
                onClose={() => this.handleDropdownClose()}
              />
            </div>
            <div className="mt-20">
              {stats && (
                <StatsContainer data={stats} type={selectedItem.Type} />
              )}
            </div>
          </div>
        </div>
      </React.Fragment>
    );
  }
}

export default ComparisonContainer;
