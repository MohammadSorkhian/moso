import { PipeTransform ,Pipe } from "@angular/core";

@Pipe({
    name: 'employeeTitle'
})

export class EmployeeTitlePipe implements PipeTransform{

    transform(value:string, gender:string) {
        if(gender.toLocaleLowerCase() == 'male'){
            return 'Mr. ' + value;
        }else{
            return 'Miss. ' + value;
        }
    }
}