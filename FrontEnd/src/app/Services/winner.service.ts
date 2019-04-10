import { Injectable } from '@angular/core';
import { HttpClient, HttpResponse } from '@angular/common/http';
import { Observable } from 'rxjs';
import { stringify } from 'querystring';
import { environment } from 'src/environments/environment';
import { WinnerResponse } from '../Models/winner-response';

@Injectable({
  providedIn: 'root'
})
export class WinnerService {
  /* private _url="http://localhost:5000/api/planet/Planets"; */
  /* npm start */
  private _url="/api/battle/StartBattle";

  constructor(private http: HttpClient) { }
  getWinner() : Observable<WinnerResponse>{

    return this.http.get<WinnerResponse>(this._url)
  }
}
