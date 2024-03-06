import { Component, Input } from '@angular/core';
import { ButtonComponent } from '../button/button.component';
import { Task } from '../../interfaces/Task';

@Component({
  selector: 'app-task-item',
  standalone: true,
  imports: [ButtonComponent],
  templateUrl: './task-item.component.html',
  styleUrl: './task-item.component.css'
})
export class TaskItemComponent {
  @Input() task: Task = {
    text: '',
    day: '',
    reminder: false
  };
}
