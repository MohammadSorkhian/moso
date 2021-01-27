import { Component } from '@angular/core';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent {
  pageHeader = 'Employee Details'
  name = "MoSo"
  isDesabled = true;
  active_btn_primary = false
  btn_info = 'btn-info'
  sum = 0
  nameOther = 'Tom'

  changeClass(){
    let classes = {
      btn: false,
      'btn-danger': true
    }
    return classes
  }

  onClick(){
    this.sum = this.sum +1
  }


}
