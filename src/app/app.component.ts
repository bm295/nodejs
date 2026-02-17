import { Component, computed, signal } from '@angular/core';

@Component({
  selector: 'app-root',
  standalone: true,
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  readonly title = signal('Angular 19 Rewrite Complete');
  readonly description = signal('This repository has been migrated from ad-hoc Node.js scripts to a modern Angular 19 application.');
  readonly subtitle = computed(() => `${this.title()} ✅`);
}
