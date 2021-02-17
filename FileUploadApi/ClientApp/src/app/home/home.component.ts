import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Component } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  data: Student = {
    name: "demo",
    logo: null
  }

  constructor(
    private http: HttpClient
  ) {
  }

  save(fileinput) {
    // let form = new FormData();
    // form.append('logo', fileinput.files[0]);
    this.data.logo = fileinput.files[0];
    this.http.post('https://localhost:44321/WeatherForecast', this.data).subscribe((data) => {
      console.log(data);
    });
  }
}
interface Student {
  name: string,
  logo: File
}