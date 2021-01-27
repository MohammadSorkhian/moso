import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms'
import { AppComponent } from './app.component';
import {EmployeeComponent} from './employee/employee.component';
import {EmployeeList} from './employeeList/employeeList.component'

@NgModule({
  declarations: [
    AppComponent,
    EmployeeComponent,
    EmployeeList,
  ],
  imports: [
    BrowserModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
