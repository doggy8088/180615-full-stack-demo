import { Component, ViewChild } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { NgModel } from '@angular/forms';

import { combineLatest, Observable } from 'rxjs';
import { debounceTime, mergeMap } from 'rxjs/operators';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'app';
  data$: Observable<any>;

  keyword = '';
  @ViewChild('tKeyword') tKeyword: NgModel;

  zone = '';
  @ViewChild('tZone') tZone: NgModel;

  ticketInfo = '';
  @ViewChild('tTicketInfo') tTicketInfo: NgModel;

  constructor(private http: HttpClient) {}
  ngOnInit(): void {
    this.data$ = this.http.get('/api/spots');
  }

  ngAfterViewInit() {
    this.data$ = combineLatest(
      this.tKeyword.valueChanges,
      this.tZone.valueChanges,
      this.tTicketInfo.valueChanges
    ).pipe(
      debounceTime(500),
      mergeMap(evt => {
        let [k, z, t] = evt;
        return this.http.get('/api/spots?k=' + k + '&z=' + z + '&t=' + t);
      })
    );
  }
}
