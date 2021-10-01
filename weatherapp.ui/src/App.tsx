import React from 'react';
import './App.css';

export default class App extends React.Component {
    
  state = {
      loading: true,
      weather: {
        location: null,
        temparature: null,
        feelsLike: null,
        temparatureMin: null,
        temparatureMax: null,
        pressure: null,
        humidity: null,
        shortDescription: null,
        description: null,
        iconId: "",
      },
  }
  
  async componentDidMount(){
      const url = "https://localhost:7258/api/weather/currentWeather";
      const response = await fetch(url);

      const data = await response.json();
      this.setState({loading:  false, 
        weather: data});
    }

  render() {
    if (this.state.loading){
      return <div className="App-header">Loading...</div>;
    }

    if(!this.state.weather){
      return <div className="App-header">No weather available data available...</div>;
    }

      return (
        <div className="App-header">
        <img className="App-logo" src={this.state.weather.iconId} />
        <div>{this.state.weather.location}</div>
        <div>{this.state.weather.temparature} °C</div>
        <div>{this.state.weather.shortDescription}</div>
      </div>
      );
  }
}