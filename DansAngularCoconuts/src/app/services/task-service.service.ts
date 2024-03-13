import { Injectable } from '@angular/core';
import { Task } from '../interfaces/Task';
import { TASKS } from '../mock-data/mock-tasks';
import { Observable, of } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class TaskServiceService {

  constructor() { }

  getTasks(): Observable<Task[]> {
    const tasks = of(TASKS);
    return tasks;
  };
}
