import { LeaveRequestService } from './../../services/leave-request.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-leave-request-form',
  templateUrl: './leave-request-form.component.html',
  styleUrls: ['./leave-request-form.component.css']
})
export class LeaveRequestFormComponent implements OnInit {
  employees: any[];
  positions: any[];
  selectedPositionId: Number;
  availableEmployee: any[];

  constructor(private service: LeaveRequestService) {    
  }

  ngOnInit() {
    this.service.getEmployee().subscribe(emp => {
      this.employees = emp;
      var r = this.pluckProperty(this.employees, 'position');
      this.positions = this.distinctById(r);     
    });
  }

  private pluckProperty(sources:any[], propertyName:string) {
    let result:any[] = [];
    for(let e of sources) {
        if(e[propertyName])    
          result.push(e[propertyName]);   
    }    
    return result;
  }

  private distinctById(sources:any[]) {
    let result:any[] = [];
    for(let p of sources) {
      if(!result.some(x => x.id === p.id)) {
        result.push(p);
      }
    }
    return result;
  }

  onTitleChange() {
    this.availableEmployee = [];
    this.availableEmployee = this.employees.filter(e => Number(e.positionId) === Number(this.selectedPositionId));                
  }
}
