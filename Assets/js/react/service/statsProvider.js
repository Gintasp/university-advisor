import axios from 'axios';

class StatsProvider {
  getUniversityData(id) {
    axios
      .get(`/api/stats/university/${id}`)
      .then(res => console.log(res.data))
      .catch(err => console.log(err));
  }
}

export default new StatsProvider();
