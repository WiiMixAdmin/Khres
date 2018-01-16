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

  constructor(private service: LeaveRequestService) {    
  }

  ngOnInit() {
    this.service.getEmployee().subscribe(emp => {
      this.employees = emp;
      this.positions = new Array<Position>();
      for(let e of this.employees) {       
        let existed = this.positions.some(p => p.getId() === e.position.id);
        if(!existed){
          let pos = new Position(e.position.id, e.position.title);
          this.positions.push(pos);
        }   
      }
    });
  }

  onTitleChange() {
    console.log("change");
  }

}
