import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-servers',
  templateUrl: './servers.component.html',
  styleUrls: ['./servers.component.css']
})
export class ServersComponent implements OnInit {
  isActive = true;
  constructor() {
    setTimeout(() => {
      this.isActive = false;
    }, 1500);


   }

  ngOnInit(): void {
  }

}
