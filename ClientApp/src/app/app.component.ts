import { Component, ViewChild } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { NgModel } from '@angular/forms';

import { combineLatest } from "rxjs";
import { debounceTime } from "rxjs/operators";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'app';
  data: any;

  keyword = '';
  @ViewChild('tKeyword') tKeyword: NgModel;

  zone = '';
  @ViewChild('tZone') tZone: NgModel;

  ticketInfo = '';
  @ViewChild('tTicketInfo') tTicketInfo: NgModel;

  constructor(private http: HttpClient) {}
  ngOnInit(): void {
    this.http.get('/api/spots').subscribe((value: any) => {
      this.data = value;
    });
  }

  ngAfterViewInit() {

    combineLatest(
      this.tKeyword.valueChanges,
      this.tZone.valueChanges,
      this.tTicketInfo.valueChanges
    )
    .pipe(
      debounceTime(500)
    )
    .subscribe(evt => {
      let [k, z, t] = evt;
      this.http.get('/api/spots?k=' + k + '&z=' + z + '&t=' + t).subscribe((value: any) => {
        this.data = value;
      });
    });

  }
}
