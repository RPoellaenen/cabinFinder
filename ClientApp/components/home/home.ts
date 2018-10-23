﻿

@Component
export default class FetchDataComponent extends Vue {
    forecasts: WeatherForecast[] = [];

    mounted() {
        fetch('api/SampleData/WeatherForecasts')
            .then(response => response.json() as Promise<WeatherForecast[]>)
            .then(data => {
                this.forecasts = data;
            });
    }
}