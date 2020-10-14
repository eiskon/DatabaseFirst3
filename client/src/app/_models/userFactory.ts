import { User } from './user';

export class UserFactory {
    static empty(): User {
        return {
            employeeId: null,
            userName: ''
        }
    }
}
