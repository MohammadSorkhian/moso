import {Component} from '@angular/core'

@Component({
    selector: 'list-employee',
    templateUrl: './employeeList.component.html'
})


export class EmployeeList{

    selectedEmployeeCountRadioButton = 'All'

    employees = [
        {code:'emp101', name:'Tom', gender:'Male', salary:5500, dateOfBirth:'1987/02/12'},
        {code:'emp102', name:'Alex', gender:'Male', salary:5700, dateOfBirth:'1987/01/12'},
        {code:'emp103', name:'Mike', gender:'Male', salary:5900, dateOfBirth:'1980/02/12'},
        {code:'emp104', name:'Mary', gender:'Female', salary:6500, dateOfBirth:'1990/02/12'},
    ]

    getNumOFEmployees(){
        return this.employees.length;
    }

    getNumberOfMales(){
        return this.employees.filter(e => e.gender.toLowerCase() === 'male').length;
    }

    getNumberOfFemales(){
        return this.employees.filter(e => e.gender.toLocaleLowerCase() === 'female').length;
    }

    onEmployeeCountRadioButtonChange(selectedRadioButtonValue : string){
        this.selectedEmployeeCountRadioButton = selectedRadioButtonValue
    }
}