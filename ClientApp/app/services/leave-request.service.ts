import { Http } from '@angular/http';
import { Injectable } from '@angular/core';
import 'rxjs/add/operator/map';

@Injectable()
export class LeaveRequestService {

constructor(private http: Http) { 
   
}

getEmployee() {
    return this.http.get('/api/employees').map(res => res.json());
}

}