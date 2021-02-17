import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Component } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  data: Student = {
    name: "",
    age: "",
    city: "",
    logo: null
  }

  constructor(
    private http: HttpClient
  ) {
  }

  save(fileinput) {
    let form = new FormData();
    this.data.logo = fileinput.files[0];
    // If logo is null that time also you can recieve request
    Object.getOwnPropertyNames(this.data).forEach(p => form.append(p, this.data[p]));
    this.http.post('https://localhost:44321/WeatherForecast/Save', form).subscribe((data) => {
      alert(JSON.stringify(data));
    });
  }

  saveWithoutFile() {
    this.data.logo = null;
    this.http.post('https://localhost:44321/WeatherForecast/SaveWithoutFile', this.data).subscribe((data) => {
      alert(JSON.stringify(data));
    });
  }
}
interface Student {
  name: string,
  age: string,
  city: string,
  logo: File
}