import { Component } from '@angular/core';
import { TaskServiceService } from '../../services/task-service.service';
import { Task } from '../../interfaces/Task';
import { NgFor } from '@angular/common';
import { ButtonComponent } from '../button/button.component';
import { TaskItemComponent } from '../task-item/task-item.component';

@Component({
  selector: 'app-tasks',
  standalone: true,
  imports: [NgFor, TaskItemComponent],
  templateUrl: './tasks.component.html',
  styleUrl: './tasks.component.css'
})
export class TasksComponent {
  tasks: Task[] = [];

  constructor(private TaskService: TaskServiceService) {

  }

  ngOnInit(): void {
    this.TaskService.getTasks().subscribe((tasks) => {
      this.tasks = tasks;
    });
  }
}
