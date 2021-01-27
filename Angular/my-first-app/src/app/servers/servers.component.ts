import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-servers',
  templateUrl: './servers.component.html',
  styleUrls: ['./servers.component.css']
})


export class ServersComponent implements OnInit {


  isActive = true;
  serverCreationStatus = "No server has been created!"
  serverNameUpdate = ""
  userName ="Usre1"


  constructor() {
    setTimeout(() => {
      this.isActive = false;
    }, 1500);
   }


   onServerCreation(){
     this.serverCreationStatus = "A New Server has been created"
 }


 onServerNameUpdate(event:any){
  this.serverNameUpdate = event.target.value
 }


  ngOnInit(): void {
  }
}
