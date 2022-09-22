import { Component, OnInit } from '@angular/core';
import {FormControl} from '@angular/forms';
import {MatDrawerMode} from '@angular/material/sidenav';



@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})



export class HomeComponent implements OnInit {

  events: string[] = [];

  opened!: boolean;

  constructor() { }

  ngOnInit(): void {
  }

}
