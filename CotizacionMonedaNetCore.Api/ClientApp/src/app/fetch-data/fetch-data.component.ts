import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
    selector: 'app-fetch-data',
    templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
    public forecasts: WeatherForecast;

    constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
        http.get<WeatherForecast>('https://csrng.net/csrng/csrng.php?min=0&max=100').subscribe(result => {
            this.forecasts = result;
        }, error => console.error('4' + error));
    }

    public ramdom()
    {
        return console.log(Math.round(Math.random() * 10));

    }
}

interface WeatherForecast {
    status: string;
    min: number;
    max: number;
    random: string;
}
