import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { AddEmployee } from "../models/employee/addemployee";
import { UpdateEmployee } from "../models/employee/updateemployee";
import { Employee } from "../models/employee/employee";

@Injectable({ providedIn: "root" })
export class EmpService {
    constructor(
        private readonly http: HttpClient) { }

    add(addEmployee: AddEmployee) {
        return this.http.post<number>(`Employees`, addEmployee);
    }

    delete(employeeId: number) {
        return this.http.delete(`Employees/${employeeId}`);
    }

    list() {
        return this.http.get<Employee[]>(`Employees`);
    }

    select(employeeId: number) {
        return this.http.get<Employee>(`Employees/${employeeId}`);
    }


    update(updateEmployee: UpdateEmployee) {
        return this.http.put(`Users/${updateEmployee.employeeId}`, updateEmployee);
    }
}

