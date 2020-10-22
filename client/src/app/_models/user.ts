import { Employe } from './employe';

export interface User {
    id: number;
    employeeId: number;
    userName: string;
    employees?: Employe[];
    roles?: string[];
}