import {Component} from '@angular/core'

@Component({
    selector: 'list-employee',
    templateUrl: './employeeList.component.html'
})

export class EmployeeList{
    employees = [
        {code:'emp101', name:'Tom', gender:'Male', salary:5500, dateOfBirth:'1987/02/12'},
        {code:'emp102', name:'Alex', gender:'Male', salary:5700, dateOfBirth:'1987/01/12'},
        {code:'emp103', name:'Mike', gender:'Male', salary:5900, dateOfBirth:'1980/02/12'},
        {code:'emp104', name:'Mary', gender:'Female', salary:6500, dateOfBirth:'1990/02/12'},
    ]
}