import { Injectable } from '@angular/core';
import { HttpClient, HttpResponse } from '@angular/common/http';
import { Observable } from 'rxjs';
import { stringify } from 'querystring';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class PlanetsService {
  /* private _url="http://localhost:5000/api/planet/Planets"; */
  /* npm start */
  private _url="/api/planet/Planets";

  constructor(private http: HttpClient) { }
  getPlanets() : Observable<Response>{

    return this.http.get<Response>(this._url)
  }
}
