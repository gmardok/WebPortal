import { HttpClient } from "@angular/common/http";
import { WeatherForecast } from "../models/weatherforecast";
import { Injectable } from "@angular/core";

import { protectedResources } from '../auth-config';

@Injectable({
  providedIn: 'root'
})
export class WeatherForecastService {
  url = protectedResources.apiTodoList.endpoint;

  constructor(private http: HttpClient) { }

  getAll() {
    return this.http.get<WeatherForecast[]>(this.url + '/weatherforecast');
  }

}
