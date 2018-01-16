import { LeaveRequestService } from './../../services/leave-request.service';
import { Component, OnInit } from '@angular/core';
import { Position } from '../../models/position';

@Component({
  selector: 'app-leave-request-form',
  templateUrl: './leave-request-form.component.html',
  styleUrls: ['./leave-request-form.component.css']
})
export class LeaveRequestFormComponent implements OnInit {
  employees: any;
  positions: Position[];
  selectedPositionId: Number;
  availableEmployee: any[];

  constructor(private service: LeaveRequestService) {    
  }

  ngOnInit() {
    this.service.getEmployee().subscribe(emp => {
      this.employees = emp;
      this.positions = new Array<Position>();
      for(let e of this.employees) {       
        let existed = this.positions.some(p => p.getId() === e.position.id);
        if(!existed){         
          this.positions.push(new Position(e.position.id, e.position.title));
        }   
      }
    });
  }

  onTitleChange() {
    this.availableEmployee = [];
    for(let e of this.employees) {    
      if(Number(e.positionId) === Number(this.selectedPositionId)) {            
        this.availableEmployee.push(e);
      }
    }         
  }
}
